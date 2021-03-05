using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CS_Bank_Accounts.Models
{
    public class LoginUser
    {

        [Required]
        [Display(Name = "Email:")]
        [EmailAddress]
        public string LoginEmail { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Password:")]

        [Required]
        public string LoginPassword { get; set; }

    }
}