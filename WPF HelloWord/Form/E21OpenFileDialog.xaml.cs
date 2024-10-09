using System;
using System.IO;
using System.Windows;
using Microsoft.Win32;

namespace WPF_HelloWord.Form
{
    /// <summary>
    /// Interaction logic for E21OpenFileDialog.xaml
    /// </summary>
    public partial class E21OpenFileDialog : Window
    {
        public E21OpenFileDialog(string question, string defaultAnswer ="")// Các tham số này được chuyền vào khi bắt đầu mở form từ button main
        {
            InitializeComponent();
            lblQuestion.Content = question;
            txtAnswer.Text = defaultAnswer;
        }

        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog()==true)
            {
                txtEditor.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true; // Cho phép chọn nhiều file
            openFileDialog.Filter = "Text files (*.txt)|*txt|All files (*.*)|*.*"; // Lọc file
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (openFileDialog.ShowDialog() == true)
            {
                foreach (string filename in openFileDialog.FileNames)// Lấy ra danh sách tên file
                    lbFiles.Items.Add(Path.GetFileName(filename));
            }
        }

        private void btnSaveFile_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text file (*.txt)|*.txt|C# file (*.cs)|*.cs";// Lọc file của thư mục khi mở

            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);// Cách setup mặc định mở đến thư mục mặc định của window(Ở đây là Document, có thế là system hoặc Download)... Sử dụng biến Environment để sử lý
            saveFileDialog.AddExtension = true; // Mặc định true để xem tên file có được điền sẵn phần đuôi file hay không. Nếu người dùng bỏ qua phần đố phần đuôi file sẽ tự động được điền lấy theo bộ lọc file ở phí trên

            if (saveFileDialog.ShowDialog()==true)
            {
                File.WriteAllText(saveFileDialog.FileName, txtEditSaveFile.Text);
            }
        }

        private void btnDialogOk_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        public string Answer
        {
            get { return txtAnswer.Text; }
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            txtAnswer.SelectAll();
            txtAnswer.Focus();
        }
    }
}
