   M S B A M L   `   `   `  ����E  AServerChat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:ServerChat.MVVM.ViewServerChat.MVVM.View  5   	   E'clr-namespace:ServerChat.MVVM.ViewModelServerChat.MVVM.ViewModel  6:   %    ServerChat.MVVM.View.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:ServerChat.MVVM.View     5   	   =	viewmodel'clr-namespace:ServerChat.MVVM.ViewModel     6:     � Title$  
TeacherApp��5   	   $	��450��6   $	��800��6)    � DataContext 5      -  'ServerChat.MVVM.ViewModel.MainViewModel  5   
   .��5      �  � ColumnDefinitions 5   
   �� 5      $
�� 200 �6   �� 5      $
��125* �6   �� 5      $
��183* �6   .+�5   
   ]� .+�5      � $	��Top=�6   .+�5      �� -   5        $��UsernameHint��5   C   $��Username��6   
�������6C   �� 5      -   5        $��UsernameBox��5      $��25��5      $	��Top=�5      
������ ��5      �� *
Username+ �� UpdateSourceTrigger$ PropertyChanged=�5      5      � 5!      $	��Top=�6   .+�5"      �� -   5        $��ServerAddressHint��5"   E   $��
IP Address��6   
�������6E   �� 5#      -   5        $��ServerAddressBox��5(      $��25��5#      $	��Top=�5$      
������ ��5&      �� *ServerAddress+$ PropertyChanged=�5(      5)      � 5+      $	��Top=�6   .+�5,      �� -   5        $��ServerPortHint��5,   F   $��Port Number��6   
�������6F   �� 5-      -   5        $��ServerPortBox��52      $��25��5-      $	��Top=�5.      
������ ��50      �� *
ServerPort+$ PropertyChanged=�52      53      �� 55      -   5         ��Name$ ConnectButton��55      
������ $��25��57      $	��Top=�58      $��Connect��59      ��5:      �� *ConnectToServerCommand+5;      �� 5>      -   5        $ ChangeListButton��5>      $��25��5?      $	��Top=�5@      $��Show Help Queue��5A      5B      �� 5E      -	   5         ��Name$ ConnectedUsers��5E      $	��Top=�5G      $y�	Collapsed=�5H      ��5F      �� *Users+��5I      �� 5J      .R�5K      �� ��6$   �� *
Username+5L      5N      �� 5Q      -
   5        $ HelpQueueUsers��5Q      $	��Top=�5S      $y�	Collapsed=�5T      ��5R      �� *	HelpQueue+��5V      �� 5W      .R�5X      �� ��6$   �� *
Username+5Y      5[      �� 5]      -   5        $ PopQueueButton��5]      $��25��5^      $��Bottom=�5_      $��Bottom=�5`      $��Pop One From Queue��5a      ��5b      �� *PopHelpQueueCommand+5d      �� 5f   
   $��1��6   $��Bottom=�6%   $��2��6@   .+�5i      �� -   5        $ MessageList��5i      $y�	Collapsed=�5j      ��5k      �� *
Messages+� 5m      .+�5o      �� -   5         ��Name$ 
MessageBox��5o      $��0��5p      $��55��5q      $
��Auto��5r      $��Center=�5s      ��5t      �� *	Message+$ PropertyChanged=�5u      �� 5w      -   5        $ 
SendButton��5w      $��1��5x      $��Right=�5y      $��55��5z      $
��Send��6$   ��5{      �� *SendMessageCommand+5|      5~      5      5�      5�      