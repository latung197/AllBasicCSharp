using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
    /// Interaction logic for E03Textbox.xaml
    /// </summary>
    public partial class E03Textbox : Window
    {
        public E03Textbox()
        {
            InitializeComponent();
        }
        // SelectionStart , cho ta vị trí hiện tại của con trỏ hoặc vị trí nơi bắt đầu của vùng chọn.
        // SelectionLength cho phép chúng ta lấy chiều dài của vùng chọn hiện tại nếu có.Nếu không có sẽ trả về 0.
        // SelectedText cho phép chúng ta lấy chuỗi ký tự nằm trong vùng chọn hiện hành.Nếu không có sẽ trả về chuỗi rỗng.
        private void TextBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            txtStatus.Text = "Selection is " + textBox.SelectionStart + Environment.NewLine + "";
            txtStatus.Text += "Selection is " + textBox.SelectionLength + " character(s) long" + Environment.NewLine;
            txtStatus.Text += "Selected text: '" + textBox.SelectedText + "'";
        }
    }
}
