using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DrawIt.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Username is required.")]
        public string Email { get; set; }

        public string Username { get; set; }

        [StringLength(30, MinimumLength = 1, ErrorMessage = "Invalid")]
        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }
    }
}
