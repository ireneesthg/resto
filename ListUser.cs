using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resto.Models
{
    public static class ListUser
    {
        public static List<User> Users = new List<User>();
        public static User? LoggedInUser { get; set; } = null; //null default
        public static bool Login(string username, string password)
        {
            var user = Users.FirstOrDefault(u => u.Username == username && u.Password == password);
            if (ListUser.LoggedInUser != null)
            {
                LoggedInUser = user;
                return true;
            }
            return false;
        }

        //fungsi register
        public static bool Register(string username, string password)
        {
            if (Users.Any(u => u.Username == username))
                return false;

            Users.Add(new User(username, password));
            return true;
        }
    }
}