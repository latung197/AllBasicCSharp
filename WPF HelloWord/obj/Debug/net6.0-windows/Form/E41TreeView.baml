   M S B A M L   `   `   `  ����H  DWPF HelloWord, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WPF_HelloWord.FormWPF_HelloWord.Form  5   	   7 clr-namespace:WPF_HelloWord.FormWPF_HelloWord.Form  5   	   $    WPF_HelloWord.Form.E41TreeView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1self clr-namespace:WPF_HelloWord.Form     5   	   2local clr-namespace:WPF_HelloWord.Form     5   	     � Title$  E41TreeView��5	   	   $	��450��6   $	��800��6*   .��5
      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   R� $��5q�6   .@�5      Q� $��Level 1��6    Q� 
IsExpanded$
 True��6,   .@�5      Q� $��	Level 2.1��6   Q� 5      $��	Level 2.2��6   $
 True��62   .@�5      Q� $��	Level 3.1��6#   Q� 5      $��	Level 3.2��6#   5      Q� 5      $��	Level 2.3��6   5      5      R� 5    
   $��1��6   $��5q�6    .@�5!      Q� $
 True��6   ��5"      �� 5#       �� Orientation$ 
Horizontal=�6!   .+�5$      A� $��10��6"   $��10��6.   
����  �69   �� 5%      $��Level 1 (Blue)��6$   5&      .@�5(      Q� ��5)      �� 5*      $ 
Horizontal=�6%   .+�5+      �� $��	Level 2.1��6(   
����  �69   5,      5.      Q� 5/      $
 True��6   ��50      �� 51      $ 
Horizontal=�6%   .+�52      A� $��10��6&   $��10��62   
��� � �6=   �� 53      $��Level 2.2 (Green)��6(   
����  �6A   54      .@�56      Q� ��57      �� 58      $��	Level 3.1��6(   
��� � �69   5:      Q� 5;      ��5<      �� 5=      $��	Level 3.2��6(   
��� � �69   5?      5@      Q� 5A      ��5B      �� 5C      $��	Level 2.3��6$   
����  �65   5E      5F      5G      �� 5I   
   $��1��6   $��5q�6%   .+�5J      �� $��Center=�6   .��61   TreeView Databinding6G   R� 5K      -   5        $��trvMenu��5K      5O      5P      ]� 5R   
   $��10q�6   $��2��6    .+�5S      � $��0,10,0,0q�6   $��Bottom=�6*   $��Center=�6B   .+�5T      �� -   5        $��btnSelectNext��5T      $	��120��6J   .��6V   Select next6c   �� 5U      -   5        $��btnToggleExpansion��5U      $	��120��6T   $��10,0,0,0q�6`   .��6r   Toggle expansion6�   5V      R� 5X      -   5        $��
trvPersons��5X      ��5Y      �� 5Z       �� ItemsSource 6/   �� *
Children+.R�5[      �� $ 
Horizontal=�6%   .+�5\      A� $��10��6&   $��10��62   
���  ��6=   �� 5]      $��0,0,4,0q�6>   ��6(   �� *Name+6>   5^      5_      ��5a      �� 5b       �� 
TargetType" Q�6   .�5c      ��  �� Property �@Q�
IsSelected �� Value 67   �� *
IsSelected+�� 5d       �@Q�
IsExpanded 67   �� *
IsExpanded+5e      5g      5h      �� 5j   
   $��1��6   $��1��6"   $��5q�62   .+�5k      �� $��Center=�6   Load treeView6D   R� 5l      -   5        $��trvStructure��5l      $��10q�6Y   5m      5o      5p      