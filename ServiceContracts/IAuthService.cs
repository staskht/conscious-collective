using ServiceContracts.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceContracts
{
    public interface IAuthService
    {
        bool Register(RegisterRequest request);
        Guid? Login(LoginRequest request);
    }
}
