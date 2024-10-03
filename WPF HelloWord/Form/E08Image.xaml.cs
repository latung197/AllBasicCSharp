using Microsoft.Win32;
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
    /// Interaction logic for E08Image.xaml
    /// </summary>
    public partial class E08Image : Window
    {
        public E08Image()
        {
            InitializeComponent();
        }

        /*
         * Uniform: Đây là chế độ mặc định. Hình ảnh sẽ được căn chỉnh để nó vừa với cái Size của control Image. Tỉ lệ của hình ảnh (dài : rộng) vẫn được đảm bảo giữ nguyên để hình đạt chất lượng tốt nhất. Xem thêm tại đây.
UniformToFill: Hình ảnh sẽ được full đầy nguyên Control mà vẫn giữ nguyên tỉ lệ Dài : Rộng để đảm bảo chất lượng hình ảnh nên có thể không nhìn thấy hết hình (Nói chung là miêu tả hơi khó, các bạn xem ở hình trên).
Fill: Hình ảnh có thể sẽ bị biến dạng vì nó sẽ dãn ra và thu nhỏ lại theo thông số Dài : Rộng của control Image. Nó giúp bạn xem được toàn bộ hình và full control, nhưng đổi lại hình hơi khó coi (Xem hình trên).
None: Nếu hình ảnh nhỏ hơn kích thước của control Image, thì không có gì xảy ra với hình ảnh cả, hình ảnh vẫn hiển thị bình thường. Nhưng nếu nó lớn hơn, hình ảnh sẽ bị cắt đi một phần, chỉ có phần còn lại được hiển thị.
         */

        private void btnLoadFromFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog()==true)
            {
                Uri uri = new Uri(ofd.FileName);
                imgDynamic.Source=new BitmapImage(uri);
            }
        }

        private void btnLoadFromResource_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("", UriKind.Relative);
            imgDynamic.Source = new BitmapImage(uri);
        }
    }
}
