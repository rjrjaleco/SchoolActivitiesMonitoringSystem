   M S B A M L   `   `   `  ����  I Need That A9    3I_Need_That_A.ChangePercentEffectOnTotalGradeWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � Title$+  %ChangePercentEffectOnTotalGradeWindow��5   	   $	��670��5   	   $	��430��5   	    � AllowsTransparency . 
���   �$��2q�5	   	    � WindowStyle$
 None=�5
   	   .��5      � 
������� � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   
�������$��0,0,0,2q�5      ._�5      �� ���#06425C �� Orientation$ 
Horizontal=�6.   .+�5      �� $��	20,20,4,4q�6   $��35(�5      $��
ExtraLight"�5      
�������$#��Percent Effect On Total Grade��5       J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      5      �� 5      -   5         ��Name$ BtnSave��5      $��80��5      $��40��5      $��	15,4,4,10q�5       $��Bottom=�5!      $
��Save��5#      $��23(�5$      $��3q�5%       5&        5'      5)      �� 5*      -   5        $ 	BtnCancel��5*      $��80��5+      $��40��5,      $��4,4,4,10q�5-      $��Bottom=�5.      $��0q�5/      $��Cancel��51      $��23(�52      $��3q�53       54        55      57      58      59      �� 5:   
   $��1��6   
�������$ Vertical=�5<      .+�5=      �� $ Vertical=�6   .+�5>      �� $��	60,50,0,0q�6   $��Century Gothic)�5?      $��30(�5@      $��
ExtraLight"�5A      ���#51A39D$��	Old Value��5C      �� 5D      $	��540��6   $��30��5E      $��	60,10,0,0q�5F      $
��left=�5G      $��20(�5H      ��5I      ��  �� Path$ PercentEffectOnFinalGrade�5J      �� 5K      -   5         ��Name$ 
SpNewValue��5K      $ Vertical=�6-   .+�5L      �� $��	60,50,0,0q�6   $��Century Gothic)�5M      $��30(�5N      $��
ExtraLight"�5O      ���#51A39D$��	New Value��5Q      �� 5R      $	��540��6   $��30��5S      $��	60,10,0,0q�5T      $
��left=�5U      $��20(�5V      ��5W      �� $ NewPercentEffect�5X      5Y      5Z      5[      