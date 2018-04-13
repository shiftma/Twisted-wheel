using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwistedWheel.Models
{
    public class UserData
    {
        private static List<User> users = new List<User>();

        public static void AddUser(User user)
        {
            foreach (var item in users)
            {
                if (users.Contains(user))
                {
                    Console.WriteLine("User is already in a list");
                    Console.ReadLine();
                }
                else
                {
                    users.Add(user);
                }
            }
        }

        public static List<User> GetAll()
        {
            return users;
        }

        public static User GetById(int id)
        {
            var user = users.Single(x => x.UserID == id);
            return (User)user;
        }
    }
}
