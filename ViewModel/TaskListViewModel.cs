using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ToDoList.Command;

namespace ToDoList.ViewModel
{
    public class TaskListViewModel
    {
        public ObservableCollection<TaskViewModel> Tasks { get; set; }
        public string TaskName { get; set; }

        //Side effect - Creates something new every time
        public ICommand CreateTaskCommand 
        { 
            get
            {
                return new CreateTaskCommand();
            }
        }
    }
}
