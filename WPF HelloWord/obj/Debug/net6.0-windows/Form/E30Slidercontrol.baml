   M S B A M L   `   `   `  ����  WPF HelloWord)    #WPF_HelloWord.Form.E30Slidercontrol   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  E30Slidercontrol��5   	   $	��450��6"   $	��800��6/   .��5      �  � ColumnDefinitions 5	   
   �� 5
      $��* �6   �� 5      $��* �6   .+�5   
   �� $��Center=�6   $��10q�60   $��0��6<   .+�5      ��  � Maximum$	 100Q�6    �� TickPlacement$
 Both=�6#    �� TickFrequency$ 5Q�68   $��
10,10,0,10q�6J   �� 5      $	 100Q�6   $ BottomRight=�6#   $ 10Q�6?    �� IsSnapToTickEnabled$
 True��6R   ]� 5      $��Center=�6   $��10q�63   .+�5      �� $��Right=�6p    �� TextAlignment$ Right=�6�   $��40��6�   ��6   ��  �� ElementName$ slValue�� �� Path$ Value�	 �� UpdateSourceTrigger$	 PropertyChanged=�6�   �� 5      -   5        $��slValue��5   p   $	 255Q�6   $ BottomRight=�6'   $ 5Q�6C   $
 True��6U   6p   5      5      �� 5   
   $��10q�6   $��Center=�6!   $��1��6<   .+�5      ]� $��Center=�6   $��10q�63   .+�5      �� $
��Left=�6   $
��Bold"�6.   .��6@   R:6D   �� 5      $��Right=�6q   $ Right=�6�   $��40��6�   ��6   �� $ slColorR��$ Value�$	 PropertyChanged=�6�   �� 5      -   5        $��slColorR��5   p   $	 255Q�6   $ BottomRight=�6'   $ 5Q�6C   $
 True��6U   6�   5      ]� 5      $��Center=�6   $��10q�63   .+�5       �� $
��Left=�6   $
��Bold"�6.   .��6@   G:6D   �� 5!      $��Right=�6q   $ Right=�6�   $��40��6�   ��6   �� $ slColorG��$ Value�$	 PropertyChanged=�6�   �� 5"      -   5        $��slColorG��5"   p   $	 255Q�6   $ BottomRight=�6'   $ 5Q�6C   $
 True��6U   6�   5#      ]� 5%      $��Center=�6   $��10q�63   .+�5&      �� $
��Left=�6   $
��Bold"�6.   .��6@   B:6D   �� 5'      $��Right=�6q   $ Right=�6�   $��40��6�   ��6   �� $ slColorB��$ Value�$	 PropertyChanged=�6�   �� 5(      -   5        $��slColorB��5(   p   $	 255Q�6   $ BottomRight=�6'   $ 5Q�6C   $
 True��6U   6�   5)      5*      5,      5-      