using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace WPFMVVM.Models
{
    public class Person: INotifyPropertyChanged
    {
        private string firstName;
        private string lastName;
        private string fullName;

        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
                OnPropertyRaised("FirstName");
                OnPropertyRaised("FullName");
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
                OnPropertyRaised("LastName");
                OnPropertyRaised("FullName");
            }
        }
        public string FullName
        {
            get { return firstName + " " + lastName; }
            set
            {
                fullName = value;
                OnPropertyRaised("FullName");
            }
        }

        public Person()
        {
            firstName = "Tung";
            LastName = "Le van";
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyRaised(string propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
