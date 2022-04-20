using CorrectifSecu_WEB_DAL.Entities;
using System.ComponentModel.DataAnnotations;

namespace CorrectifSecu_WEB.Models
{
    public class LoginForm
    {
        [Required]
        [EmailAddress]
        [Display(Name ="Adresse Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name ="Mot de passe")]
        public string Password { get; set; }

    }
}
