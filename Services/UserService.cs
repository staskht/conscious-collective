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
        public UserProfileResponse? GetUserInformationById(Guid id)
        {
            var user = _userRepository.GetUserById(id);

            if (user == null) 
            {
                return null;
            }

            var userResponse = new UserProfileResponse
            {
                Email = user.Email,
                Name = user.Name,
            };

            return userResponse;

        }
    }
}
