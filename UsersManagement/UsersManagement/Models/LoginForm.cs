using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace UsersManagement.Models
{
    public class LoginForm
    {

        [Required(ErrorMessage="Please enter username!")]
        public string Username { get; set; }

        [Required(ErrorMessage="Please enter password!")]
        public string Password { get; set; }

    }
}