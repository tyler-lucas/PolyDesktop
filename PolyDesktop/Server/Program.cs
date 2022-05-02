﻿using Server.Net.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;

namespace Server
{
    class Program
    {
        static List<Client> _users;
        static List<Client> _helpqueue;
        static TcpListener _listener;
        static void Main(string[] args)
        {
            _users = new List<Client>();
            _helpqueue = new List<Client>();
            _listener = new TcpListener(System.Net.IPAddress.Any, 0);
            _listener.Start();

            //Get and Dispplay Local IP Address
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    Console.WriteLine("Server Address: " + ip.ToString());
                }
            }

            //Display Port Number
            Console.WriteLine("Server Port: " + ((IPEndPoint)_listener.LocalEndpoint).Port.ToString());
            
            while(true)
            {
                var client = new Client(_listener.AcceptTcpClient());
                _users.Add(client);

                //Broadcast current connections and helpqueue to every new client connection
                BroadcastConnection();
                BroadcastHelpQueue();
            }
        }

        static void BroadcastConnection()
        {
            foreach (var user in _users)
            {
                foreach (var usr in _users)
                {
                    var broadcastPacket = new PacketBuilder();
                    broadcastPacket.WriteOpCode(1);
                    broadcastPacket.WriteMessage(usr.Username);
                    broadcastPacket.WriteMessage(usr.UID.ToString());
                    user.ClientSocket.Client.Send(broadcastPacket.GetPacketBytes());
                }
            }
        }
        
        public static void BroadcastMessage(string message)
        {
            foreach(var user in _users)
            {
                var msgPacket = new PacketBuilder();
                msgPacket.WriteOpCode(5);
                msgPacket.WriteMessage(message);
                user.ClientSocket.Client.Send(msgPacket.GetPacketBytes());
            }
        }

        static void BroadcastHelpQueue()
        {
            foreach (var user in _users)
            {
                foreach (var usr in _helpqueue)
                {
                    var requestPacket = new PacketBuilder();
                    requestPacket.WriteOpCode(15);
                    requestPacket.WriteMessage(usr.UID.ToString());
                    user.ClientSocket.Client.Send(requestPacket.GetPacketBytes());
                }
            }
        }

        public static void AddToHelpQueue(string uid)
        {
            var requestingUser = _users.Where(x => x.UID.ToString() == uid).FirstOrDefault();
            _helpqueue.Add(requestingUser);

            //After adding a new user to queue, rebroadcast it to everyone
            BroadcastHelpQueue();
        }

        public static void BroadcastDisconnect(string uid)
        {
            var disconnectedUser = _users.Where(x => x.UID.ToString() == uid).FirstOrDefault();
            _users.Remove(disconnectedUser);

            foreach (var user in _users)
            {
                var broadcastPacket = new PacketBuilder();
                broadcastPacket.WriteOpCode(10);
                broadcastPacket.WriteMessage(uid);
                user.ClientSocket.Client.Send(broadcastPacket.GetPacketBytes());
            }

            BroadcastMessage($"[{disconnectedUser.Username}] Disconnected!");
        }

    }
}
