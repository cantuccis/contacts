using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLogic.Test
{
    [TestClass]
    public class ProfileTests
    {
        [TestMethod]
        public void NewProfile()
        {
            var aProfile = new Profile()
            {
                FirstName = "John",
                LastName = "Doe",
                Age = 23,
                PhoneNumber = "+59899999999",
                Address = "Somestreet 1111",
            };
            Assert.IsNotNull(aProfile);
        }
    }
}
