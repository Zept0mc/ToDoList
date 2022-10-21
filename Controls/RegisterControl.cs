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

namespace ToDoList.Controls
{
    public partial class RegisterControl : UserControl
    {
        private MainForm _mainForm;

        public RegisterControl(MainForm mainForm)
        {
            InitializeComponent();

            _mainForm = mainForm;

            Dock = DockStyle.Fill;
        }

     
        private void btnZarejestruj_Click(object sender, EventArgs e)
        {
            if (tbHaslo.Text.Length < 8)
            {
                lblHasloWalidacja.Text = "Za krótkie hasło.";
            }

            if (tbPowtorzHaslo.Text != tbHaslo.Text)
            {
                lblPowtorzHasloWalidacja.Text = "Sprawdź hasło i jego powtórzenie.";
            }

            if(_mainForm.UserManager.ifLoginAvailable(tbLogin.Text))
            {
                User newUser = new User(Guid.NewGuid(), tbImie.Text, tbHaslo.Text, tbLogin.Text);
                _mainForm.UserManager.AddUser(newUser);

                _mainForm.ShowLoginControl();
            }



            _mainForm.ShowLoginControl();
        }

        private void btnCofnij_Click(object sender, EventArgs e)
        {
            _mainForm.ShowLoginControl();
        }
        //autor: Jakub Kuczera
        private void RegiserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
