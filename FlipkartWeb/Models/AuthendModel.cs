using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace FlipkartWeb.Models
{
    public class AuthendModel
    {
        [ValidateNever]
        [Key]
        public int id { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Please Enter valid EmailID")]
        [Display(Name = "Email ID")]

        public string Emailid { get; set; }

        [Required]
        [DataType(DataType.Password)]

        public string Password { get; set; }


        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]

        public string ConfirmPassword { get; set; }
    }
}
