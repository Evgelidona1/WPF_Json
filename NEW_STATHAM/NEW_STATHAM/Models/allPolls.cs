using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_STATHAM.Models
{
    public class allPolls : INotifyPropertyChanged
    {
        public allPolls() { }
        public int ID { get; set; }
        public string name { get; set; }
        public List<Item> items { get; set; }


        public class Item : INotifyPropertyChanged
        {
            public Item() { }
            private string _description;
            private bool _isDone;

            public string description
            {
                get { return _description; }
                set {
                    if (_description == value)
                    {
                        return;
                    }
                    _description = value;
                    OnPropertyChanged("description");
                }
            }
            public bool isDone
            {
                get { return _isDone; }
                set { 
                    if(_isDone == value)
                    {
                        return;
                    }
                    _isDone = value;
                    OnPropertyChanged("isDone");
                }
            }
            public event PropertyChangedEventHandler PropertyChanged;
            protected virtual void OnPropertyChanged(string propertyName = "")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

            }

        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }

    }
    public class allPolls2 : INotifyPropertyChanged
    {
        public allPolls2() { }
        public int ID { get; set; }
        public string name { get; set; }
        public Item[] items { get; set; }


        public class Item : INotifyPropertyChanged
        {
            public Item() { }
            private string _description;
            private bool _isDone;

            public string description
            {
                get { return _description; }
                set
                {
                    if (_description == value)
                    {
                        return;
                    }
                    _description = value;
                    OnPropertyChanged("description");
                }
            }
            public bool isDone
            {
                get { return _isDone; }
                set
                {
                    if (_isDone == value)
                    {
                        return;
                    }
                    _isDone = value;
                    OnPropertyChanged("isDone");
                }
            }
            public event PropertyChangedEventHandler PropertyChanged;
            protected virtual void OnPropertyChanged(string propertyName = "")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

            }

        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }

    }
}
