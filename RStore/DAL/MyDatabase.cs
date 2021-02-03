using RStore.DataContext;
using RStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RStore.DAL
{
   public class MyDatabase
    {
        public void UserAdd(User user)
        {
            using (RStoreDataContext rStore = new RStoreDataContext())
            {
                rStore.Users.Add(user);
                rStore.SaveChanges();
            }
        }
        public static List<User> GetAllUser()
        {
            using (RStoreDataContext rStore = new RStoreDataContext())
            {
                var users = rStore.Users.ToList();

                return users;
            }

        }

        private static List<User> _users;
        public  int userId { get; set; }

        
        public  bool UserChecking(string email, string password)
        {
            _users = GetAllUser();
            bool result = false;
            foreach (User user in _users)
            {
                if (user.Email.ToLower() ==email.ToLower()  && user.Password == password)
                {
                    userId = user.Id;
                    result = true;
                    break;
                }
            }
            return result;

        }


        public bool AdminChecking()
        {
            bool admcheck = false;
            _users = GetAllUser();
            foreach(User user in _users)
            {
                if (user.Id == userId)
                {
                    if (user.Status == null)
                    {
                        admcheck = true;
                    }
                }
            }
            return admcheck;
        }



        public bool EmailChecking(string email)
        {
            _users = GetAllUser();
            bool result = true;
            foreach (User user in _users)
            {
                if (user.Email==email)
                {
                    result = false;
                    break;
                }
            }
            return result;


        }

        









    }
}
