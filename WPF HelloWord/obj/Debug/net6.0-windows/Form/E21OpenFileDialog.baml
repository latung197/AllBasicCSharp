   M S B A M L   `   `   `  ����H  DWPF HelloWord, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WPF_HelloWord.FormWPF_HelloWord.Form  5   	   *    $WPF_HelloWord.Form.E21OpenFileDialog   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:WPF_HelloWord.Form     5   	   -   5          � Title$  E21OpenFileDialog��5   	   $	��450��6#   $	��800��60   .��5
      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   ]� $��10q�6   .+�5      � $��Center=�6   $	��Top=�65   $��0,0,0,10q�6J   .+�5      �� -   5         ��Name$ btnOpenFile��5      .��6H   	Opne File6S   5      �� 5      -   5         ��Name$ 	txtEditor��5      5      ]� 5   
   $��10q�6   $��1��6    .+�5      � $��Center=�6   $	��Top=�65   $��0,0,0,10q�6J   .+�5      �� -   5        $��btnOpen��5      .��6>   
Open files6J   5      �� 5      -   5        $��lbFiles��5      5      ]� 5    
   $��10q�6   $��1��6    .+�5!      � $��Center=�6   $	��Top=�65   $��0,0,0,10q�6J   .+�5"      �� -   5        $��btnSaveFile��5"      .��6F   	Save File6Q   5#      �� 5$      -   5        $��txtEditSaveFile��5$       �� TextWrapping$
 Wrap=�6-    �� AcceptsReturn$
 True��6A   $
��Auto=�6V   5%      � 5&   
   $��15q�6   $��1��6   $��1��6+    5'      �� 5(      $
��Auto �6#   �� 5)      $��* �6#    5+      �� 5,      $
��Auto �6    �� 5-      $
��Auto �6    �� 5.      $
��Auto �6    .+�51      �� $��/Img/schedule.png��6   $��32��6/   $��32��6:   $��2��6F   $
��20,0q�6W   �� 53      -   5        $��lblQuestion��53      $��1��6'   .��67   	Question:6B   �� 54      -	   5        $��	txtAnswer��54      $��1��6'   $��1��67   $	��250��6D   .��6S   Answer6[   � 56      $��2��6   $��2��6%   $��Right=�69   $��0,15,0,0q�6U   .+�57      �� -
   5        $��btnDialogOk��57   *    �� 	IsDefault$
 True��6   $��60��6W   $��0,0,10,0q�6e   .��6w   _Ok6|   �� 58       �� IsCancel$
 True��6   $��60��6)   .��67   	_Cancel6@   59      5:      5;      5<      