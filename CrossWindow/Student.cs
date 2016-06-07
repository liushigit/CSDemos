using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CrossWindow
{
    class Student : INotifyPropertyChanged
    {
        private string _name;
        public string Name
        {
            set {
                _name = value;
                OnPropertyChanged("Name");
            }
            get
            {
                return _name;
            }
        }

        public void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null )
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }

    class StudentsViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Student> Students
        {
            set; get;
        }

        private Student _selectedStudent;
        public Student SelectedStudent {
            set
            {
                _selectedStudent = value;
                NotifyPropertyChanged("SelectedStudent");
            }
            get
            {
                return _selectedStudent;
            }
        }

        private void NotifyPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public StudentsViewModel()
        {
            Students = new ObservableCollection<Student>() {
                new Student() {Name="AA" },
                new Student() {Name="AB" },
            };
        }

    }
}
