using Entities;
using RepositoryContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly List<User> _users = new();

        public IEnumerable<User> GetUsers()
        {
            return _users;
        }

        public User AddUser(User user)
        {
            _users.Add(user);
            return user;
        }

        public User? GetUserById(Guid? id)
        {
            return _users.FirstOrDefault(user => user.Id == id);
        }
    }
}
