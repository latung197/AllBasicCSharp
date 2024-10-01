using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_HelloWord.Form;

namespace WPF_HelloWord
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private string buttonname;

        public string Buttonname
        {
            get
            {
                return buttonname;
            }
            set
            {
                buttonname = value;
                OnPropertyChanged("Buttonname");

            }
        }

        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            Buttonname = "Dữ liệu từ code behind";

            winDown.ResizeMode = ResizeMode.NoResize;// Set có cho phép người dùng thay đổi kích thước cửa sổ hay không
            winDown.ShowInTaskbar = false; // Set có hiển thị icon ở thanh taskbar phía dưới hay không
            winDown.SizeToContent = SizeToContent.Manual; // Tự động thay đổi kích thước của form theo kích thước của các control bên trong hay không. Manual : Không / Width/Height/ WidthandHeight: Điều chỉnh ngang/Dọc/Cả ngang và dọc
            winDown.Topmost = false; // Set vị trí cửa sổ mặc định hiển thị phía trên đè lên các cửa sổ khác
            winDown.WindowState = WindowState.Normal;// Set kích thước ban đầu khi mở cửa sổ. Normal/ Minimized/ Maximized

            // trong file App.xaml thuốc tính StarupUri: Xác nhận cửa sổ nó được mở đầu tiên khi chạy trương trình



        } 

        public event PropertyChangedEventHandler? PropertyChanged;


        private void btnResource_Click(object sender, RoutedEventArgs e)
        {
            Resource resource = new Resource();
            resource.ShowDialog();
        }

        private void btnUICulture_Click(object sender, RoutedEventArgs e)
        {
            UICulture uICulture = new UICulture();
            uICulture.ShowDialog();
        }

        private void btnTextBlock_Click(object sender, RoutedEventArgs e)
        {
            E01Textblock textBlock = new E01Textblock();    
            textBlock.ShowDialog();
        }
    }
}