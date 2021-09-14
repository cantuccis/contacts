using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLogic.Test
{
    [TestClass]
    public class ProfileTests
    {
        private const string John = "John";
        private const string Doe = "Doe";
        private const int Age23 = 23;
        private const string PhoneNumberSample = "+59899999999";
        private const string SomeStreetAddress = "SomeStreet 1111";
        private Profile johnDoeProfile;

        private const string TooLongName = "verylongfirstnamethatshouldnotworkherelikeseriouslywhohassuchalongname??";

        [TestInitialize]
        public void Initialize()
        {
            johnDoeProfile = new Profile()
            {
                FirstName = John,
                LastName = Doe,
                Age = Age23,
                PhoneNumber = PhoneNumberSample,
                Address = SomeStreetAddress,
            };
        }

        [TestMethod]
        public void NewProfile()
        {
            Assert.IsNotNull(johnDoeProfile);
        }


        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "First name length must be between 2 and 30")]
        public void FirstNameMaxLengthTest()
        {
            johnDoeProfile.FirstName = TooLongName;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "First name length must be between 2 and 30")]
        public void FirstNameMinLengthTest()
        {
            johnDoeProfile.FirstName = "";
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "First name cannot be null")]
        public void FirstNameNotNullTest()
        {
            johnDoeProfile.FirstName = null;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Last name length must be between 2 and 60")]
        public void LastNameMaxLengthTest()
        {
            johnDoeProfile.LastName = TooLongName;
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "Last name length must be between 2 and 60")]
        public void LastNameMinLengthTest()
        {
            johnDoeProfile.LastName = "";
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "Last name cannot be null")]
        public void LastNameNotNullTest()
        {
            johnDoeProfile.LastName = null;
        }

    }
}
