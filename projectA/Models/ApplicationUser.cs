using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace projectA.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string Ten { get; set; }
        public string DiaChi { get; set; }
    }
}
