using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRA_WebAPI.Models
{
    public class ChangePasswordRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
