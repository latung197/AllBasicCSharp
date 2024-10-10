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
    /// Interaction logic for E39ListBoxControl.xaml
    /// </summary>
    public partial class E39ListBoxControl : Window
    {
        public E39ListBoxControl()
        {
            InitializeComponent();
            List<TodoItem> items = new List<TodoItem>();
            items.Add(new TodoItem() { Title = "Complete this WPF tutorial", Completion = 45 });
            items.Add(new TodoItem() { Title = "Learn C#", Completion = 80 });
            items.Add(new TodoItem() { Title = "Wash the car", Completion = 0 });

            lbTodoList.ItemsSource = items;

            List<TodoItem> items1 = new List<TodoItem>();
            items1.Add(new TodoItem() { Title = "Complete this WPF tutorial", Completion = 45 });
            items1.Add(new TodoItem() { Title = "Learn C#", Completion = 80 });
            items1.Add(new TodoItem() { Title = "Wash the car", Completion = 0 });

            lbTodoList1.ItemsSource = items;
        }

        private void btnShowSelectedItem_Click(object sender, RoutedEventArgs e)
        {
            foreach (object o in lbTodoList1.SelectedItems)
                MessageBox.Show((o as TodoItem).Title);
        }

        private void btnSelectLast_Click(object sender, RoutedEventArgs e)
        {
            lbTodoList1.SelectedIndex = lbTodoList1.Items.Count - 1;
        }

        private void btnSelectNext_Click(object sender, RoutedEventArgs e)
        {
            int nextIndex = 0;
            if ((lbTodoList1.SelectedIndex >= 0) && (lbTodoList1.SelectedIndex < (lbTodoList1.Items.Count - 1)))
                nextIndex = lbTodoList1.SelectedIndex + 1;
            lbTodoList1.SelectedIndex = nextIndex;
        }

        private void btnSelectCSharp_Click(object sender, RoutedEventArgs e)
        {
            foreach (object o in lbTodoList1.Items)
            {
                if ((o is TodoItem) && ((o as TodoItem).Title.Contains("C#")))
                {
                    lbTodoList1.SelectedItem = o;
                    break;
                }
            }
        }

        private void btnSelectAll_Click(object sender, RoutedEventArgs e)
        {
            foreach (object o in lbTodoList1.Items)
                lbTodoList1.SelectedItems.Add(o);
        }

        private void lbTodoList1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbTodoList1.SelectedItem != null)
                this.Title = (lbTodoList1.SelectedItem as TodoItem).Title;
        }
    }

    public class TodoItem
    {
        public string Title { get; set; }
        public int Completion { get; set; }
    }
}
