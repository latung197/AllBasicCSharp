   M S B A M L   `   `   `  ����H  DWPF HelloWord, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WPF_HelloWord.FormWPF_HelloWord.Form  5   	   *    $WPF_HelloWord.Form.E24ToolBarcontrol   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:WPF_HelloWord.Form     5   	     � Title$  E24ToolBarcontrol��5   	   $	��450��6#   $
��1000��60    J� CommandBindings 5	      )  #System.Windows.Input.CommandBinding  5
   
   -   5           Command$	 New��5
      6'     5   
   -   5        $
 Open��5      6(     5   
   -   5        $
 Save��5      6(   .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   ]� $��0��6   $��10q�6$   .+�5      `� $	��Top=�6   .�5      c� .@�5      �� $	��New��6   $	��New��6+   �� 5      $
��Open��6   $
��Open��6,   �� 5      $
��Save��6   $
��Save��6,   5      c� 5      .@�5      �� $	��Cut��6   $	��Cut��6+   �� 5      $
��Copy��6   $
��Copy��6,   �� 5      $��Paste��6   $��Paste��6-   5       5!      �� 5"       �� AcceptsReturn$
 True��6   6-   5#      ]� 5$   
   $��1��6   $��10q�6$   .+�5%      `� $	��Top=�6   .�5&      c� .@�5'      �� $	��Cut��6    � ToolTip$) #Cut selection to Windows Clipboard.��6+   .��5(      �� $2��,/WpfTutorialSamples;component/Images/cut.png��6    5)      �� 5*      $
��Copy��6   $* $Copy selection to Windows Clipboard.��6,   .��5+      �� $3��-/WpfTutorialSamples;component/Images/copy.png��6    5,      �� 5-      $��Paste��6   $# Paste from Windows Clipboard.��6-   .��5.      ��  �� Orientation$ 
Horizontal=�6%   .+�5/      �� $4��./WpfTutorialSamples;component/Images/paste.png��6$   �� 50      $��3,0,0,0q�6(   Paste6@   51      52      53      54      �� 55      $
 True��6   $��Img Icon��6+   56      ]� 58   
   $��2��6   $��10q�6$   .+�59      `� $	��Top=�6   .�5:      c� .@�5;      �� $	��Cut��6   $) #Cut selection to Windows Clipboard.��6+   .��5<      �� $2��,/WpfTutorialSamples;component/Images/cut.png��6    5=      �� 5>      $
��Copy��6   $* $Copy selection to Windows Clipboard.��6,   .��5?      �� $3��-/WpfTutorialSamples;component/Images/copy.png��6    5@      �� 5A      $��Paste��6   $# Paste from Windows Clipboard.��6-   .��5B      �� $ 
Horizontal=�6%   .+�5C      �� $4��./WpfTutorialSamples;component/Images/paste.png��6$   �� 5D      $��3,0,0,0q�6(   Paste6@   5E      5F      5G      5H      `� 5I      $��Right=�6    `� Orientation$ Vertical=�61   .�5J      c� .@�5K      �� $	��Cut��6   $) #Cut selection to Windows Clipboard.��6+   .��5L      �� $2��,/WpfTutorialSamples;component/Images/cut.png��6    5M      �� 5N      $
��Copy��6   $* $Copy selection to Windows Clipboard.��6,   .��5O      �� $3��-/WpfTutorialSamples;component/Images/copy.png��6    5P      �� 5Q      $��Paste��6   $# Paste from Windows Clipboard.��6-   .��5R      �� $4��./WpfTutorialSamples;component/Images/paste.png��6    5S      5T      5U      �� 5V      $
 True��6   $��Toolbar mở rộng��6+   5W      ]� 5Y   
   $��3��6   $��10q�6$   .+�5Z      `� $	��Top=�6   .�5[      c� .@�5\      �� $	��Cut��6   $) #Cut selection to Windows Clipboard.��6+   .��5]      �� $2��,/WpfTutorialSamples;component/Images/cut.png��6    5^      �� 5_      $
��Copy��6   $* $Copy selection to Windows Clipboard.��6,   .��5`      �� $3��-/WpfTutorialSamples;component/Images/copy.png��6    5a      �� 5b      $��Paste��6   $# Paste from Windows Clipboard.��6-   .��5c      �� $ 
Horizontal=�6%   .+�5d      �� $4��./WpfTutorialSamples;component/Images/paste.png��6$   �� 5e      $��3,0,0,0q�6(   Paste6@   5f      5g      �� 5h      �� 5i      .��6   
Font size:6(   �� 5j      .@�5k      �� .��6'   106+   �� 5l       �� 
IsSelected$
 True��6'   .��69   126=   �� 5m      .��6'   146+   �� 5n      .��6'   166+   5o      5p      5q      �� 5r      $
 True��6   5s      5t      5u      