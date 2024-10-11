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

        private void btnLable_Click(object sender, RoutedEventArgs e)
        {
            E02Lable lable = new E02Lable();
            lable.ShowDialog();
        }

        private void btnTextBox_Click(object sender, RoutedEventArgs e)
        {
            E03Textbox textbox = new E03Textbox();
            textbox.ShowDialog();
        }

        private void btnButton_Click(object sender, RoutedEventArgs e)
        {
            E04Button button = new E04Button();
            button.ShowDialog();
        }

        private void btnCheckBox_Click(object sender, RoutedEventArgs e)
        {
            E05CheckBox checkbox = new E05CheckBox();
            checkbox.ShowDialog();
        }

        private void btnRadiobutton_Click(object sender, RoutedEventArgs e)
        {
            E06Radiobutton e06Radiobutton = new E06Radiobutton();
            e06Radiobutton.ShowDialog();
        }

        private void btnPassWord_Click(object sender, RoutedEventArgs e)
        {
            E07PassWord passWord = new E07PassWord();
            passWord.ShowDialog();
        }

        private void btnImage_Click(object sender, RoutedEventArgs e)
        {
            E08Image image = new E08Image();
            image.ShowDialog();
        }

        private void btnToolTips_Click(object sender, RoutedEventArgs e)
        {
            E09ToolTips toolTips = new E09ToolTips();
            toolTips.ShowDialog();
        }

        private void btnTextRendering_Click(object sender, RoutedEventArgs e)
        {
            E10TextRendering textRendering = new E10TextRendering();
            textRendering.ShowDialog();
        }

        private void btnTabOrder_Click(object sender, RoutedEventArgs e)
        {
            E11TabOrder tabOrder = new E11TabOrder();
            tabOrder.ShowDialog();
        }

        private void btnAccessKey_Click(object sender, RoutedEventArgs e)
        {
            E12Access_Keys key = new E12Access_Keys();
            key.ShowDialog();
        }

        private void btnPanel_Click(object sender, RoutedEventArgs e)
        {
            E13Panels e13Panels = new E13Panels();
            e13Panels.ShowDialog();
        }

        private void btnDatabinding_Click(object sender, RoutedEventArgs e)
        {
            E15Databinding e15Databinding = new E15Databinding();
            e15Databinding.ShowDialog();
        }

        private void btnDatabindingReponding_Click(object sender, RoutedEventArgs e)
        {
            E16RespondingToChanges e16RespondingToChanges = new E16RespondingToChanges();
            e16RespondingToChanges.ShowDialog();
        }

        private void btnStringFormat_Click(object sender, RoutedEventArgs e)
        {
            E17StringFormatProperty e17StringFormatProperty = new E17StringFormatProperty();
            e17StringFormatProperty.ShowDialog();
        }

        private void btnWPFcommands_Click(object sender, RoutedEventArgs e)
        {
            E19WPFcommands e19WPFcommands = new E19WPFcommands();
            e19WPFcommands.ShowDialog();
        }

        private void btnMessageBox_Click(object sender, RoutedEventArgs e)
        {
            E20MessageBox e20MessageBox = new E20MessageBox();
            e20MessageBox.ShowDialog();
        }

        private void btnOpenFileDialog_Click(object sender, RoutedEventArgs e)
        {
            E21OpenFileDialog e21OpenFileDialog = new E21OpenFileDialog("12","3112");
            e21OpenFileDialog.ShowDialog(); 
        }

        private void btnMenuControl_Click(object sender, RoutedEventArgs e)
        {
            E22MenuControl E22MenuControl = new E22MenuControl();
            E22MenuControl.ShowDialog();
        }

        private void btnContextMenu_Click(object sender, RoutedEventArgs e)
        {
            E23ContextMenu e23ContextMenu = new E23ContextMenu();
            e23ContextMenu.ShowDialog();
        }

        private void btnToolBarcontrol_Click(object sender, RoutedEventArgs e)
        {
            E24ToolBarcontrol e24ToolBarcontrol = new E24ToolBarcontrol();
            e24ToolBarcontrol.ShowDialog();
        }

        private void btnStatusBarcontrol_Click(object sender, RoutedEventArgs e)
        {
            E25StatusBarcontrol e25StatusBarcontrol = new E25StatusBarcontrol();
            e25StatusBarcontrol.ShowDialog();
        }

        private void btnFlowDocumentScrollViewercontrol_Click(object sender, RoutedEventArgs e)
        {
            E26FlowDocumentScrollViewer e26FlowDocumentScrollViewer = new E26FlowDocumentScrollViewer();
            e26FlowDocumentScrollViewer.ShowDialog();
        }

        private void btnFlowDocumentPageViewer_Click(object sender, RoutedEventArgs e)
        {
            E27FlowDocumentPageViewerControl e27FlowDocumentPageViewerControl = new E27FlowDocumentPageViewerControl();
            e27FlowDocumentPageViewerControl.ShowDialog();
        }

        private void btnBordercontrol_Click(object sender, RoutedEventArgs e)
        {
            E29BorderControl e29BorderControl = new E29BorderControl();
            e29BorderControl.ShowDialog();
        }

        private void btnSlidercontrol_Click(object sender, RoutedEventArgs e)
        {
            E30Slidercontrol e30Slidercontrol = new E30Slidercontrol();
            e30Slidercontrol.ShowDialog();
        }

        private void btnProgressBar_Click(object sender, RoutedEventArgs e)
        {
            E31ProgressBarcontrol e31ProgressBarcontrol = new E31ProgressBarcontrol();
            e31ProgressBarcontrol.ShowDialog();
        }

        private void btnWebBrowsercontrol_Click(object sender, RoutedEventArgs e)
        {
            E32WebBrowerControl e32WebBrowerControl = new E32WebBrowerControl();
            e32WebBrowerControl.ShowDialog();
        }

        private void btnGroupBoxcontrol_Click(object sender, RoutedEventArgs e)
        {
            E33GroupboxControl e33GroupboxControl  = new E33GroupboxControl();
            e33GroupboxControl.ShowDialog();
        }

        private void btnDateTime_Calendar_Click(object sender, RoutedEventArgs e)
        {
            E34Datetime_CalendarControl e34Datetime_CalendarControl = new E34Datetime_CalendarControl();
            e34Datetime_CalendarControl.ShowDialog();
        }

        private void btnExpander_Click(object sender, RoutedEventArgs e)
        {
            E35Expandercontrol e35Expandercontrol = new E35Expandercontrol();
            e35Expandercontrol.ShowDialog();    
        }

        private void btnTabcontrol_Click(object sender, RoutedEventArgs e)
        {
            E36TabControl e36TabControl = new E36TabControl();
            e36TabControl.ShowDialog();
        }

        private void btnItemsControl_Click(object sender, RoutedEventArgs e)
        {
            E37ItemsControl e37ItemsControl = new E37ItemsControl();
            e37ItemsControl.ShowDialog();
        }

        private void btnListBox_Click(object sender, RoutedEventArgs e)
        {
            E39ListBoxControl e39ListBoxControl = new E39ListBoxControl();
            e39ListBoxControl.ShowDialog();
        }

        private void btnCombobox_Click(object sender, RoutedEventArgs e)
        {
            E38ComboBox e38ComboBox = new E38ComboBox();
            e38ComboBox.ShowDialog();
        }

        private void btnListView_Click(object sender, RoutedEventArgs e)
        {
            E40ListView e40ListView = new E40ListView();
            e40ListView.ShowDialog();
        }

        private void btnTreeView_Click(object sender, RoutedEventArgs e)
        {
            E41TreeView e41TreeView = new E41TreeView();
            e41TreeView.ShowDialog();
        }

        private void btnDataGrid_Click(object sender, RoutedEventArgs e)
        {
            E42DataGrid e42DataGrid = new E42DataGrid();
            e42DataGrid.ShowDialog();
        }

        private void btnTrigger_Click(object sender, RoutedEventArgs e)
        {
            E44TriggerAndEventTrigger e44TriggerAndEventTrigger = new E44TriggerAndEventTrigger();
            e44TriggerAndEventTrigger.ShowDialog();
        }
    }
}