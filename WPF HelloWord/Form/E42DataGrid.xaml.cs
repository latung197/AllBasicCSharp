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
using static WPF_HelloWord.Form.E40ListView;

namespace WPF_HelloWord.Form
{
    /// <summary>
    /// Interaction logic for E42DataGrid.xaml
    /// </summary>
    public partial class E42DataGrid : Window
    {
        public E42DataGrid()
        {
            InitializeComponent();
            List <User1> user1s = new List<User1>();
            user1s.Add(new User1() { Id = 1, Name = "John Doe", Birthday = new DateTime(1971, 7, 23) });
            user1s.Add(new User1() { Id = 2, Name = "Jane Doe", Birthday = new DateTime(1974, 1, 17) });
            user1s.Add(new User1() { Id = 3, Name = "Sammy Doe", Birthday = new DateTime(1991, 9, 2) });
            dgEx1.ItemsSource = user1s;

            List<User2> users2 = new List<User2>();
            users2.Add(new User2() { Id = 1, Name = "John Doe", Birthday = new DateTime(1971, 7, 23) });
            users2.Add(new User2() { Id = 2, Name = "Jane Doe", Birthday = new DateTime(1974, 1, 17) });
            users2.Add(new User2() { Id = 3, Name = "Sammy Doe", Birthday = new DateTime(1991, 9, 2) });

            dgUsers.ItemsSource = users2;

            dgUsers3.ItemsSource = users2;
        }


    }

    public class User2
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Birthday { get; set; }

        public string Details
        {
            get
            {
                return String.Format("{0} was born on {1} and this is a long description of the person.", this.Name, this.Birthday.ToLongDateString());
            }
        }
    }

    public class User1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
    }
}
