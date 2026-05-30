using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceContracts.DTOs
{
    public class RegisterRequest
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Name { get; set; }
    }
}
