   M S B A M L   `   `   `  ����H  DWPF HelloWord, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WPF_HelloWord.FormWPF_HelloWord.Form  5   	   4    .WPF_HelloWord.Form.E26FlowDocumentScrollViewer   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:WPF_HelloWord.Form     5   	     � Title$!  E26FlowDocumentScrollViewer��5   	   $	��450��6-   $
��1000��6:   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   ,� .��5      /� .T�5      J� $��36(�6   .*�6*   Hello World67   J� 5      $��Italic$�6    �� TextAlignment$
 Left=�6/   $��14(�6D   
�������.*�6d   $"The ultimate programming greeting!6�   5      5      ,� 5   
    ,� IsToolBarVisible$
 True��6#    ,� Zoom$ 80Q�6;   $
��Auto=�6E   $��1��6u   .��5      /� .T�5      J� $��36(�6   .*�6*   Hello, world!69   J� 5      $��Italic$�6   $
 Left=�6/   $��14(�6D   
�������.*�6d   $"The ultimate programming greeting!6�   5      5      �� 5   
   $��2��6   .+�5      ,� $
��Auto=�6'   .��5       /� .T�5!      J� $��Italic$�6    $��14(�63   
�������.*�6S   .*�5#      By setting the �� .�6   IsOptimalParagraphEnabled6:   �� property to true, you will allow WPF to look ahead on the lines to come, before deciding where to break. This will usually result in a more pleasant reading experience. It works especially well in combination with the �� 5'      .�6   IsHyphenationEnabled65   
 property.5(      5)      5*      ,� 5+      $
��Auto=�6'   .��5,      /�   /� IsOptimalParagraphEnabled$
 True��6    /� IsHyphenationEnabled$
 True��6@   .T�5-      J� $��Italic$�6    $��14(�63   
�������.*�6S   .*�5/      By setting the �� .�6   IsOptimalParagraphEnabled6:   �� property to true, you will allow WPF to look ahead on the lines to come, before deciding where to break. This will usually result in a more pleasant reading experience. It works especially well in combination with the �� 53      .�6   IsHyphenationEnabled65   
 property.54      55      56      57      58      59      