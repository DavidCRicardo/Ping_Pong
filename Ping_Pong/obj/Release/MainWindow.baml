   M S B A M L   `   `   `  ���� D  @Ping_Pong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Ping_Pong	Ping_Pong      Ping_Pong.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     )localclr-namespace:Ping_Pong     -     � Icon$  icon.jpg�� � WindowStartupLocation$ CenterScreen=� � Title$ PingPong v1.1��$	��450��$	��720�� � 
ResizeMode$ NoResize=�.��� ���� .���  � Offset$ 0Q� � Color$
 Gray��.+��� -   $��
MainCanvas��$	��380��$��0,0,0,41q�.+��� -    ��Name$ player1��$��80��$��20��
���   �
 �� Top �� *	YPosition+�� -   $ player2��$��80��$��20��
���   � �� Right$ 0�� �� *	YPosition+A� -   	 A�Name$
	 ball��$��20��$��20��
 K� ZIndex$
 1�� �� Left �� *X+ �� *Y+����  �� Color$ Black���� 	 �� X1$	 350��	 �� X2$	 350��	 �� Y1$ 0��	 �� Y2$	 380��
�������$��5���� $ 0��$	 720��$	 380��$	 380��
���   �$��3����  �� TextAlignment$ Right=�$%��Copyright © David Ricardo 2017��$��10(�$
��Left=�$	��212��$	 483��$	 397���� $2��,ESC: EXIT     F3: More Speed   F4:Less Speed��$��20��$	��300��$��0,380,370,0q�