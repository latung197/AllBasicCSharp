using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for E40ListView.xaml
    /// </summary>
    public partial class E40ListView : Window
    {

        private GridViewColumnHeader listViewSortCol = null;
        private SortAdorner listViewSortAdorner = null;
        public E40ListView()
        {
            InitializeComponent();
            List<User> items = new List<User>();
            items.Add(new User() { Name = "John Doe", Age = 42 });
            items.Add(new User() { Name = "Jane Doe", Age = 39 });
            items.Add(new User() { Name = "Sammy Doe", Age = 13 });
            lvDataBinding1.ItemsSource = items;


            List<User> items1 = new List<User>();
            items1.Add(new User() { Name = "John Doe", Age = 42, Mail = "john@doe-family.com" });
            items1.Add(new User() { Name = "Jane Doe", Age = 39, Mail = "jane@doe-family.com" });
            items1.Add(new User() { Name = "Sammy Doe", Age = 13, Mail = "sammy.doe@gmail.com" });
            lvDataBinding.ItemsSource = items1;

            List<User> items2 = new List<User>();
            items2.Add(new User() { Name = "John Doe", Age = 42, Mail = "john@doe-family.com" });
            items2.Add(new User() { Name = "Jane Doe", Age = 39, Mail = "jane@doe-family.com" });
            items2.Add(new User() { Name = "Sammy Doe", Age = 7, Mail = "sammy.doe@gmail.com" });
            lvUser.Items.Clear();
            lvUser.ItemsSource = items2;
            lvUsers2.Items.Clear();
            lvUsers2.ItemsSource = items1;
            lvUsers3.Items.Clear();
            lvUsers3.ItemsSource = items2;

            // Group by
            List<User> items4 = new List<User>();
            items4.Add(new User() { Name = "John Doe", Age = 42, Sex = SexType.Male });
            items4.Add(new User() { Name = "Jane Doe", Age = 39, Sex = SexType.Female });
            items4.Add(new User() { Name = "Sammy Doe", Age = 13, Sex = SexType.Male });
            lvUser4.Items.Clear();
            lvUser4.ItemsSource = items4;
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lvUser4.ItemsSource);
            PropertyGroupDescription groupDescription = new PropertyGroupDescription("Sex");
            view.GroupDescriptions.Add(groupDescription);

            // Sorting
            lvUser5.Items.Clear();
            lvUser5.ItemsSource = items4;
            CollectionView view5 = (CollectionView)CollectionViewSource.GetDefaultView(lvUser5.ItemsSource);
            view5.SortDescriptions.Add(new SortDescription("Age", ListSortDirection.Ascending));
            view5.SortDescriptions.Add(new SortDescription("Name", ListSortDirection.Ascending));

            lvUsers6.Items.Clear();
            lvUsers6.ItemsSource = items4;

            lvUsers7.Items.Clear();
            lvUsers7.ItemsSource = items4;

            CollectionView view7 = (CollectionView)CollectionViewSource.GetDefaultView(lvUsers7.ItemsSource);
            view.Filter = UserFilter;

        }

        private bool UserFilter(object item)
        {
            if (String.IsNullOrEmpty(txtFilter.Text))
                return true;
            else
                return ((item as User).Name.IndexOf(txtFilter.Text, StringComparison.OrdinalIgnoreCase) >= 0);
        }

        public enum SexType { Male, Female }

        public class User
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Mail { get; set; }
            public SexType Sex { get; set; }
            public override string ToString()
            {
                return this.Name + "," + this.Age + "Year Old";
            }
        }



        private void lvUsersColumnHeader_Click(object sender, RoutedEventArgs e)
        {
            GridViewColumnHeader column = (sender as GridViewColumnHeader);
            string sortBy = column.Tag.ToString();
            if (listViewSortCol != null)
            {
                AdornerLayer.GetAdornerLayer(listViewSortCol).Remove(listViewSortAdorner);
                lvUsers6.Items.SortDescriptions.Clear();
            }

            ListSortDirection newDir = ListSortDirection.Ascending;
            if (listViewSortCol == column && listViewSortAdorner.Direction == newDir)
                newDir = ListSortDirection.Descending;

            listViewSortCol = column;
            listViewSortAdorner = new SortAdorner(listViewSortCol, newDir);
            AdornerLayer.GetAdornerLayer(listViewSortCol).Add(listViewSortAdorner);
            lvUsers6.Items.SortDescriptions.Add(new SortDescription(sortBy, newDir));
        }

        private void txtFilter_TextChanged(object sender, TextChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(lvUsers7.ItemsSource).Refresh();
        }
    }
    // Vẽ mũi tên lên xuống
    public class SortAdorner : Adorner
    {
        private static Geometry ascGeometry =
            Geometry.Parse("M 0 4 L 3.5 0 L 7 4 Z");

        private static Geometry descGeometry =
            Geometry.Parse("M 0 0 L 3.5 4 L 7 0 Z");

        public ListSortDirection Direction { get; private set; }

        public SortAdorner(UIElement element, ListSortDirection dir)
            : base(element)
        {
            this.Direction = dir;
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);

            if (AdornedElement.RenderSize.Width < 20)
                return;

            TranslateTransform transform = new TranslateTransform
                (
                    AdornedElement.RenderSize.Width - 15,
                    (AdornedElement.RenderSize.Height - 5) / 2
                );
            drawingContext.PushTransform(transform);

            Geometry geometry = ascGeometry;
            if (this.Direction == ListSortDirection.Descending)
                geometry = descGeometry;
            drawingContext.DrawGeometry(Brushes.Black, null, geometry);

            drawingContext.Pop();
        }
    }
}
