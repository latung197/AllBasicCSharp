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
    /// Interaction logic for E37ItemsControl.xaml
    /// </summary>
    public partial class E37ItemsControl : Window
    {
        // Dùng để tạo danh sách các control giống nhau
        public E37ItemsControl()
        {
            InitializeComponent();
            List<TodoItems> todoItems = new List<TodoItems>();
            todoItems.Add(new TodoItems() { Title = "Complete this WPF tutorial", Completion = 45 });
            todoItems.Add(new TodoItems() { Title = "Learn C#", Completion = 80 });
            todoItems.Add(new TodoItems() { Title = "Wash the car", Completion = 0 });
            icTodoList.ItemsSource = todoItems;
        }
    }
    public class TodoItems
    {
        public string Title { get; set; }
        public int Completion { get; set; }
    }

}
