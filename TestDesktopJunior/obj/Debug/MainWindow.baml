   M S B A M L   `   `   `  ����N  Jtest_desktop_junior, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:test_desktop_juniortest_desktop_junior  5   	   ]3clr-namespace:test_desktop_junior.Resources.Classes%test_desktop_junior.Resources.Classes  5   ?   $    test_desktop_junior.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:test_desktop_junior     5   	   _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  5   	   Aclasses3clr-namespace:test_desktop_junior.Resources.Classes  6?   -   5        $��main_window��5         � Title$  
MainWindow��5	   	   $	��750��6   $
��1400��6)    � WindowStyle$
 None=�66   $	��800��5
   	   $	��600��6    � 
ResizeMode$ 	CanResize=�5   	    � WindowStartupLocation$ CenterScreen=�63    � AllowsTransparency .  � WindowState 5   	   �� *ThisWindowState+��5   #   Z� ��69   Z�  � 	Resources 5      A  ;test_desktop_junior.Resources.Classes.StringFormatConverter   StringFormatConverter  ThisBtnStyle �� 
TargetType �� Property	 �� Value
 �� 
TargetType �� Triggers P� Property P� Value��%*  &	        &	        5   
   6(   �� 5   
   " ��6%   .�5      ��  � ��	 5      �� 5      "
 ��6&   .R�5      � #��z��6   .+�5      �� $��Center=�6/   $��Center=�5   /   5       5      P� 5       �@J�	IsVisible . . �5   "   ��  �@J�Opacity$		 0.8Q�6<   5      P� 5        �@J�IsMouseOver . . �5!   "   ��  �@J�Opacity$	 1Q�6<   5"      P� 5#       �@J�IsMouseCaptured . . �5$   "   ��  �@J�Opacity$		 0.2Q�6<   5%      5'      5)      5*      5+      .��5-      ��  �� CornerRadius$ 9��6   $��2q�5.      ���#474747._�50   
   �  � RowDefinitions 52      �� 53      $
��Auto �6    60   �� 54      6"   .+�57      �� $��0��6   $��2��58      $/��)/Resources/Images/BackgroundDarkTheme.png��59      $��UniformToFill=�5:      �� 5=      $��0��6   $��2��5>      
������ $��75,100,75,100q�5@      $
��Auto=�5A      .��5B      � $��Center=�6   $��Center=�5C       � ColumnDefinitions 5E      �� 5F      $
��Auto �6+   6:   �� 5G      $
��Auto �6+   6:   �� 5H      $
��Auto �6+   6:    5K      �� 5L      $
��Auto �6(   68   �� 5M      $
��Auto �6(   68   .+�5Q      �� $��0,0,0,0q�6!   $��0��62   .+�5R      ��  �� Orientation$ 
Horizontal=�6%   .+�5S      �� ���#CF4344$	��120��69   $
��Bold"�6E   $��16(�6W   .��6e   Название:6p   �� 5T      ���#CF4344$
��Bold"�69   $��16(�6K   .��6Y   Описание:6d   5U      �� 5W      
���   �$��0q�5X   "   $	��400��5Y   "   $	��380��5Z   "   ��5[   "   �� *Funcs+ �� SelectedItem 5\   "   �� *SelectedFunction+��5^      �� 5_   "   .R�5`   &   �� $ 
Horizontal=�61   .+�5a   *   �� 
�������$	��120��5b   0   ��5c   ,   ��  �� Path$
 Name��� 5d   *   
�������$	��220��5e   0   ��5f   ,   �� $ Description�5g   '   5h   #   5k      5l      �� 5n      $��50,0,0,0q�6!   $��1��63   $��0��6C    � DataContext 6P   �� *SelectedFunction+.+�5o      �� ���#CF4344$
��Bold"�65   $��16(�6G   .��6U   Коэффициент a:6e   �� 5p      -   5        $��var_a��5p   "   
���   �$	��150��5r   "   $��50��5s   "   
������� �� TextAlignment$ Center=�5u   "   $��0q�5v   "   $��Center=�5w   "   ��5x   "   �� *A+ �� UpdateSourceTrigger$ PropertyChanged=� �� 	Converter# [  .��6�   5y      �� 5{      ���#CF4344$
��Bold"�65   $��16(�6G   $��0,30,0,0q�6U   .��6g   Коэффициент b:6w   �� 5|      -   5        $��var_b��5|   "   
���   �$	��150��5~   "   $��50��5   "   $ Center=�5�   "   $��0q�5�   "   $��Center=�5�   "   
���������5�   "   �� *B+$ PropertyChanged=�# [  .��6�   *  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5�      +  %Microsoft.Xaml.Behaviors.EventTrigger  5�   "      	EventName$ PreviewTextInput��61   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5�   &   2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     Command 6<   �� *DragWindowCommand+   CommandParameter 6b   ��  �� RelativeSource ��  �� Mode$ FindAncestor=� �� AncestorType" �5�   #   .��5�   6   5�      �� 5�      ���#CF4344$
��Bold"�65   $��16(�6G   $��0,30,0,0q�6U   .��6g   Коэффициент c:6w   �� 5�      -   5        $��var_c��5�   #   
���   �$��50��5�   #   $��Center=�5�   #   $��0q�5�   #   $��Center=�5�   #   ��5�   #   �� *	CVariants+  �� SelectedIndex  5�   #   �� *C+$ PropertyChanged=��� 5�      $	��150��6!   $��50��5�   !   $��0,57,0,0q�5�   !   #��[ 5�   !   
������ ��5�   !   �� *
AddCommand+.��5�      �� $"��/Resources/Images/AddStr.png��6$   5�      5�      �� 5�      -   5        $��data_table_panel��5�   !   ��5�   !   �� *Margin+��5�   !   �� *ColumnProperty+��6H   �� *RowProperty+��6i   �� *RowSpanProperty+.+�5�      � .+�5�      �� ���#CF4344$
��Bold"�69   $	��200��6K   $��16(�6W   .��6e   Результат:6q   �� 5�      ���#CF4344$
��Bold"�69   $	��200��6K   $��16(�6W   .��6e   X:6i   �� 5�      ���#CF4344$
��Bold"�69   $	��200��6K   $��16(�6W   .��6e   Y:6i   5�      �� 5�      -   5        $��results_panel��5�   '    6<   �� *SelectedFunction+��6e   �� *Data+��5�      �� 5�   "   .R�5�   &   � .+�5�   *   �� 
���   �$	��200��6E   ���#CF4344! �� 
IsReadOnly! . ��6g   �� $ Result�$ PropertyChanged=�6�   �� 5�   *   
���   �$	��200��6E   
���������6e   �� $ X�$ PropertyChanged=�# [  6�   �� 5�   *   
���   �$	��200��6E   
���������6e   �� $ Y�$ PropertyChanged=�# [  6�   5�   '   5�   #   5�      � 5�      .+�5�      �� 
���   �$	��200��69   ���#CF4344! . 6n   �� 5�      
���   �$	��200��69   
�������! . 6l   �� 5�      
���   �$	��200��69   
�������! . 6l   5�      5�      5�      5�      �� 5�      -   5        $��
head_panel��5�      $	��130��5�      $��0��5�      
������  5�        5�      $ MouseLeftButtonDown��6%   . 5�         60   �� *DragWindowCommand+ 6V   ��  �� $ FindAncestor=�" �5�      .+�5�      ]� " �� Right$" 0��6   
# �� Top$# 0��5�      .+�5�      �� $
��Left=�6   #��[ 5�      
������ $��15q�5�      $��13��5�      ��5�      �� *MinimizeWindow+.��5�      �� $*��$/Resources/Images/minimizeButton.png��6    6P   5�      �� 5�      #��[ 6   
������ $��5q�5�      $��13��5�      ��5�      �� *MaximizeWindow+.��5�      �� -   5        $��maximize_bt��5�       ��5�       �� *ImageSource+6A   5�      �� 5�      $��Right=�6   #��[ 5�      
������ $��15q�5�      $��13��5�      ��5�      �� *CloseWindow+��5�      ��  �� $ FindAncestor=�" �.��5�      �� $'��!/Resources/Images/closeButton.png��6    6M   5�      5�      5�      5�      5�      5�      