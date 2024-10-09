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
    /// Interaction logic for E25StatusBarcontrol.xaml
    /// </summary>
    public partial class E25StatusBarcontrol : Window
    {
        public E25StatusBarcontrol()
        {
            InitializeComponent();
        }

        private void txtEditor_SelectionChanged(object sender, RoutedEventArgs e)
        {
            int row = txtEditor.GetLineIndexFromCharacterIndex(txtEditor.CaretIndex); // Lấy ra số dòng
            int col = txtEditor.CaretIndex - txtEditor.GetCharacterIndexFromLineIndex(row); // Lấy ra số ký tự
            lblCursorPosition.Text = "Line: " + (row + 1) + ", Char: "+(col + 1); 
        }

        private void txtEdit_SelectionChanged(object sender, RoutedEventArgs e)
        {
            int row = txtEdit.GetLineIndexFromCharacterIndex(txtEdit.CaretIndex);
            int col = txtEdit.CaretIndex - txtEdit.GetCharacterIndexFromLineIndex(row);
            lblCursor.Text = "Line " + (row + 1) + ", Char " + (col + 1);
        }
    }
}
