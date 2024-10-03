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
    /// Interaction logic for E13Panels.xaml
    /// </summary>
    public partial class E13Panels : Window
    {
        // Canvan : Một pain đơn giản bắt chước các làm của WinForms. Nó cho phép gắn tọa độ cụ thể cho từng child control, cho bạn toàn quyền điều khiển layout. Panel này không linh hoạt lắm vì phải tự di chuyển các control xung quanh và đảm bảo rằng chúng căn chỉnh theo cách mông muốn. Sử dụng khi chỉ định hoàn toàn vị trí các control.

        // WrapPanel: Sẽ định vị từng child control của nó bên cạnh nhau theo chiều ngang (Mặc định ) hoặc theo chiều dọc cho đến khi không còn chỗ nó sẽ chuyển đến dòng tiếp theo và tiếp tục sử dụng. Sử dụng khi muốn làm list các control ngang hoặc dọc tự động Wrap khi không còn chỗ.

        // StackPanel: Hoạt động giống như WrapPanel nhưng thay vì đến dòng tiếp theo nhếu child control chiến quá nhiều chỗ thì mới xuống dòng thì nó sẽ tự mở rộng nếu có thể. Giống như Wrappanel cũng có thể chọn hướng ngang hoặc dọc nhưng thay vì điều chỉnh chiều rộng hoặc cao của các control con thì mỗi control sẽ tự kieos dài để chiếm toàn bộ chiều rộng hoặc chiều cao. Sử dụng nó khi muốn làm một list control chiếm hết diện tích có sẵn.
        // DockPanel : DockPanel cho phép bạn gắn các child control lên trên cùng, dưới cùng, bên trái hoặc bên phải. Theo mặc định,control cuối cùng, nếu không được cung cấp vị trí dock cụ thể, sẽ lấp đầy khoảng trống còn lại. Bạn có thể đạt được điều tương tự với bảng Grid, nhưng đối với các tình huống đơn giản hơn, DockPanel sẽ dễ sử dụng hơn. Sử dụng DockPanel bất cứ khi nào bạn cần gắn một hoặc một số control vào một trong các bên, như để chia cửa sổ thành các khu vực cụ thể

        // UniformGrid: UniformGrid giống như Grid, với khả năng có nhiều hàng và cột, nhưng có một điểm khác biệt quan trọng: Tất cả các hàng và cột sẽ có cùng kích thước! Sử dụng điều này khi bạn cần grid mà không cần chỉ định các kích thước khác nhau cho các hàng và cột.
        public E13Panels()
        {
            InitializeComponent();
        }
    }
}
