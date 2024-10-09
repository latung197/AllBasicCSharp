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
    /// Interaction logic for E27FlowDocumentPageViewerControl.xaml
    /// </summary>
    public partial class E27FlowDocumentPageViewerControl : Window
    {
        public E27FlowDocumentPageViewerControl()
        {
            InitializeComponent();
            CodeBehindFlowDocumentSample();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            fdViewer.Find();
        }

        public void CodeBehindFlowDocumentSample()
        {
            FlowDocument flowDocument = new FlowDocument();
            Paragraph paragraph = new Paragraph(new Run("Hello Word!"));
            paragraph.FontSize = 36;
            flowDocument.Blocks.Add(paragraph);
            paragraph = new Paragraph(new Run("The Ulitimate Programming Greeting!"));
            paragraph.FontSize = 14;
            paragraph.FontStyle = FontStyles.Italic;
            paragraph.TextAlignment = TextAlignment.Left;
            paragraph.Foreground = Brushes.Gray;
            flowDocument.Blocks.Add(paragraph);
            fdCodeBehind.Document = flowDocument;
        }
    }
}
