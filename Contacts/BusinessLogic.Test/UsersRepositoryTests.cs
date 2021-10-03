using System;
using System.Collections.Generic;
using BusinessLogic.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace BusinessLogic.Test
{
    [TestClass]
    public class UsersRepositoryTests
    {

        private User adminUser;
        private IList<User> users;

        [TestInitialize]
        public void Setup()
        {
            adminUser = new User()
            {
                Username = "admin",
                Password = "password",
                IsAdmin = true,
            };
            users.Add(adminUser);
            users = new List<User>();
            for (int i = 0; i < 20; i++)
            {
                var user = new User()
                {
                    Username = $"username{i}",
                    Password = $"password{i}"
                };
                users.Add(user);
            }
        }

        [TestMethod]
        public void EmptyConstructor()
        {
            var usersRepo = new UsersRepository();

            Assert.IsNotNull(usersRepo);
        }

        [TestMethod]
        public void AddUserTest()
        {
            var usersRepo = new UsersRepository();

            usersRepo.Add(adminUser);

            Assert.IsTrue(usersRepo.Exists(adminUser.Username));
        }

        [TestMethod]
        public void NonExistentuserTest()
        {
            var usersRepo = new UsersRepository();

            Assert.IsFalse(usersRepo.Exists(adminUser.Username));
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "User already exists")]
        public void AddDuplicatedUserTest()
        {
            var usersRepo = new UsersRepository();

            usersRepo.Add(adminUser);
            usersRepo.Add(adminUser);
        }

        [TestMethod]
        public void GetUserTest()
        {
            var usersRepo = new UsersRepository();
            usersRepo.Add(adminUser);

            User user = usersRepo.Get(adminUser.Username);

            Assert.AreEqual(adminUser.Username, user.Username);
            Assert.AreEqual(adminUser.Password, user.Password);
            Assert.AreEqual(adminUser.IsAdmin, user.IsAdmin);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "User does not exist")]
        public void GetNonExistentUserTest()
        {
            var usersRepo = new UsersRepository();
            
            User user = usersRepo.Get(adminUser.Username);
        }

        [TestMethod]
        public void UpdateUserTest()
        {
            var usersRepo = new UsersRepository();
            usersRepo.Add(adminUser);
            var newPasswordAdmin = new User() //creating a new object so I don't modify the same object in memory by using the same pointer.
            {
                Username = adminUser.Username,
                Password = adminUser.Password + "a",
                IsAdmin = adminUser.IsAdmin
            };

            usersRepo.Update(newPasswordAdmin);

            var modifiedUser = usersRepo.Get(adminUser.Username);

            Assert.AreEqual(newPasswordAdmin.Password, modifiedUser.Password);
        }

        [TestMethod]
        public void RemoveUserTest()
        {
            var usersRepo = new UsersRepository();
            usersRepo.Add(adminUser);

            usersRepo.Remove(adminUser.Username);

            Assert.IsTrue(usersRepo.Exists(adminUser.Username));
        }

        [TestMethod]
        public void GetAllTest()
        {
            var usersRepo = new UsersRepository();
            foreach (var user in users)
                usersRepo.Add(user);

            IList<User> usersRetrieved = usersRepo.GetAll();

            foreach(var user in usersRetrieved)
            {
                Assert.IsTrue(users.Any(u => u.Username == user.Username));
            }

        }

        [TestMethod]
        public void CountTest()
        {
            var usersRepo = new UsersRepository();
            foreach (var user in users)
                usersRepo.Add(user);

            int usersCount = usersRepo.Count;

            Assert.AreEqual(users.Count, usersCount);

        }

        [TestMethod]
        public void ClearAllTest()
        {
            var usersRepo = new UsersRepository();
            foreach (var user in users)
                usersRepo.Add(user);

            usersRepo.Clear();

            int usersCount = usersRepo.Count;

            Assert.AreEqual(0, usersCount);

        }


    }
}
