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
    /// Interaction logic for E15DatabindingUsingDatacontext.xaml
    /// </summary>
    public partial class E15DatabindingUsingDatacontext : Window
    {
        // Thay đổi giá trị kích thước của form khi nhập liệu vào ô text.
        public E15DatabindingUsingDatacontext()
        {
            InitializeComponent();
            this.DataContext = this;// Ở đây dùng this là tác động trực tiếp vào cửa form hiện tại.
        }
    }
}
