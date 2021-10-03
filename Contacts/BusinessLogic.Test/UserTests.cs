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

            Assert.AreEqual("abc", user.Password);
        }
    }
}
