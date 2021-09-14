using System;

namespace BusinessLogic
{
    public class Profile
    {
        public const int FirstNameMinLength = 2;
        public const int FirstNameMaxLength = 30;
        private string firstName;

        public Profile()
        {
        }

        public string FirstName { 
            get => firstName; 
            set { 
                if(value?.Length < FirstNameMinLength || value?.Length > FirstNameMaxLength)
                {
                    throw new BusinessLogicException("First name length must be between 2 and 30");
                }
                firstName = value ?? throw new ArgumentNullException("First name cannot be null");
            } 
        }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}