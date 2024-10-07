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
    /// Interaction logic for E15Databinding.xaml
    /// </summary>
    public partial class E15Databinding : Window
    {
        public E15Databinding()
        {
            InitializeComponent();
        }



        private void btnDatabindingHelloword_Click(object sender, RoutedEventArgs e)
        {
            E15DatabindingHelloword e15DatabindingHelloword = new E15DatabindingHelloword();
            e15DatabindingHelloword.ShowDialog();
        }

        private void btnDatabindingUingDatacontext_Click(object sender, RoutedEventArgs e)
        {
            E15DatabindingUsingDatacontext e15DatabindingUsingDatacontext = new E15DatabindingUsingDatacontext();
            e15DatabindingUsingDatacontext.ShowDialog();
        }

        private void btnDatabindingCodebehind_Click(object sender, RoutedEventArgs e)
        {
            E15DatabindingViaCodebehind databindingViaCodebehind = new E15DatabindingViaCodebehind();
            databindingViaCodebehind.ShowDialog();
        }

        private void btnDatabindingUpdateSourceTrigger_Click(object sender, RoutedEventArgs e)
        {
            E15UpdateSourceTrigger e15UpdateSourceTrigger = new E15UpdateSourceTrigger();
            e15UpdateSourceTrigger.ShowDialog();
        }
    }
}
