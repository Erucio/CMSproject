using System.ComponentModel.DataAnnotations;

namespace CMSProject.Models
{
    public class ContactForm
    {
        [Required(ErrorMessage = "Please enter your name.")]
        [StringLength(50, ErrorMessage = "Name should be no more than 50 characters.")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Please enter your email address.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Please enter your message.")]
        public string Message { get; set; } = null!;
        public string? RedirectUrl { get; set; } = "/contact";
    }
}
