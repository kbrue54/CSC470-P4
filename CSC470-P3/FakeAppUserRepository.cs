using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC470_P3
{
    public class FakeAppUserRepository : IAppUserRepository
    { 

        private static Dictionary<int, AppUser> AppUsers;

        public FakeAppUserRepository()
        {
            if (AppUsers == null)
            {
                AppUsers = new Dictionary<int, AppUser>();
                AppUsers.Add(1, new AppUser
                {
                    UserName = "kbrue54",
                    Password = "Password123",
                    FirstName = "Kyle",
                    LastName = "Bruening",
                    EmailAddress = "kyle.bruening@trojans.dsu.edu",
                    IsAuthenticated = true


                    

                });     
            }


        }

        public bool Login(string UserName, string Password)
        {
            AppUser user = GetByUserName(UserName);
            if(user.Password == Password)
            {
                return true;
            } else {
                return false;
            }
                
        }

        public List<AppUser> GetAll()
        {
            List<AppUser> users = new List<AppUser>();
            foreach(KeyValuePair<int,AppUser> user in AppUsers)
            {
                users.Add(user.Value);
            }
            return users;
        }

        public void SetAuthentication(string UserName, bool IsAuthenticated)
        {
            AppUser user = GetByUserName(UserName);
            int key = AppUsers.FirstOrDefault(x => x.Value.UserName == UserName).Key ;
            user.IsAuthenticated = IsAuthenticated;
            AppUsers[key] = user;
        
        }

        public AppUser GetByUserName (string UserName)
        {
            List<AppUser> users = GetAll();
            return users.Find(x => x.UserName.Equals(UserName));
        
        }

    }
}
