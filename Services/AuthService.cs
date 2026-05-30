using Entities;
using RepositoryContracts;
using ServiceContracts;
using ServiceContracts.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;
        public AuthService(IUserRepository userRepository) 
        {
            _userRepository = userRepository;
        }
        public Guid? Login(LoginRequest request)
        {
            var user = _userRepository.GetUsers().FirstOrDefault(u =>
            u.Email == request.Email &&
            u.Password == request.Password);

            if (user == null)
            {
                return null;
            }

            return user.Id;
        }

        public bool Register(RegisterRequest request)
        {
            if (_userRepository.GetUsers().Any(u => u.Email == request.Email))
            {
                return false;
            }

            var user = new User
            {
                Id = new Guid(),
                Email = request.Email,
                Password = request.Password,
                Name = request.Name
            };

            _userRepository.AddUser(user);

            return true;
        }
    }
}
