using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLogic.Test
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void ConstructorTest()
        {
            User user = new User();

            Assert.IsNotNull(user);
        }

        [TestMethod]
        public void UsernameTest()
        {
            User user = new User()
            {
                Username = "username"
            };

            var username = user.Username;

            Assert.AreEqual("username", username);
        }

        [TestMethod]
        public void PasswordTest()
        {
            User user = new User()
            {
                Password = "abc"
            };

            var password = user.Password;

            Assert.AreEqual("abc", password);
        }

        [TestMethod]
        public void IsAdminTest()
        {
            User user = new User()
            {
                IsAdmin = true
            };

            var isAdmin = user.IsAdmin;

            Assert.AreEqual(true, isAdmin);
        }

        [TestMethod]
        public void DefaultAdminToFalseTest()
        {
            User user = new User();

            Assert.AreEqual(false, user.IsAdmin);
        }
    }
}
