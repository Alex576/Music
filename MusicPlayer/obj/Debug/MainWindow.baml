   M S B A M L   `   `   `  ����F  BMusicPlayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:MusicPlayerMusicPlayer  5   	   Z VWPFSoundVisualizationLib, Version=0.4.7508.30949, Culture=neutral, PublicKeyToken=nulleHclr-namespace:WPFSoundVisualizationLib;assembly=WPFSoundVisualizationLibWPFSoundVisualizationLib 5   	       MusicPlayer.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:MusicPlayer     5   	   XsvlHclr-namespace:WPFSoundVisualizationLib;assembly=WPFSoundVisualizationLib     5   	   -   5        $��
mainWindow��5	   L     � Title$  
MainWindow��6	   $	��450��6   $	��800��6)    J� 	AllowDrop .  � Icon$ Images\IconMusic.ico��6�    � 	Resources 5
         MusicPlayer.IntToDate   	MyConvert��%   &	          5   
   6.   5      .��5      � ��5   
   �� 5       �� ImageSource$ Images/Background.jpg��6    j� Stretch$ UniformToFill=�6=    � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      �� 5      $��28 �6   6*   �� 5      $��50 �6   6*    � ColumnDefinitions 5   
   �� 5      $	��100 �6   6-   �� 5      6!   �� 5      $	��100 �6   6-   �� 5      -   5         �Name$ ListOfSongsGrid��5   ;   $
��auto �6   $	��300��6,   6T   .+�5   
   � $
��auto��6   $��3��6    5       �� 5!      6%   �� 5"      $
��auto �6#   63   .+�5$      �� -   5        $��OpenCloseListOfSongs��5$   <   $��1��6   $��20��6%   $��20��61   6u   �� 5%      -   5        $
��name��5%      
�������65   5&      /  )WPFSoundVisualizationLib.SpectrumAnalyzer  5(   
   -   5        	  Name$	 spectrumAnalyzer��5(      $��5q�69   
   BarCount$
 64��6D   $��3��6R   $��1��6f   �� 5)   
   -   5         ��Name$ listBox��5)      $��0��6#   $��4��60   $��3��6A   
������� �� SelectionMode$ Extended=�6d   ���	#00000000 � ContextMenu 5*      �� 5+      
���   �.@�5,      m� -   5        $��Delete��5,      6I   5-      ��5/      �� 50       �� Triggers 51      P� 52       P� Property �@��
IsSelected P� Value . . �53      ��  �� Property � �� �� Value
 �  ��6U   54      56      58      r� 59   
   -   5        $��Player��59   H   $��0��6   $��1��6'   $��3��64    r� LoadedBehavior$ Manual=�6V    r� Volume$ 1Q�6n   $y�Hidden=�6�   6�   �� 5:   
   -	   5        $��progress��5:      $��3��6!   $��1��6.   $��14q�6>    �� Interval$ 20��6J   6�   �� 5;   
   -
   5        $��
SoundValue��5;      $��2��6#   $��2��60   $��2q�6@    � Value$	 0.1Q�6K    � Maximum$ 1Q�6W   6|   �� 5<   
   $��2��6�   $��3��6�   $��10q�6�    �� TextAlignment$ Center=�6�   $��Center=�6�   $��Center=�6�   $��15(�6	  
���   �
���������6   ��  �� ElementName$ progress�� �� Path$ Maximum� �� UpdateSourceTrigger$ PropertyChanged=� �� 	Converter# [  6?  �� 5=   
   $��0��6�   $��3��6�   $��10q�6�   $ Center=�6�   $��Center=�6�   $��Center=�6�   $��15(�6  
���   �
���������6   �� $ progress��$ Value�$ PropertyChanged=�# [  6=  � 5>   
   $��1��6   $��2��6    5?      �� 5@      $��* �6#   6/   �� 5A      $��50 �6#   60   �� 5B      $��50 �6#   60   �� 5C      $��50 �6#   60   �� 5E      $��50 �6#   60   �� 5F      $��* �6#   6/   .+�5I      �� -   5        $��2q�5I      $��1��6    .��5J      �� -   5        $��Preview��5J   4   $��Images/preview.png��6   6E   5K      �� 5L      -   5        $��2q�5L      $��2��6    .��5M      �� -   5        $��
StartPause��5M   2   $��Images/start.png��6   6F   5N      �� 5O      -   5        $��2q�5O      $��3��6    .��5P      �� $��Images/break.png��6   64   5Q      �� 5R      -   5        $��2q�5R      $��0��6    $
��Left=�6@   .��6[   New6`   �� 5S      -   5        $��2q�5S      $��4��6    .��5T      �� -   5        $
��Next��5T   1   $��Images/next.png��6   6?   5U      �� 5V      -   5        $��
SoundImage��5V   @   $��5��6   $��Right=�6$   $��Images/SoundOn.png��6R   6p   5W      5\      5]      