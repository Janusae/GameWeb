using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MyTestProject.ClassesEntity
{
    public class IndexPagesInformation
    {
        public int Id { get; set; }
        public string Context1_h6 { get; set; }
        public string Context_Header { get; set; }
        public string Context1_p { get; set; }
        public string TopImage { get; set; }
        public string CopyriteText { get; set; }
        public string DesignText { get; set; }
        public bool HasOffer { get; set; }
        public int Price { get; set; }
        public int Offer { get; set; }

    }

    public class MembersBaseInfo
    {
        [Key]
        public int UserId { get; set; }

        [MinLength(2, ErrorMessage = "First name must be at least 2 characters long.")]
        [MaxLength(50, ErrorMessage = "First name cannot exceed 50 characters.")]
        [Required(ErrorMessage = "First name is required.")]
        public required string FirstName { get; set; }

        [MinLength(2, ErrorMessage = "Last name must be at least 2 characters long.")]
        [MaxLength(50, ErrorMessage = "Last name cannot exceed 50 characters.")]
        [Required(ErrorMessage = "Last name is required.")]
        public required string LastName { get; set; }

        [MinLength(2, ErrorMessage = "Username must be at least 2 characters long.")]
        [MaxLength(50, ErrorMessage = "Username cannot exceed 50 characters.")]
        [Required(ErrorMessage = "Username is required.")]

        public required string UserName { get; set; }

        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        [Required(ErrorMessage = "Email is required.")]
        public required string Email { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is required.")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters long.")]
        public required string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Your passwords do not match.")]
        [Required(ErrorMessage = "Please confirm your password.")]
        public required string ConfirmPassword { get; set; }
    }

}
