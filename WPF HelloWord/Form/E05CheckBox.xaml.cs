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
    /// Interaction logic for E05CheckBox.xaml
    /// </summary>
    public partial class E05CheckBox : Window
    {
        public E05CheckBox()
        {
            InitializeComponent();
        }

        private void cbAllFreatures_Checked(object sender, RoutedEventArgs e)
        {

            bool newVal = (cbAllFreature.IsChecked == true);
            cbFreatureItem1.IsChecked = newVal;
            cbFreatureItem2.IsChecked = newVal;
            cbFreatureItem3.IsChecked = newVal;

        }

        private void cbAllFreature_Checked(object sender, RoutedEventArgs e)
        {
            cbAllFreature.IsChecked = null;
            if ((cbFreatureItem1.IsChecked == true) && (cbFreatureItem2.IsChecked == true) && (cbFreatureItem3.IsChecked == true))
                cbAllFreature.IsChecked = true;

            if ((cbFreatureItem1.IsChecked == false) && (cbFreatureItem2.IsChecked == false) && (cbFreatureItem3.IsChecked == false))
            {
                cbAllFreature.IsChecked = false;
            }
        }
    }
}
