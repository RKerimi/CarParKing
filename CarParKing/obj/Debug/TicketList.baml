   M S B A M L   `   `   `  ����O  KMaterialDesignColors, Version=1.1.3.0, Culture=neutral, PublicKeyToken=nullY@clr-namespace:MaterialDesignColors;assembly=MaterialDesignColorsMaterialDesignColors  5   	   E ACarParKing, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:CarParKing
CarParKing 5   	      CarParKing.TicketList   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   U QMaterialDesignThemes.Wpf, Version=2.3.0.823, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   [materialDesignColors@clr-namespace:MaterialDesignColors;assembly=MaterialDesignColors  5   	   $localclr-namespace:CarParKing  5   	     N� Title$  
TicketList��5
   	   $	��475��5   	   $	��720��6    � 	Resources 5         MaterialPrimary  MaterialPLight 
 Color1��%�   &	        &	 !     &	 B     ��5   
   	#FF7884CC��63   ��5   
   	#FFAAB3FF��62   ��5   
   	#FFB3E5FC��6*   5      .��5      � $	��371��6L   $��Bottom=�6Y   $��0,0,0,66q�6t    � DataContext 6   ��   carParkViewModel �� Source# [ ��5   
   �� 5       �� Color# �  6    � RowDefinitions 5   
   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   $	��689��6,   .+�5"   
   �� $��0��6   $��0,46,0,-113q�6%   $	��315��6:   $	��Top=�6G   .+�5#      �� -   5        $��0��5#      $��0��6%   $��32��62   $��71��6?   $
��Left=�6K   $��
10,10,0,10q�6f   $��8)�6z   ���	#FFFBFAFA J� RenderTransformOrigin$ 0.5,0.5&�6�   ��5$      �� 5%      $ 	#FF7884CC��6&   .��5&   %   Alle5'      �� 5(      $��0��6   $��1��6%   $��30��62   $��71��6?   $
��Left=�6K   $��
10,10,0,10q�6f   $��8)�6z   ���	#FFF9F9F9��5)      �� 5*      # �   6&   .��5+   %   Aktive5,      �� 5-      $��0��6   $��2��6%   $��30��62   $��71��6?   $
��Left=�6K   $��
10,10,0,10q�6f   $��8)�6z   ���	#FFF9F9F9��5.      �� 5/      # �   6&   .��50   %   
Inaktive51      �� 52      $��0��6   $��3��6%   $��30��62   $��71��6?   $
��Left=�6K   $��
10,10,0,10q�6f   $��8)�6z   ���	#FFF9F9F9��53      �� 54      # �   6&   .��55   %   
Bearbeiten56      �� 57      $��0��6   $��5��6%   $��31��62   $��71��6?   $
��Left=�6K   $��
10,10,0,10q�6f   $��8)�6z   ���	#FFF9F9F9��58      �� 59      # �   6&   .��5:   %   
Löschen5;      5<      �� 5>   
   $	��Top=�6   $ 0.501,3.438&�6,   $
��Left=�6P   $��
240,19,0,0q�6k   $��20��6   $
��Bold"�6�   $��16(�6�   $��Italic$�6�   $��1��6�   �� 6�   $�Ticketübersicht��6�   6�   &   System.Windows.Controls.DataGrid  5?   
   -   5          Name$ 	DataGrid1��5?   0   $��1��6   $��0��6#   $��146,69,240,-60q�6D   $
��Bold"�5@   h   	   AutoGenerateColumns	 .  
 �� SelectedItem
 6   �� *SelectedTicket+��6;   �� *	Tickets+ �� Mode$ OneWay=���5A      �� 5B      # �  6"      Columns 5D      0  *System.Windows.Controls.DataGridTextColumn  5E      ,  &System.Windows.Controls.DataGridColumn   Header$ Ticketnummer��6O   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *
TicketId+$ OneWay=�   
Foreground 5F      �� 5G       �� EndPoint$ 0.5,1&�6.    �� 
StartPoint$ 0.5,0&�6?   .��5H      �  � Color$ Black��6+    � Offset$ 0Q�69   � 5I      $ 	#FF270B0B��6+   $ 1Q�6=   5J      5L        5M      $ Einfahrtszeit��6P    6%   �� *	EntryTime+$ OneWay=�6P     5N      $ Ausfahrtszeit��6O    6%   �� *
ExitTime+$ OneWay=�6O     5O      $ Preis��6R    6%   �� *TicketPrice+$ OneWay=�6R   5Q      5S      5T      