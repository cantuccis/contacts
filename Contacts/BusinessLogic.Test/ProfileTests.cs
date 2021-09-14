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

        [TestMethod]
        public void NewProfile()
        {
            var aProfile = new Profile()
            {
                FirstName = John,
                LastName = Doe,
                Age = Age23,
                PhoneNumber = PhoneNumberSample,
                Address = SomeStreetAddress,
            };
            Assert.IsNotNull(aProfile);
        }


        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "First name length must be between 2 and 30")]
        public void FirstNameMaxLengthTest()
        {
            var aProfile = new Profile()
            {
                FirstName = "verylongfirstnamethatshouldnotworkherelikeseriouslywhohassuchalongname??",
                LastName = Doe,
                Age = Age23,
                PhoneNumber = PhoneNumberSample,
                Address = SomeStreetAddress,
            };
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessLogicException), "First name length must be between 2 and 30")]
        public void FirstNameMinLengthTest()
        {
            var aProfile = new Profile()
            {
                FirstName = "",
                LastName = Doe,
                Age = Age23,
                PhoneNumber = PhoneNumberSample,
                Address = SomeStreetAddress,
            };
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "First name cannot be null")]
        public void FirstNameNotNullTest()
        {
            var aProfile = new Profile()
            {
                FirstName = null,
                LastName = Doe,
                Age = Age23,
                PhoneNumber = PhoneNumberSample,
                Address = SomeStreetAddress,
            };
        }

    }
}
