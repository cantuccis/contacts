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

        [TestMethod]
        public void CloneTest()
        {
            User user = new User()
            {
                Username = "username",
                Password = "password",
                IsAdmin = true
            };

            User clone = user.DeepClone();

            Assert.AreEqual(user.Username, clone.Username);
            Assert.AreEqual(user.Password, clone.Password);
            Assert.AreEqual(user.IsAdmin, clone.IsAdmin);
        }

    }
}
