using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class Book
    {
        private IList<Profile> profiles;
        public Book()
        {
            profiles = new List<Profile>();
        }

        public string Name { get; set; }

        public bool Contains(Profile someProfile)
        {
            return profiles.Contains(someProfile);
        }

        public void Add(Profile someProfile)
        {
            profiles.Add(someProfile);
        }

        public void Remove(Profile someProfile)
        {
            profiles.Remove(someProfile);
        }

        public IList<Profile> GetAllProfiles()
        {
            return new List<Profile>(profiles);
        }
    }
}