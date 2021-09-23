using CSC470_P3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestAppUserFakeRepository
{
    [TestClass]
    public class Login
    {
        [TestMethod]
        public void LoginWithCorrectCredentialsSuccessful()
        {
            const string UserName = "kbrue54";
            const string Password = "Password123";
            FakeAppUserRepository AppUsRepository = new FakeAppUserRepository();

            bool ActuallyAuthenticated = AppUsRepository.Login(UserName, Password);
        }
    }
}
