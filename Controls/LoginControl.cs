﻿using System;
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
    public partial class LoginControl : UserControl
    {
        private MainForm _mainForm;

        public LoginControl(MainForm mainForm )
        {
            InitializeComponent();

            _mainForm = mainForm;

            Dock = DockStyle.Fill;
        }

        private void btnZaloguj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbLogin.Text) || string.IsNullOrWhiteSpace(tbHaslo.Text))
            {
                lblWalidacjaLogowania.Text = "Login i hasło są wymagane.";
                lblWalidacjaLogowania.Visible = true;
            }
            else
            {
                User user = _mainForm.UserManager.FindUser(tbLogin.Text, tbHaslo.Text);

                if(user == null)
                {
                    lblWalidacjaLogowania.Text = "Nieprawidłowy login lub hasło.";
                    lblWalidacjaLogowania.Visible = true;
                }
                else
                {
                    _mainForm.ShowTasksControl(user);
                }
            }  
        }
        //autor: Jakub Kuczera
        private void btnZalozKonto_Click(object sender, EventArgs e)
        {
            _mainForm.ShowRegisterControl();
        }
    }
}
