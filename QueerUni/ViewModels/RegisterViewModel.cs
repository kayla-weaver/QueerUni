using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;
using System.Collections;

namespace QueerUni.ViewModels
{
 public class RegisterViewModel
 {
   [Required]
   [EmailAddress]
   [Display(Name = "Email Address")]
   public string Email { get; set; }


    [Required]
    [DataType(DataType.Password)]
    [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{6,}$", ErrorMessage = "Your password must contain at least six characters, a capital letter, a lowercase letter, a number, and a special character.")]
    public string Password { get; set; }

    public string Name{ get; set; }


   [Required]
   [DataType(DataType.Password)]
   [Display(Name = "Confirm password")]
   [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
   public string ConfirmPassword { get; set; }
   public bool Track1 { get; set; }
   public bool Track2 { get; set; }
   public bool Track3 { get; set; }
 }
}