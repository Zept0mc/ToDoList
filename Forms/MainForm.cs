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
using ToDoList.Controls;

namespace ToDoList
{
    public partial class MainForm : Form
    {
        public UserManager UserManager;



        public MainForm()
        {
            InitializeComponent();
            UserManager = new UserManager();
            ShowLoginControl();
        }
       

        public void ShowLoginControl()
        {
            Controls.Clear();
            Controls.Add(new LoginControl(this));
        }
        public void ShowRegisterControl()
        {
            Controls.Clear();
            Controls.Add(new RegisterControl(this));
        }
        public void ShowTasksControl(User user)
        {
            Controls.Clear();
            Controls.Add(new TasksControl(this, user));
        }
        //autor: Jakub Kuczera
        private void btnZalozKonto_Click(object sender, EventArgs e)
        {

        }

        



    }
}
