using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ToDoList.ViewModel;

namespace ToDoList.Command
{
    public class CreateTaskCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            //Can always execute
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter is TaskListViewModel taskList)
            {
                taskList.Tasks.Add(new TaskViewModel() { Name = taskList.TaskName, IsComplete = false });
            }

        }
    }
}
