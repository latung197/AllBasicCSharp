using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF_HelloWord.Form
{
    /// <summary>
    /// Interaction logic for E33Datetime_CalendarControl.xaml
    /// </summary>
    public partial class E34Datetime_CalendarControl : Window
    {
        public E34Datetime_CalendarControl()
        {
            InitializeComponent();
            cldSample.SelectedDate = DateTime.Now.AddDays(1);
            cldSample1.BlackoutDates.AddDatesInPast();
            cldSample1.BlackoutDates.Add(new CalendarDateRange(DateTime.Today, DateTime.Today.AddDays(1)));

            dp1.BlackoutDates.AddDatesInPast();
            dp1.BlackoutDates.Add(new CalendarDateRange(DateTime.Now, DateTime.Now.AddDays(7)));
        }
    }
}
