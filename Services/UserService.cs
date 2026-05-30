using RepositoryContracts;
using ServiceContracts;
using ServiceContracts.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public UserProfileResponse GetUserInformationById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
