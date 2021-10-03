using System;
using System.Security.Cryptography;
using BusinessLogic.Exceptions;

namespace BusinessLogic
{
    public class CredentialsManager
    {
        private const int SaltSize = 16;
        private const int HashSize = 20;

        private readonly UsersRepository usersRepo;
        private User UserLogged { get; set; }
        public CredentialsManager(UsersRepository usersRepo, User admin)
        {
            this.usersRepo = usersRepo;
            SaveUser(admin);
        }

        public bool IsLogged { get; private set; }

        public void Login(Credentials userCredentials)
        {
            if (!usersRepo.Exists(userCredentials.Username))
                throw new BusinessLogicException("Invalid username or password");

            User storedUser = usersRepo.Get(userCredentials.Username);
            IsLogged = storedUser.Password == Hash(userCredentials.Password);
            UserLogged = IsLogged ? storedUser : throw new BusinessLogicException("Invalid username or password");
        }

        public void Register(User user)
        {
            if (!IsLogged)
                throw new BusinessLogicException("Not logged in");
            if (!UserLogged.IsAdmin)
                throw new BusinessLogicException("Insufficient permissions");
            SaveUser(user);
        }

        public void Logout() => IsLogged = false;

        private void SaveUser(User user)
        {
            User newUser = user.DeepClone();
            newUser.Password = Hash(user.Password);
            usersRepo.Add(newUser);
        }

        private string Hash(string password, int iterations = 1000)
        {
            byte[] salt = new byte[SaltSize]; // we will use empty salt arrays for simplicity
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations);
            var hash = pbkdf2.GetBytes(HashSize);
            var hashedBase46String = Convert.ToBase64String(hash);

            return hashedBase46String;
        }
    }
}