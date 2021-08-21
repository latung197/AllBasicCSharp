using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Bai22ObservableCollection
{
   public  class Program
    {

        static void Main(string[] args)
        {
            ObservableCollection<string> List = new ObservableCollection<string>();
            List.CollectionChanged += change;
            List.Add("Le Van Tung");
            List.Clear();
            Console.ReadKey();
        }
        /*
        -   Lớp Generic ObservableCollection<T> là một tập hợp tương tự như List<T> ..., tức là nó mô tả một 
                tập hợp dữ liệu có thể thay đổi số lượng bằng các phương thức quen thuộc như Add(), Remove(), Clear() ...
        -   Nhưng với ObservableCollection<T> thì nó cung cấp thêm sự kiện thông báo như số lượng phần tử 
                thay đổi như thêm, bớt ...(nghĩa là giám sát được biến động phần tử). 
        */
        public static void change(Object sender, NotifyCollectionChangedEventArgs  e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach (String s in e.NewItems)
                        Console.WriteLine($"Thêm :  {s}");
                    break;

                case NotifyCollectionChangedAction.Reset:
                    Console.WriteLine("Clear");
                    break;

                case NotifyCollectionChangedAction.Remove:
                    foreach (String s in e.OldItems)
                        Console.WriteLine($"Remove :  {s}");
                    break;
                case NotifyCollectionChangedAction.Replace:
                    Console.WriteLine("Repaced - " + e.NewItems[0]);
                    break;
            }
        }
    }
}
