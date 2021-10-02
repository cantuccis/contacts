using System;
using BusinessLogic.Exceptions;

namespace BusinessLogic
{
    public class Profile : IEquatable<Profile>
    {
        public const int FirstNameMinLength = 2;
        public const int FirstNameMaxLength = 30;
        public const int LastNameMinLength = 2;
        public const int LastNameMaxLength = 60;
        public const int MaxPathLength = 260;

        private string firstName;
        private string lastName;
        private Uri picturePath;

        public Profile()
        {
        }

        public string FirstName
        {
            get => firstName;
            set
            {
                if (value?.Length < FirstNameMinLength || value?.Length > FirstNameMaxLength)
                {
                    throw new BusinessLogicException($"First name length must be between {FirstNameMinLength} and {FirstNameMaxLength}");
                }
                firstName = value ?? throw new ArgumentNullException("First name cannot be null");
            }
        }
        public string LastName
        {
            get => lastName;
            set
            {
                if (value?.Length < LastNameMinLength || value?.Length > LastNameMaxLength)
                {
                    throw new BusinessLogicException($"Last name length must be between {LastNameMinLength} and {LastNameMaxLength}");
                }
                lastName = value ?? throw new ArgumentNullException("Last name cannot be null");
            }
        }
        public int Age
        {
            get
            {
                DateTime now = DateTime.Now;
                DateTime actualYearBirthday = new DateTime(now.Year, Birthday.Month, Birthday.Day);
                int age = now.Year - Birthday.Year;
                if (now < actualYearBirthday)
                    age--;
                return age;
            }
        }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime Birthday { get; set; }
        public string PicturePath { 
            get => picturePath.OriginalString;
            set {
                if (value?.Length > MaxPathLength)
                {
                    throw new BusinessLogicException($"Profile picture path is too long. Maximum length is {MaxPathLength}");
                }
                picturePath = new Uri(value, UriKind.RelativeOrAbsolute);
            } 
        }

        public bool Equals(Profile other) => other != null && other.PhoneNumber.Equals(this.PhoneNumber);
    }
}