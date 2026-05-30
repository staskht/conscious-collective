using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class User
    {
        public Guid Id { get; private set; } = new Guid();
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Name { get; set; }
    }
}
