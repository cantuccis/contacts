using System;

namespace BusinessLogic
{
    public class CredentialsManager
    {
        public CredentialsManager(UsersRepository usersRepo, User admin)
        {
        }

        public bool IsLogged { get; set; }

        public void Login(User admin)
        {
            throw new NotImplementedException();
        }
    }
}