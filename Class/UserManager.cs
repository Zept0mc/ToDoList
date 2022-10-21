using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Class
{
    public class UserManager
    {
        private List<User> _users;

        public UserManager()
        {
            _users = new List<User>();

            _users.Add(new User(Guid.NewGuid(), "test", "test", "test"));
        }

       

        public User FindUser(string login, string password)
        {
             foreach(User user in _users)
                {
                    if (user.Login == login && user.Password == password)
                    {
                        return user;
                    }
                }

             return null;
        }

        public bool ifLoginAvailable(string Login)
        {
             foreach(User user in _users)
             {
                    if(Login == user.Login)
                    {
                        return false;
                    }
             }

             return true;
        }


        public void AddUser(User user)
        {
             _users.Add(user);
        }
    }
}
//autor: Jakub Kuczera