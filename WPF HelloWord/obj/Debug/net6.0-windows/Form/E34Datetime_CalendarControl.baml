   M S B A M L   `   `   `  ����H  DWPF HelloWord, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WPF_HelloWord.FormWPF_HelloWord.Form  5   	   4    .WPF_HelloWord.Form.E34Datetime_CalendarControl   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:WPF_HelloWord.Form     5   	     � Title$!  E34Datetime_CalendarControl��5   	   $	��900��6-   $	��800��6:   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��Center=�6   Lịch67   &   System.Windows.Controls.Calendar  5   
   $��
10,0,10,10q�6   $	��150��6'   $	��120��63   5      �� 5   
   $��1��6   $��Center=�6!   Hiển thị ngày 1/1/20146V   (� 5   
   $��1��6   $��10q�6   .��5           DisplayDate$ 
01.01.2014��6   5      �� 5   
   $��2��6   $��Center=�6!    Hiển thị vừa với khung6V   (� 5    
    (� Stretch$
 Fill=�6    (� StretchDirection$ UpOnly=�6!   $��2��6;   $��10q�6H   .��5!        5"      �� 5$   
   $��0��6   $��1��6!   $��Center=�61   Cho phép chọn một ngày6f   (� 5%   
   $��10q�6   $��0��6   $��1��6+   .��5&           SelectionMode$ SingleRange=�6   5'      �� 5)   
   $��1��6   $��1��6!   $��Center=�61    Cho phép chọn nhiều ngày6h   (� 5*   
   $��10q�6   $��1��6   $��1��6+   .��5+        $ MultipleRange=�6   5,      �� 5.   
   $��10q�6   $��3��6!   .+�5/        -   5        $��	cldSample��5/      $ MultipleRange=�6(      SelectedDate 
10.10.20136F   $	��140��6`   �� 50      .��6   Selected date:6$   �� 51      ��6   ��  �� ElementName$ 	cldSample��	 �� Path$	 SelectedDate�
 �� StringFormat$
 d�� �� UpdateSourceTrigger$ PropertyChanged=�52      �� 53   
   $��2��6   $��1��6!   $��Center=�61   Bôi đen để chọn6_   �� 54   
   $��10q�6   $��2��6!   $��1��6.   .+�55        -   5        $��
cldSample1��55      $ MultipleRange=�6)   $	��100��6G      BlackoutDates 56      /  )System.Windows.Controls.CalendarDateRange  57         Start$ 
10.13.2013��6(   
   End$ 
10.19.2013��6;     58      $ 
10.27.2013��6(   $ 
10.31.2013��6;   5:      �� 5;      .��6   Selected dates:6%   �� 5<      $	��150��6Y   ��6   �� $ 
cldSample1��$	 SelectedDates�6Y   5=      �� 5?   
   $��3��6   $��1��6"   $��Center=�62   Hiện thị Năm6]   (� 5@   
   $��3��6   $��1��6   .��5A           DisplayMode$ Decade=�6   5B      �� 5D   
   $��0��6   $��2��6"   $��Center=�62   Hiện thị Tháng6_   (� 5E   
   $��0��6   $��2��6   .��5F        $
 Year=�6   5G      �� 5I   
   $��10q�6   $��1��6!   $��2��6.   .+�5J      �� .��6   Name: DateTime Picker6+   �� 5K      �� 5L      .��6   	Birthday:6   (  "System.Windows.Controls.DatePicker  5M      6   �� 5N      .��6   	Gender:6   �� 5O      .@�5P      �� .��6   Female6'   �� 5Q      .��6   Male6%   5R      �� 5S      $��20q�6   .��6!   Signup6)   5T        5V   
   $��2��6   $��2��6"      SelectedDate 
2000-12-3162      SelectedDateFormat$
 Long=�6L   $��10q�6f   6t     5X   
   -   5        $	��dp1��5X   2   $��3��6   $��2��6"   $��10q�6=      BlackoutDates 5Y        5Z      $ 
2019-04-01��6$   $ 
2019-04-07��67     5[      $ 
2019-04-22��6$   $ 
2019-04-28��67   5]      5^      5_      