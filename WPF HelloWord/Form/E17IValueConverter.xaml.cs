using System;
using System.Collections.Generic;
using System.Globalization;
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
    /// Interaction logic for E17IValueConverter.xaml
    /// </summary>
    public partial class E17IValueConverter : Window
    {
        /*
         * Bạn có một giá trị số nhưng bạn muốn hiển thị giá trị bằng không theo một cách và số dương theo một cách khác
         * Bạn muốn kiểm tra một CheckBox dựa trên một giá trị, nhưng giá trị là một chuỗi như "có" hoặc "không" thay vì một giá trị Boolean
         * Bạn có kích thước tệp tính bằng byte nhưng bạn muốn hiển thị nó dưới dạng byte, kilobyte, megabyte hoặc gigabyte dựa trên kích thước của nó       
         */
        public E17IValueConverter()
        {
            InitializeComponent();
        }

        public class YesNoToBooleanConverter : IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            {
                switch (value.ToString().ToLower())
                {
                    case "yes":
                    case "oui":
                        return true;
                    case "no":
                    case "non":
                        return false;
                }
                return false;
            }

            public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            {
                if(value is bool)
                {
                    if((bool)value == true)
                    {
                        return "yes";
                    }
                    else
                    {
                        return "no";
                    }
                }
                return "no";
            }
        }
    }
}
