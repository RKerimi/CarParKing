   M S B A M L   `   `   `  ����O  KMaterialDesignColors, Version=1.1.3.0, Culture=neutral, PublicKeyToken=nullY@clr-namespace:MaterialDesignColors;assembly=MaterialDesignColorsMaterialDesignColors  5   	   E ACarParKing, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:CarParKing
CarParKing 5   	      CarParKing.newParking   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   U QMaterialDesignThemes.Wpf, Version=2.3.0.823, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   [materialDesignColors@clr-namespace:MaterialDesignColors;assembly=MaterialDesignColors  5   	   $localclr-namespace:CarParKing  5   	     N� Title$  
newParking��5       � 	Resources 5         MaterialPLight 
 Color1 
 Color2 
 Color3 
 Color4 
 Color5 
 Color6 
 Color7��%X  &	        &	 !     &	 B     &	 c     &	 �     &	 �     &	 �     &	 �     ��5   
   	#FFAAB3FF��62   ��5   
   	#FFAAB3FF��6*   ��5   
   	#FFAAB3FF��6*   ��5   
   	#FFAAB3FF��6*   ��5   
   	#FFAAB3FF��6*   ��5   
   	#FFAAB3FF��6*   ��5   
   	#FFB3E5FC��6*   ��5   
   	#FF5C6BC0��6*   5      .��5      � $��0,50,0,0q�6   $	��364��6   $	��Top=�6*   ��5   
   �� 5       �� Color# �  6   .+�5   
   �� $	��Top=�6    J� RenderTransformOrigin$ 0.501,3.438&�6,   $
��Left=�6P   $��312,10,0,10q�6k   $��20��6�   $
��Bold"�6�   $��16(�6�   $��Italic$�6�   �� 6�   $�Parkplatzdetails��6�   6�   � 5   
   $��194,119,181,76q�6   .+�5      �� -   5        $��3)�5      $��136,113,108,32q�6&   $��	Speichern��6K   ��5       �� 5!      $ 	#FFB2BB74��6&   5#      �� 5%      -   5        $
��Auto��5%      $��3)�6$   $��147,142,119,4q�63   $��	Abbrechen��6J   ���	#FFF3F3F3$ 0.534,1.484&�6�   �� 5&      $��	0,0,0,137q�6   $��Anzahl Parkplätze: ��6(   $
��Left=�6F   $	��131��6a   $
��Bold"�6m   $��Center=�6   $��Bottom=�6�   ��5'      �� 5(      # �   6&   5*      �� 5+      $��0,41,214,100q�6   $��0��6+   $��Parkplatzname: ��6;   $ 0.464,1.673&�6U   $
��Bold"�6y   ��5,      �� 5-      # �   6&   5/      �� 50      $��0,75,214,66q�6   $��0��6*   $��Parkplatzkosten: ��6:   $ 0.464,1.673&�6V   $
��Bold"�6z   ��51      �� 52      # �   6&   54      �� 56      $��158,0,0,142q�6k   $��Bottom=�6�   ��6   �� *SelectedParkingPlace.Name+  carParkViewModel �� Source# [ 6�   �� 57      $	��187��6   $��0,45,0,0q�6�   $ 0.5,0.5&�6�   $��Right=�6�   $��Center=�6�   $	��Top=�6�   ��6"   �� *+)SelectedParkingPlace.numberOfParkingSlots+# [ 6�   �� 58      $	��187��6   $��0,79,0,0q�6   $ 0.5,0.5&�6�   $��Right=�6�   $��Center=�6�   $	��Top=�6�   ��6"   �� *#!SelectedParkingPlace.pricePerHour+# [ 6�   59      5:      5;      