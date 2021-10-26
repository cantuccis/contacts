using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLogic.Exceptions;

namespace BusinessLogic
{
    public class UsersRepository
    {

        private IList<User> collection;

        public UsersRepository()
        {
            collection = new List<User>();
        }

        public int Count { get => collection.Count; }

        public void Add(User user)
        {
            if (user is null)
                throw new ArgumentNullException(nameof(user));
            if (Exists(user.Username))
                throw new BusinessLogicException("User already exsists");
            
            collection.Add(user);
        }

        public bool Exists(string username)
        {
            return collection.Any(user => user.Username == username);
        }

        public User Get(string username)
        {
            if (!Exists(username))
                throw new BusinessLogicException("User does not exsist");
            return collection.First(user => user.Username == username);
        }

        public void Update(User user)
        {
            Remove(user.Username);
            Add(user);
        }

        public void Remove(string username)
        {
            collection = collection.Where(user => user.Username != username).ToList();
        }

        public IList<User> GetAll()
        {
            return new List<User>(collection); //return a copy, not the actual list!
        }

        public void Clear()
        {
            collection.Clear();
        }
    }
}