   M S B A M L   `   `   `  ����H  DWPF HelloWord, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WPF_HelloWord.FormWPF_HelloWord.Form  5   	   *    $WPF_HelloWord.Form.E39ListBoxControl   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:WPF_HelloWord.Form     5   	     � Title$  E39ListBoxControl��5   	   $	��450��6#   $	��800��60   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��10q�6   .@�5      �� .��6   List box item 016,   �� 5      .��6   List box item 016,   �� 5      .��6   List box item 016,   5      �� 5   
   $��10q�6   $��1��6   .@�5      �� .��5      ��  �� Orientation$ 
Horizontal=�6   .+�5      A� $��10��6   $��10��6*   
���  ��65   �� 5      List box Item 0162   5      5      �� 5       .��5!      �� $ 
Horizontal=�6   .+�5"      A� $��10��6   $��10��6*   
���   �65   �� 5#      List box Item 0162   5$      5%      �� 5&      .��5'      �� $ 
Horizontal=�6   .+�5(      A� $��10��6   $��10��6*   
��� � �65   �� 5)      List box Item 0162   5*      5+      5,      �� 5.   
   -   5        $��
lbTodoList��5.      $��Stretch=�6$   $��1��6I   $��10q�6Y   ��5/      �� 50      .R�51      � $	��0,2q�6    52      �� 53      $��* �6/   �� 54      $	��100 �6/   .+�56      �� ��6$   �� *Title+� 57      $��1��6&    � Minimum$ 0Q�66    � Maximum$	 100Q�6B    � Value 6P   �� *
Completion+58      59      5;      ]� 5=   
   $��10q�6   $��1��6    $��1��60   .+�5>      �� $��Right=�6   $
��10,0q�60    � 	Resources 5?       �� 
TargetType	 �� Property
 �� Value��%W   '��       �� 5@      " ��6   .�5A      �� 	 � ��$
 0,0,0,5q�63   5B      5C      .+�5D      �� $
��Bold"�6   $��0,0,0,10q�6.   ListBox selection6S   �� 5E      -   5        $��btnShowSelectedItem��5E      .��6V   Show selected6e   �� 5F      -   5        $��btnSelectLast��5F      .��6J   Select last6W   �� 5G      -   5        $��btnSelectNext��5G      .��6J   Select next6W   �� 5H      -   5        $��btnSelectCSharp��5H      .��6N   	Select C#6Y   �� 5I      -   5        $��btnSelectAll��5I      .��6H   
Select all6T   5J      �� 5K      -   5        $��lbTodoList1��5K      $��Stretch=�6)    �� SelectionMode$ Extended=�6N   ��5L      �� 5M      .R�5N      � $	��0,2q�6    5O      �� 5P   "   $��* �63   �� 5Q   "   $	��100 �63   .+�5S      �� ��6(   �� *Title+� 5T      $��1��6*   $ 0Q�6:   $	 100Q�6F    6T   �� *
Completion+5U      5V      5X      5Y      5\      5]      