   M S B A M L   `   `   `  ����  
CarParKing    CarParKing.ParkingList   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $	��720��5        N� Title$  Parkplatzübersicht��5   	    � 	Resources 5
         Button1  Button2  Button3  
Background 
 Color1��%�   &	        &	 !     &	 B     &	 c     &	 �     ��5   
   	#FFAAB3FF��6+   ��5   
   	#FFAAB3FF��6+   ��5   
   	#FFAAB3FF��6+   ��5   
   	#FFB3E5FC��6.   ��5   
   	#FF5C6BC0��6*   5      .��5      �  � DataContext 6   ��   carParkViewModel �� Source# [ .+�5   
   �� $��0��6   $��	0,50,0,62q�6%   ��5      �� 5       �� Color# �  6"   .+�5      �� $	��Top=�6    J� RenderTransformOrigin$ 0.501,3.438&�60   $
��Left=�6T   $��312,10,0,10q�6o   $��20��6�   $
��Bold"�6�   $��16(�6�   $��Italic$�6�   �� 6�   $�Parkplatzübersicht��6�   6�   �� 5      -   5        $��29��5      $��80��6"   $
��Left=�6.   $��
10,10,0,10q�6I   $��8)�6]   $��
Bearbeiten��6y   ��5      �� 5      # �   6&   5      �� 5      -   5        $��30��5   (   $��80��65   $
��Left=�6A   $��
10,10,0,10q�6\   $��8)�6p   $	��Neu��6   ��5      �� 5       # �  6&   5"      �� 5#      -   5        $��30��5#      $��80��6"   $
��Left=�6.   $��
10,10,0,10q�6I   $��8)�6]   $��Löschen��6{   ��5$      �� 5%      # �  6&   5'      5(      &   System.Windows.Controls.DataGrid  5*   
   -   5          Name$ 	DataGrid1��5*         AutoGenerateColumns .  $��0��6C   $	��Top=�5+   s   $
��Left=�6�   $ 0.5,0.5&�6�   $��171,106,0,0q�6�    �� SelectedIndex$ 1��6�   $	��385��6�   ���	#FFAAB3FF	 �� SelectedItem	 6   �� *SelectedParkingPlace+��6A   �� *ParkingPlace+
 �� Mode$
 OneWay=�z�5,      V� 5-      .~�5.      �� �� 5/      �� 50       �� Angle$ 0.176Q�6&   T� 51      52         Columns 54      0  *System.Windows.Controls.DataGridTextColumn  55      ,  &System.Windows.Controls.DataGridColumn   Header$ id��6I   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *id+$
 OneWay=�6I     56      $ Parkplatzname��6K    6%   �� *Name+$
 OneWay=�6K     57      $ Anzahl Parkplätze��6[    6%   �� *numberOfParkingSlots+$
 OneWay=�6[     58      $ Kosten/h��6S    6%   �� *pricePerHour+$
 OneWay=�6S   5:      5;      5<      