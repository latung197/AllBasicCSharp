   M S B A M L   `   `   `  ����H  DWPF HelloWord, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WPF_HelloWord.FormWPF_HelloWord.Form  5   	   %    WPF_HelloWord.Form.E01Textblock   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:WPF_HelloWord.Form     5   	     � Title$  E01Textblock��5   	   $	��450��6   $	��300��6+   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $��* �6   .+�5   
   �� $��0��6   .+�5      �� $��10q�6   
���  ��This is Textblock�� 6H   This is line tow of textblock6r   �� 5      $��10q�6   $��CharacterEllipsis=�6$   
��� � �rpThis is a TextBlock control with text that my not be rendered comblete, which will be indicated with an ellipsis6�   �� 5      $��10q�6   $
��Wrap=�6$   
����  �VTThis is a TextBlock control with automatically wrapped text, using the text wrapping6�   5      �� 5   
   $��1��6   .+�5      �� $��10q�6   $
��Wrap=�6$   Textblock with �� 5   !   .�6&   Bold6,   , �� 64   .�6;   Italic6C    and B� 6P   .�6Z   	underline6e    text5      �� 5      $��10q�6   $
��Wrap=�6$   This text has a �� 6I   -   5        $��https:www.google.com?�5      .�6�   Link youtobe6�   6�   �� 5      $
��10pxq�6   $
��Wrap=�6&   This �� 5       $
��Bold"�6   .�6.   is62    a�� 6:   
�������
���  ��.�6g   	Textblock6r    with �� 6~   $��Italic$�6�   .�6�   Span6�    elements, �� 6�   
����  �.�6�   .�6�   
Using a �� .�6�   	variety6�    of �� 6�   .�6�   Styles6�   6�   5!      5"      �� 5#   
   -   5        $��stPain��5#   "   $��2��6   .+�5$      �� -   5         ��Name$ txtDemo��5$      5&      5'      5)      5+      