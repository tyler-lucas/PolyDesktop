   M S B A M L   `   `   `  ���� M  IPolyDesktopGUI-WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:PolyDesktopGUI_WPFPolyDesktopGUI_WPF  K GOmotVnc.Controls, Version=1.0.0.5, Culture=neutral, PublicKeyToken=nullcCclr-namespace:PollRobots.OmotVnc.Controls;assembly=OmotVnc.ControlsPollRobots.OmotVnc.Controls &     PolyDesktopGUI_WPF.BasicModePage   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     2local clr-namespace:PolyDesktopGUI_WPF     XControlsCclr-namespace:PollRobots.OmotVnc.Controls;assembly=OmotVnc.Controls       N� Title$  BasicModePage��.��� 
���   �.+�]� .+�o� -   $��MainMenu��$	��Top=�.@�m� $
��File��.@�m� $��
Connect...�� m� Command �� *ConnectCommand+m� $��
Disconnect�� �� *DisconnectCommand+�� m� $
��Exit�� �� *ExitCommand+m� $��Display��.@�m� $
��Zoom��.@�m� $	��50%�� m� CommandParameter$ 50�� �� *SetScaleCommand+m� $	��75%��$ 75�� �� *SetScaleCommand+m� $
��100%��$	 100�� �� *SetScaleCommand+m� $
��150%��$	 150�� �� *SetScaleCommand+m� $
��200%��$	 200�� �� *SetScaleCommand+�� m� $��Fit in window�� �� *SetScaleToFitCommand+m� $��Refresh�� �� *RefreshCommand+m� $��Toggle local cursor�� �� *ToggleLocalCursorCommand+)  #PollRobots.OmotVnc.Controls.VncHost  -     Name$ VncHost��   Scale �� *Scale+   
ScaleToFit �� *
ScaleToFit+�� -    ��Name$ 
BackButton�� � ToolTip$ Return to Main Menu��$	��Top=�$
��Left=�$��0,20,0,0q�.���� $'��!Resources/PolyDesktopTrayIcon.png��$��53��$��53��