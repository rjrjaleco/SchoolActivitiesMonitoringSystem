   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	    I Need That A   I_Need_That_A.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	     � Title$  
MainWindow��5   	   $
��1366��5   	   $	��768��5   	    � WindowState$ 	Maximized=�5   	    � WindowStyle$
 None=�5	   	   .��5
      � ��5   
   �� 5       �� ImageSource$t nC:\Users\Vinson\Desktop\School\2nd Year Programming\Final Project\I Need That A\I Need That A\Images\ZenBG.png��6    � RowDefinitions 5   
   �� 5      $��* �6   .+�5   
   � $��0��6   .+�5      ��  �� Orientation$ Vertical=�6   .+�5      �� $��	0,50,90,0q�6   $	��800��6+   $v��pC:\Users\Vinson\Desktop\School\2nd Year Programming\Final Project\I Need That A\I Need That A\Images\Drawing.png��67   �� 5      $��0,40,0,0q�6   $��Center=�5      $��Global User Interface)�5      $��80(�5      $��
ExtraLight"�5      
�������$��Select User��5       J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         ShadowDepth$ 7Q�6+   5      �� 5      -   5         ��Name$ CmbUsers��5      $	��400��5       $��60��5!      $��Center=�5"      $��40(�5#      $��
ExtraLight"�5$      $��3q�5&      ��5%      �� 	 �� Path$	 	ListUsers�
 �� SelectedItem
 5'      �� $	 SelectedUser��� 5(      $��Center=�6   $ 
Horizontal=�6:   .+�5)      �� -   5         ��Name$ 
BtnAddUser��5)      $	��230��5*      $��	0,20,15,0q�5+      $��Center=�5,      $��New User��5.      $��50(�5/      $��Light"�50      $��10q�51       52        53      55      �� 56      -   5        $ BtnEnter��56      $	��230��57      $��0,20,0,0q�58      $��Center=�59      $��Enter��5;      $��50(�5<      $��Light"�5=      $��10q�5>       5?        5@      5B      5C      �� 5D      -   5        $ BtnExit��5D      $	��150��5E      $��0,30,0,0q�5F      $��Center=�5G      $
��Exit��5I      $��50(�5J      $��Light"�5K      $��10q�5L       5M        5N      5P      5Q      5R      5S      5U      