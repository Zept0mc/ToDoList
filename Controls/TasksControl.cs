using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoList.Class;
using ToDoList.Forms;

namespace ToDoList.Controls
{
    public partial class TasksControl : UserControl
    {
        private MainForm _mainForm;
        private User _loggedin;
        private ToDoTaskManager _toDoTaskManager;

        public TasksControl(MainForm mainForm, User user)
        {
            InitializeComponent();

            _mainForm = mainForm;

            _loggedin = user;
            lblZalogowanyWartosc.Text = _loggedin.Name;

            Dock = DockStyle.Fill;

            _toDoTaskManager = new ToDoTaskManager();

            foreach (ToDoTask task in _toDoTaskManager.GetUserTasks(_loggedin.Id))
            {
                AddTaskToListView(task);
            }
        }

        private void AddTaskToListView(ToDoTask task)
        {
            ListViewItem item = new ListViewItem(task.Id.ToString());
            item.SubItems.Add(task.Title);

            string ready = task.IsFinished ? "✓" : "✕";

            item.SubItems.Add(ready);

            lvZadania.Items.Add(item);
        }

        private void btnWyloguj_Click(object sender, EventArgs e)
        {
            _mainForm.ShowLoginControl();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            int id = _toDoTaskManager.CalculateNextId();

            ToDoTask newTask = new ToDoTask(id, _loggedin.Id, "", "");

            ToDoTaskForm taskForm = new ToDoTaskForm(newTask);
            taskForm.ShowDialog();

            if (taskForm.IfSaved)
            {
                _toDoTaskManager.AddToDoTask(newTask);
                AddTaskToListView(newTask);
            }

        }


        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            if (lvZadania.SelectedItems.Count == 0)
            {
                MessageBox.Show("Zaznacz zadanie do edycji!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string taskId = lvZadania.SelectedItems[0].SubItems[0].Text;
                ToDoTask task = _toDoTaskManager.FindTask(int.Parse(taskId));

                ToDoTaskForm taskForm = new ToDoTaskForm(task);
                taskForm.ShowDialog();

                if (taskForm.IfSaved)
                {
                    lvZadania.SelectedItems[0].SubItems[1].Text = task.Title;
                    lvZadania.SelectedItems[0].SubItems[1].Text = task.IsFinished ? "✓" : "✕";

                }
            }
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            if(lvZadania.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nie wybrano zadania do usunięcia.", "Informacja", MessageBoxButtons.OK);
            }
            else
            {
                string taskId = lvZadania.SelectedItems[0].SubItems[0].Text;

                _toDoTaskManager.RemoveToDoTask(int.Parse(taskId));

                lvZadania.Items.Remove(lvZadania.SelectedItems[0]);
            }
        }
        //autor: Jakub Kuczera
        private void TasksControl_Load(object sender, EventArgs e)
        {

        }
    }
}
