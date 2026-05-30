using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryContracts
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();

        User AddUser(User user);

        public User? GetUserById(Guid? id);
    }
}
