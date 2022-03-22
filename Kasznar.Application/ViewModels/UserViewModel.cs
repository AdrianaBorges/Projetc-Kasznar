using System;
using System.ComponentModel.DataAnnotations;

namespace Kasznar.Application.ViewModels
{
    public class UserViewModel
    {
        public Guid Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

    }
}
