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
                    EmailAddress = "kyle.bruening@trojans.dsu.edu"


                    

                });     
            }


        }




    }
}
