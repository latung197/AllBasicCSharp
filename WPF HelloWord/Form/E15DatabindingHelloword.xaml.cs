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
    /// Interaction logic for E15DatabindingHelloword.xaml
    /// </summary>
    public partial class E15DatabindingHelloword : Window
    {
        // Đây là cú pháp sử dụng Databinding: Viết dạng này như kiểu trigger, xử lý ở control này sẽ nhận kết quả ở control khác
        public E15DatabindingHelloword()
        {
            InitializeComponent();
        }
    }
}
