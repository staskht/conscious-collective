using Entities;
using ServiceContracts;
using ServiceContracts.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class InMemoryAuthService : IAuthService
    {
        private readonly List<User> _users = new();

        public string Login(LoginRequest request)
        {
            var user = _users.FirstOrDefault(u =>
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
            if (_users.Any(u => u.Email == request.Email))
            {
                return "User with this email already exists.";
            }

            var user = new User
            {
                Email = request.Email,
                Password = request.Password,
                Name = request.Name
            };

            _users.Add(user);

            return "User registered successfully.";
        }
    }
}
