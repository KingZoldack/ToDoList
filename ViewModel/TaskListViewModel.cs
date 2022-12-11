using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ToDoList.Command;

namespace ToDoList.ViewModel
{
    public class TaskListViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<TaskViewModel> _tasks = new ObservableCollection<TaskViewModel>();

        public ObservableCollection<TaskViewModel> Tasks
        {
            get { return _tasks; }
            set
            {
                if (_tasks != value)
                {
                    _tasks = value;
                    NotifyPropertyChanged(nameof(Tasks));
                }
            }
        }
        public string TaskName { get; set; }

        //Side effect - Creates something new every time
        public ICommand CreateTaskCommand 
        { 
            get
            {
                return new CreateTaskCommand();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
