   M S B A M L   `   `   `  ����E  ACarParKing, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:CarParKing
CarParKing  5   	       CarParKing.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   U QMaterialDesignThemes.Wpf, Version=2.3.0.823, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   $localclr-namespace:CarParKing  5   	     � Title$  CarParking Übersicht��5	   	   $	��520��5
   	   $	��720��5   	    � 	Resources 5      ��%    5      .��5      � .+�5   
   �  � DataContext 6   ��    carParkViewModel �� Source# [   � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $��2* �6    .+�5      o� $��0��6    o� 
IsMainMenu . $	��Top=�64   $	��Top=�6I   ���	#FFC8A6E0$��50��6x   $��Bottom=�6�   .@�5      m� $��_View��6   $��50��6+   .@�5      m� -   5        $��_Übersicht��5       64   m� 5      -   5        $��
TicketList��5      63   m� 5       -   5        $��ParkingList��5       64   m� 5!      $
��Exit��6    m� InputGestureText$ Ctrl+E��6-    m� Icon 5"      '  !MaterialDesignThemes.Wpf.PackIcon  5#      �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.3.0.823, Culture=neutral, PublicKeyToken=null]]   Kind$ 	ExitToApp=�66   5%      �� 5&      5'      m� 5(      $��_Info��6   .@�5)      m� $��_CarParKing��6    5*        5+      $	 Car=�66   5-      5.      5/      �� 50      -   5        $	��150��50      $��2��51      )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$&	  Bitte wälen Sie eine Parkanlage��6    
 J� RenderTransformOrigin$

 0,-5&�52      $��412,374,-105,10q�60   $��39��6I    �� DisplayMemberPath$
 Name��6z   ��6U   �� *ParkingPlace+ �� SelectedValue 53      �� *ParkingPlaceForTicketSelect+ �� Mode$ OneWay=� J� Effect 54      3  -System.Windows.Media.Effects.DropShadowEffect  55      57      �� 58      $��Center=�6   $��Right=�6/   $��0��6L   $��0��6Y   $��Image\Logo.PNG��59      $
 0.86,0.5&�5:      $��30��62   $
��Auto��6?   $��5q�6L   �� 5<      $��1��6   $��0��6"   $��Image\Logo.PNG��5=      $
 0.86,0.5&�5>      $
��Auto��62   $��
38,0,46,88q�6?   $��2��6S   5@      � 5A   
   $��0��6   .+�5B       � -   5          �Name$ 	MainFrame��5B        � NavigationUIVisibility$ Hidden=�6)   ���	#FFA22F2F6I   5C      5D      5F      