   M S B A M L   `   `   `  ����H  DWPF HelloWord, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WPF_HelloWord.FormWPF_HelloWord.Form  5   	   $    WPF_HelloWord.Form.E05CheckBox   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:WPF_HelloWord.Form     5   	     � Title$  E05CheckBox��5   	   $	��500��6   $	��500��6*   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��10q�6   $��0��6!   $��0��61   .+�5      �� .��6   Appliaction Options6)   �� 5      .��6   Enabke Feature ABC6+   �� 5       d� 	IsChecked$
 TrueY�6   .��6(   Enabke Feature XYZ6<   �� 5      .��6   Enabke Feature WWW6+   5      �� 5   
   $��10q�6   $��1��6!   $��0��61   .+�5      �� .��6   Appliaction Options6)   �� 5      .��5      �� Enable Feature �� 6,   
��� � �$
��Bold"�6C   .�6U   ABC6Z   6`   5      �� 5      $
 TrueY�6   .��5      �� Enable Feature �� 6,   
����  �$
��Bold"�6B   .�6T   XYZ6Y   6`   5      �� 5       .��5!      �� Enable Feature �� 6,   
����  �$
��Bold"�6B    �� TextDecorations$ 	Underline{�6T   .�6p   WWW6u   6{   5"      5#      �� 5$   
   $��0��6   $��1��6%   $��10q�62   .+�5%      �� -   5        $��cbAllFreature��5%   +    d� IsThreeState$
 True��6   6�   �� 5&      $��20q�6   .+�5'      �� -   5         ��Name$ cbFreatureItem1��5'      .��6v   Enable feature ABC6�   �� 5(      -   5        $ cbFreatureItem2��5(      .��6v   Enable feature XYZ6�   �� 5)      -   5        $ cbFreatureItem3��5)      .��6v   Enable feature WWW6�   5*      5+      5,      5-      