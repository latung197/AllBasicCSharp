   M S B A M L   `   `   `  ����H  DWPF HelloWord, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WPF_HelloWord.FormWPF_HelloWord.Form  5   	   '    !WPF_HelloWord.Form.E22MenuControl   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:WPF_HelloWord.Form     5   	     � Title$  E22MenuControl��5   	   $	��450��6    $	��800��6-    J� CommandBindings 5	      )  #System.Windows.Input.CommandBinding  5
   
   -   5           Command$	 New��5
      6N   .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   ]� $��10q�6   .+�5      o� $	��Top=�6   .@�5      m� $
��File��6   .@�5      m� -   5        $
��_New��5   #   61   m� 5      $��_Opne��6#   m� 5      $��_Save��6#   �� 5      m� 5      $��_Exit��6#   5      5      �� 5       �� AcceptsReturn$
 True��6   $��Menu Control��6/   5      ]� 5   
   $��1��6   $��10q�6$   .+�5       o� $	��Top=�6   .@�5!      m� $��_File��6   .@�5"      m� $��_Exit��6   5#      m� 5$      $��Tools��6   .@�5%      m� $��_Manage Users��6    m� Icon 5&      �� 5'      $��/Img/schedule.png��6$   5)      m� 5*      $��Show groups��6    m� IsCheckable$
 True��64    m� 	IsChecked$
 True��6G   5+      5,      �� 5-      $
 True��6   .��6+   Icon Menucontrol6=   5.      ]� 50   
   $��10q�6   $��2��6    .+�51      o� $	��Top=�6   .@�52      m� $��_File��6   .@�53      m�  m� Command$	 New��6   �� 54      m� 55      $��_Exit��6   56      m� 57      $��_Edit��6   .@�58      m� $	 Cut��6   m� 59      $
 Copy��6   m� 5:      $ Paste��6   5;      5<      �� 5>      -   5        $��	txtEditor��5>   +   $
 True��6   $%��Keyboard shortcuts and Commands��6<   5?      5@      5B      