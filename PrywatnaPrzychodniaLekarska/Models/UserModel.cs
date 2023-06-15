using System.ComponentModel.DataAnnotations;

namespace SavingApiMenager.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(20)]
        public string LastName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
        [MaxLength(7)]
        public string Role { get; set; }
    }
}
