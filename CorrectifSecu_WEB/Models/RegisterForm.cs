using CorrectifSecu_WEB_DAL.Entities;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace CorrectifSecu_WEB.Models
{
    public class RegisterForm
    {
        
        [Required]
        [EmailAddress]
        [Display(Name = "Adresse Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Mot de passe")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Répétez mot de passe")]
        [Compare(nameof(Password), ErrorMessage = "Les deux champs doivent correspondre")]
        public string ConfirmPassword { get; set; }

        [Required, Display(Name = "Pseudonyme")]
        public string Nickname { get; set; }
        [ValidateNever]
        public IEnumerable<Beer> selectBeers { get; set; }
        public IEnumerable<int> FavoriteBeer { get; set; }
        
    }
}
