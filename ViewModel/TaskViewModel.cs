using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ToDoList.ViewModel 
{
    public class TaskViewModel : INotifyPropertyChanged
    {
        private bool _complete = false;

        public string Name { get; set; }
        public bool IsComplete
        { 
            get { return _complete; } 
            set
            {
                if (_complete != value)
                {
                    _complete = value;
                    NotifyPropertyChanged(nameof(IsComplete));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
