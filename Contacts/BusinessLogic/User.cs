using System;

namespace BusinessLogic
{
    public class User
    {
        public User()
        {
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }

        public User DeepClone()
        {
            return new User()
            {
                Username = this.Username,
                Password = this.Password,
                IsAdmin = this.IsAdmin
            };
        }
    }
}