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
    /// Interaction logic for E12Access_Keys.xaml
    /// </summary>
    public partial class E12Access_Keys : Window
    {
        // Là thực hiện gán phím tắt. Ở đây phím tắt chỉ định là trữ cái đầu tiên sau dấu _ conten của control. VD control button có conten = "_Save" => S là Access key và khi bấm ALT chữ S sẽ hiện gạch chân
        public E12Access_Keys()
        {
            InitializeComponent();
        }
    }
}
