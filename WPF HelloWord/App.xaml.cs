using System.Configuration;
using System.Data;
using System.Windows;

namespace WPF_HelloWord
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            MainWindow window = new MainWindow();
            if (e.Args.Length == 1)
            {
                MessageBox.Show("Open file" + e.Args[0]);//Chuyển dữ liệu từ command line hiển thị ra
                window.Show();
            }
        }
    }

}
