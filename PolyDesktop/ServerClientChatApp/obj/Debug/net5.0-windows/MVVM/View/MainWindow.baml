   M S B A M L   `   `   `  ����E  AChatClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ServerClientChatAppServerClientChatApp  5   	   E'clr-namespace:ChatClient.MVVM.ViewModelChatClient.MVVM.ViewModel  69   $    ServerClientChatApp.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:ServerClientChatApp     5   	   =	viewmodel'clr-namespace:ChatClient.MVVM.ViewModel     69     � Title$  
StudentApp��5   	   $	��474��6   $	��816��6)    � DataContext 5
      -  'ChatClient.MVVM.ViewModel.MainViewModel  5   
   .��5      �  � ColumnDefinitions 5   
   �� 5      $
�� 200 �6   �� 5      $
��125* �6   �� 5      $
��183* �6   .+�5   
   ]� .+�5      � $	��Top=�6   .+�5      �� -   5        $��UsernameHint��5   C   $��Username��6   
�������6C   �� 5      -   5        $��UsernameBox��5      $��25��5      $	��Top=�5      
������ ��5      �� *
Username+ �� UpdateSourceTrigger$ PropertyChanged=�5      5      � 5       $	��Top=�6   .+�5!      �� -   5        $��ServerAddressHint��5!   E   $��
IP Address��6   
�������6E   �� 5"      -   5        $��ServerAddressBox��5'      $��25��5"      $	��Top=�5#      
������ ��5%      �� *ServerAddress+$ PropertyChanged=�5'      5(      � 5*      $	��Top=�6   .+�5+      �� -   5        $��ServerPortHint��5+   F   $��Port Number��6   
�������6F   �� 5,      -   5        $��ServerPortBox��51      $��25��5,      $	��Top=�5-      
������ ��5/      �� *
ServerPort+$ PropertyChanged=�51      52      �� 54      -   5         ��Name$ ConnectButton��54      
������ $��25��56      $	��Top=�57      $��Connect��58      ��59      �� *ConnectToServerCommand+5:      �� 5=      -   5        $ ChangeListButton��5=      $��25��5>      $	��Top=�5?      $��Show Help Queue��5@      5A      �� 5D      -	   5         ��Name$ ConnectedUsers��5D      $	��Top=�5F      $y�	Collapsed=�5G      ��5E      �� *Users+��5H      �� 5I      .R�5J      �� ��6$   �� *
Username+5K      5M      �� 5P      -
   5        $ HelpQueueUsers��5P      $	��Top=�5R      $y�	Collapsed=�5S      ��5Q      �� *	HelpQueue+��5T      �� 5U      .R�5V      �� ��6$   �� *
Username+5W      5Y      �� 5[      -   5        $ RequestHelpButton��5[      $��25��5\      $��Bottom=�5]      $��Bottom=�5^      $��Request Help��5_      ��5`      �� *RequestHelpCommand+5b      �� 5d   
   $��1��6   $��Bottom=�6%   $��2��6@   .+�5g      �� -   5        $ MessageList��5g      $y�	Collapsed=�5h      ��5i      �� *
Messages+� 5k      .+�5m      �� -   5         ��Name$ 
MessageBox��5m      $��0��5n      $��55��5o      $
��Auto��5p      $��Center=�5q      ��5r      �� *	Message+$ PropertyChanged=�5s      �� 5u      -   5        $ 
SendButton��5u      $��1��5v      $��Right=�5w      $��55��5x      $
��Send��6$   ��5y      �� *SendMessageCommand+5z      5|      5}      5      5�      