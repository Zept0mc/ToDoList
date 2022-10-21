using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Class
{
    public class ToDoTaskManager
    {
        List<ToDoTask> _allTasks;

        public ToDoTaskManager()
        {
            _allTasks = new List<ToDoTask>();
        }

        public ToDoTask FindTask(int taskId)
        {
            foreach (ToDoTask task in _allTasks)
            {
                if(task.Id == taskId)
                {
                    return task;
                }
            }

            return null;
        }

        public void AddToDoTask(ToDoTask task)
        {
            _allTasks.Add(task);
        }

        public void RemoveToDoTask(int taskId)
        {
            ToDoTask task = FindTask(taskId);
            _allTasks.Remove(task);
        }

        public List<ToDoTask> GetUserTasks(Guid userId)
        {
            List<ToDoTask> tempList = new List<ToDoTask>();

            foreach (ToDoTask task in _allTasks)
            {
                if(task.UserId == userId)
                {
                    tempList.Add(task);
                }
            }

            return tempList;
        }

        public int CalculateNextId()
        {
            int max = 0;

            foreach (ToDoTask task in _allTasks)
            {
                if(task.Id > max)
                {
                    max = task.Id;
                }
            }

            return max + 1;
        }
    }
}
//autor: Jakub Kuczera