using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.ViewModel
{
    public class TaskListViewModel
    {
        public ObservableCollection<TaskViewModel> Tasks { get; set; }
        public string TaskName { get; set; }
    }
}
