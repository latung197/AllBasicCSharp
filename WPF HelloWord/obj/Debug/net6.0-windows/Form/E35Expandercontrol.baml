   M S B A M L   `   `   `  ����H  DWPF HelloWord, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WPF_HelloWord.FormWPF_HelloWord.Form  5   	   +    %WPF_HelloWord.Form.E35Expandercontrol   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:WPF_HelloWord.Form     5   	     � Title$  E35Expandercontrol��5   	   $	��450��6$   $	��800��61   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6    �� 5      $��* �6    �� 5      $��* �6     � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   9� $
{�True��6   .��5      �� $
��Wrap=�6   $��16(�6,   ;9Xin chào Đây là nội dung Hướng dẫn sử dụng5      5      9� 5   
   $��1��6   $��10q�6#   .��5      �� $��5q�6   .+�5      ]� .+�5      �� $9��3/WpfTutorialSamples;component/Images/question32.png��6   $��32��6Y   $��32��6d   $��Right=�6p   $��10q�6�   6�   �� 5      $
��Wrap=�6    $��10(�64   kiDid you know that WPF is really awesome? Just enter your e-mail address below and we'll send you updates:5!      5"      �� 5#      $��5q�6   .��6%   john@doe.org63   5$      5%      9� 5'   
   $��2��6   $��10q�6#    9� ExpandDirection$ Right=�6/   .��5(      �� $
��Wrap=�6   $��18(�6,   kiHere we can have text which can be hidden/shown using the built-in functionality of the Expander control.5*      5+      9� 5-   
   $��10q�6   $��1��6   ��5.      ]� 5/      $��Stretch=�6   .+�50      �� $;��5/WpfTutorialSamples;component/Images/bullet_green.png��6   $��16��6[   $
��Left=�6g   �� 51      $��Italic$�6    
��� � �Click to show/hide content...6e   52      .��54      �� $
��Wrap=�6   $��18(�6,   kiHere we can have text which can be hidden/shown using the built-in functionality of the Expander control.56      57      58      5;      