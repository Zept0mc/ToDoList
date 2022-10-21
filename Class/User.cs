using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Class
{
    public class User
    {
        public Guid Id;
        public string Name;
        public string Password;
        public string Login;

        public User(Guid id, string name, string password, string login)
        {
            Id = id;
            Name = name;
            Password = password;
            Login = login;
        }
    }

}
//autor: Jakub Kuczera