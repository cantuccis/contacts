using System;

namespace BusinessLogic
{
    public class Profile
    {
        public const int FirstNameMinLength = 2;
        public const int FirstNameMaxLength = 30;
        public const int LastNameMinLength = 2;
        public const int LastNameMaxLength = 60;
        private string firstName;
        private string lastName;

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
        public string LastName { 
            get => lastName;
            set {
                if (value?.Length < LastNameMinLength || value?.Length > LastNameMaxLength)
                {
                    throw new BusinessLogicException($"Last name length must be between {LastNameMinLength} and {LastNameMaxLength}");
                }
                lastName = value ?? throw new ArgumentNullException("Last name cannot be null");
            } 
        }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}