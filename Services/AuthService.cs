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
        public string Login(LoginRequest request)
        {
            var user = _userRepository.GetUsers().FirstOrDefault(u =>
            u.Email == request.Email &&
            u.Password == request.Password);

            if (user == null)
            {
                return "Invalid email or password.";
            }

            return $"Welcome back, {user.Name}.";
        }

        public string Register(RegisterRequest request)
        {
            if (_userRepository.GetUsers().Any(u => u.Email == request.Email))
            {
                return "User with this email already exists.";
            }

            var user = new User
            {
                Email = request.Email,
                Password = request.Password,
                Name = request.Name
            };

            _userRepository.AddUser(user);

            return "User registered successfully.";
        }
    }
}
