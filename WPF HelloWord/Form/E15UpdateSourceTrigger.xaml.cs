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
    /// Interaction logic for E15UpdateSourceTrigger.xaml
    /// </summary>
    public partial class E15UpdateSourceTrigger : Window
    {

        // Thuộc tính UpdateSourceTrigger của một ràng buộc kiểm soát cách thức và thời điểm giá trị đã thay đổi được gửi trở lại nguồn. Tuy nhiên, vì WPF khá giỏi trong việc kiểm soát điều này cho bạn, nên giá trị mặc định sẽ đủ cho hầu hết các trường hợp, khi đó bạn sẽ có được sự kết hợp tốt nhất giữa giao diện người dùng được cập nhật liên tục và hiệu suất tốt.
        public E15UpdateSourceTrigger()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void btnUpdateSource_Click(object sender, RoutedEventArgs e)
        {
            BindingExpression binding = txtWindowTitle.GetBindingExpression(TextBox.TextProperty);
            binding.UpdateSource();
        }
    }
}
