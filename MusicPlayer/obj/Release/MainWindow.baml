   M S B A M L   `   `   `  ���� F  BMusicPlayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:MusicPlayerMusicPlayer  Z VWPFSoundVisualizationLib, Version=0.4.7463.32674, Culture=neutral, PublicKeyToken=nulleHclr-namespace:WPFSoundVisualizationLib;assembly=WPFSoundVisualizationLibWPFSoundVisualizationLib     MusicPlayer.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     +localclr-namespace:MusicPlayer     XsvlHclr-namespace:WPFSoundVisualizationLib;assembly=WPFSoundVisualizationLib     -   $��
mainWindow��  � Title$  
MainWindow��$	��450��$	��800�� J� 	AllowDrop .  � Icon$ Images\IconMusic.ico�� � 	Resources    MusicPlayer.IntToDate   	MyConvert��%   &	          .��� ����  �� ImageSource$ Images/Background.jpg�� j� Stretch$ UniformToFill=� � RowDefinitions �� $
��auto ��� �� $��28 ��� $��50 � � ColumnDefinitions �� $	��100 ��� �� $	��100 ��� -    �Name$ ListOfSongsGrid��$
��auto �$	��300��.+�� $
��auto��$��3�� �� �� $
��auto �.+��� -   $��OpenCloseListOfSongs��$��1��$��20��$��20���� -   $
��name��
�������/  )WPFSoundVisualizationLib.SpectrumAnalyzer  -   	  Name$	 spectrumAnalyzer��$��5q�
   BarCount$
 64��$��3��$��1���� -    ��Name$ listBox��$��0��$��4��$��3��
������� �� SelectionMode$ Extended=����	#00000000 � ContextMenu �� 
���   �.@�m� -   $��Delete������  �� Triggers P�  P� Property �@��
IsSelected P� Value . . ���  �� Property � �� �� Value
 �  ��r� -   $��Player��$��0��$��1��$��3�� r� LoadedBehavior$ Manual=� r� Volume$ 1Q�$y�Hidden=��� -	   $��progress��$��3��$��1��$��14q� �� Interval$ 20���� -
   $��
SoundValue��$��2��$��2��$��2q� � Value$	 0.1Q� � Maximum$ 1Q��� $��2��$��3��$��10q� �� TextAlignment$ Center=�$��Center=�$��Center=�$��15(�
���   �
�����������  �� ElementName$ progress�� �� Path$ Maximum� �� UpdateSourceTrigger$ PropertyChanged=� �� 	Converter# [  �� $��0��$��3��$��10q�$ Center=�$��Center=�$��Center=�$��15(�
���   �
����������� $ progress��$ Value�$ PropertyChanged=�# [  � $��1��$��2�� �� $��* ��� $��50 ��� $��50 ��� $��50 ��� $��50 ��� $��* �.+��� -   $��2q�$��1��.���� -   $��Preview��$��Images/preview.png���� -   $��2q�$��2��.���� -   $��
StartPause��$��Images/start.png���� -   $��2q�$��3��.���� $��Images/break.png���� -   $��2q�$��0��$
��Left=�.��New�� -   $��2q�$��4��.���� -   $
��Next��$��Images/next.png���� -   $��
SoundImage��$��5��$��Right=�$��Images/SoundOn.png��