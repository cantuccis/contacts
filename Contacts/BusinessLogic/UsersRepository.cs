using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class UsersRepository
    {
        public UsersRepository()
        {
        }

        public int Count { get; }

        public void Add(User adminUser)
        {
            throw new NotImplementedException();
        }

        public bool Exists(string username)
        {
            throw new NotImplementedException();
        }

        public User Get(string username)
        {
            throw new NotImplementedException();
        }

        public void Update(User newPasswordAdmin)
        {
            throw new NotImplementedException();
        }

        public void Remove(string username)
        {
            throw new NotImplementedException();
        }

        public IList<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }
    }
}