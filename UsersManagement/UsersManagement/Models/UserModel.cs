using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UsersManagement.Models
{
    public class UserModel
    {
        public string Cognome { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }
    }
}