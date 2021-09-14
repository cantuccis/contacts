using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLogic.Test
{
    [TestClass]
    public class ProfileTests
    {
        private const string John = "John";
        private const string Doe = "Doe";
        private readonly DateTime Oct7th1997 = new DateTime(1997, 10, 7);
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
                Birthday = Oct7th1997,
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

        [TestMethod]
        public void GetAgeTest()
        {
            //Arrange
            DateTime now = DateTime.Now;
            int actualYear = now.Year;
            int johnBirthYear = johnDoeProfile.Birthday.Year;
            int expectedAge = actualYear - johnBirthYear;
            DateTime johnBirthdayThisYear = new DateTime(actualYear, johnDoeProfile.Birthday.Month, johnDoeProfile.Birthday.Day);
            if (now <= johnBirthdayThisYear)
                expectedAge--;

            //Act
            int actualAge = johnDoeProfile.Age;

            //Assert
            Assert.AreEqual(expectedAge, actualAge);
        }

        [TestMethod]
        public void BirthdayAgeTest()
        {
            //Arrange
            int expectedAge = 24;
            DateTime now = DateTime.Now;
            johnDoeProfile.Birthday = new DateTime(now.Year - expectedAge, now.Month, now.Day);

            //Act
            int actualAge = johnDoeProfile.Age;

            //Assert
            Assert.AreEqual(expectedAge, actualAge);
        }
    }
}
