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
    }
}
