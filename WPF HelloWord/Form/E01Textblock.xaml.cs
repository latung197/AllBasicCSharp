using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Interaction logic for E01Textblock.xaml
    /// </summary>
    public partial class E01Textblock : Window
    {
        public E01Textblock()
        {
            InitializeComponent();

            //TextBlock tb = new TextBlock();
            //tb.TextWrapping = TextWrapping.Wrap;
            //tb.TextWrapping = TextWrapping.Wrap;
            //tb.Margin = new Thickness(10);
            //tb.Inlines.Add("An example on ");
            //tb.Inlines.Add(new Run("the TextBlock control ") { FontWeight = FontWeights.Bold });
            //tb.Inlines.Add("using ");
            //tb.Inlines.Add(new Run("inline ") { FontStyle = FontStyles.Italic });
            //tb.Inlines.Add(new Run("text formatting ") { Foreground = Brushes.Blue });
            //tb.Inlines.Add("from ");
            //tb.Inlines.Add(new Run("Code-Behind") { TextDecorations = TextDecorations.Underline });
            //tb.Inlines.Add(".");
            //this.Content = tb;
        }

        private void Hyperlink_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = e.Uri.AbsoluteUri, UseShellExecute = true });

        }
    }
}
