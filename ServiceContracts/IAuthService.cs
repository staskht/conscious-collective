using ServiceContracts.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceContracts
{
    public interface IAuthService
    {
        string Register(RegisterRequest request);
        string Login(LoginRequest request);
    }
}
