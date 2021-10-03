using System;
using BusinessLogic.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLogic.Test
{
    [TestClass]
    public class CredentialsManagerTests
    {
        private User admin;
        private User simpleUser;
        private UsersRepository usersRepo;

        [TestInitialize]
        public void Setup()
        {
            usersRepo = new UsersRepository();
            admin = new User()
            {
                Username = "admin",
                Password = "password",
                IsAdmin = true
            };
            simpleUser = new User()
            {
                Username = "user",
                Password = "somepassword",
            };
        }

        [TestMethod]
        public void ConstructorWithParametersTest()
        {
            var credentialsManager = new CredentialsManager(usersRepo, admin);

            Assert.IsNotNull(credentialsManager);
        }

        [TestMethod]
        public void LoginTest()
        {
            var credentialsManager = new CredentialsManager(usersRepo, admin);
            Credentials credentials = new Credentials()
            {
                Username = admin.Username,
                Password = admin.Password
            };

            credentialsManager.Login(credentials);

            Assert.IsTrue(credentialsManager.IsLogged);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Invalid username or password")]
        public void InvalidPasswordLoginTest()
        {
            var credentialsManager = new CredentialsManager(usersRepo, admin);
            Credentials credentials = new Credentials()
            {
                Username = admin.Username,
                Password = "invalid"
            };

            credentialsManager.Login(credentials);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Invalid username or password")]
        public void InvalidUsernameLoginTest()
        {
            var credentialsManager = new CredentialsManager(usersRepo, admin);
            Credentials credentials = new Credentials()
            {
                Username = "invalid",
                Password = admin.Password
            };

            credentialsManager.Login(credentials);
        }

        [TestMethod]
        public void HashedPasswordTest()
        {
            var credentialsManager = new CredentialsManager(usersRepo, admin);

            var storedUser = usersRepo.Get(admin.Username);

            Assert.AreNotEqual(storedUser.Password, admin.Password);
        }

        [TestMethod]
        public void RegisterNewUserTest()
        {
            var credentialsManager = new CredentialsManager(usersRepo, admin);
            Credentials credentials = new Credentials()
            {
                Username = admin.Username,
                Password = admin.Password
            };
            credentialsManager.Login(credentials);

            credentialsManager.Register(simpleUser);

            credentialsManager.Logout();
            Credentials newUserCredentials = new Credentials()
            {
                Username = simpleUser.Username,
                Password = simpleUser.Password
            };
            credentialsManager.Login(newUserCredentials);

            Assert.IsTrue(credentialsManager.IsLogged);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Insufficient permissions")]
        public void InsufficientPermissionsTest()
        {
            var credentialsManager = new CredentialsManager(usersRepo, admin);
            Credentials credentials = new Credentials()
            {
                Username = admin.Username,
                Password = admin.Password
            };
            credentialsManager.Login(credentials);
            credentialsManager.Register(simpleUser);
            credentialsManager.Logout();
            Credentials newUserCredentials = new Credentials()
            {
                Username = simpleUser.Username,
                Password = simpleUser.Password
            };
            credentialsManager.Login(newUserCredentials);
            credentialsManager.Register(simpleUser);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Not logged in")]
        public void NotLoggedInTest()
        {
            var credentialsManager = new CredentialsManager(usersRepo, admin);
            credentialsManager.Register(simpleUser);
        }

    }
}
