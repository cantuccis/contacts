using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLogic.Test
{
    [TestClass]
    public class BookTests
    {
        private readonly string[] Names = new string[] { "John", "Johny", "Rob", "Bob", "Jessica", "Mike" };
        private readonly string[] Surnames = new string[] { "Doe", "Goodman", "McClaw", "White" };
        private readonly DateTime[] Dates = new DateTime[] { new DateTime(1997, 10, 7), new DateTime(1999, 9, 9) };
        private const string SomeStreetAddress = "SomeStreet 1111";
        private const string PicturePathSample = @"Resources\test-image.jpg";
        private const string SomeBookName = "Somebook";
        private readonly Random rand = new Random();

        private IList<Profile> profiles;

        private Book book;


        [TestInitialize]
        public void Initialize()
        {
            book = new Book();
            profiles = new List<Profile>();
            for (int i = 0; i < 20; i++)
            {
                var newProfile = GenerateRandomProfile();
                if (!profiles.Contains(newProfile))
                    profiles.Add(newProfile);
            }

        }

        private Profile GenerateRandomProfile()
        {
            var rand = new Random();
            return new Profile()
            {
                FirstName = Names[rand.Next(Names.Length)],
                LastName = Surnames[rand.Next(Surnames.Length)],
                Birthday = Dates[rand.Next(Dates.Length)],
                PhoneNumber = $"+598{rand.Next(91000000, 99999999)}",
                Address = SomeStreetAddress,
                PicturePath = PicturePathSample
            };
        }

        private Profile GetRandomProfile()
        {
            return profiles?[rand.Next(profiles.Count)];

        }

        [TestMethod]
        public void NewBookTest()
        {
            var book = new Book();
            Assert.IsNotNull(book);
        }

        [TestMethod]
        public void SetBookNameTest()
        {
            book.Name = SomeBookName;
            Assert.AreEqual(SomeBookName, book.Name);
        }

        [TestMethod]
        public void ContainsProfileTest()
        {
            var someProfile = GetRandomProfile();

            Assert.IsFalse(book.Contains(someProfile));
        }

        [TestMethod]
        public void AddProfileTest()
        {
            var book = new Book()
            {
                Name = SomeBookName,
            };

            var someProfile = GetRandomProfile();

            book.Add(someProfile);

            Assert.IsTrue(book.Contains(someProfile));
        }

        [TestMethod]
        public void RemoveProfileTest()
        {
            var someProfile = GetRandomProfile();

            book.Add(someProfile);
            book.Remove(someProfile);

            Assert.IsFalse(book.Contains(someProfile));
        }

        [TestMethod]
        public void GetAllProfilesTest()
        {
            foreach (var profile in profiles)
            {
                book.Add(profile);
            }

            IList<Profile> returnedProfiles = book.GetAllProfiles();

            foreach (var profile in profiles)
            {
                Assert.IsTrue(
                    returnedProfiles.Contains(profile),
                    $"Profile {profile.PhoneNumber} was not find in book {book.Name}");
            }

        }





    }
}
