using System;
using System.Collections.Generic;
using System.Linq;

namespace DotNetGraphQl
{
    public class UserRepository
    {
        private readonly List<User> _users = new List<User>();

        public UserRepository()
        {
            UserSeed();
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _users.AsEnumerable();
        }

        public User GetUserById(Guid id)
        {
            return _users.Where(u => u.Id == id).FirstOrDefault();
        }

        private void UserSeed()
        {
            for (int i = 0; i < 100; i++)
            {
                _users.Add(new User
                {
                    Name = $"UserName_{i}",
                    Email = $"user_{i}@gmail.com",
                    LoginName = $"lg_{i}_user"
                });
            }
        }
    }
}