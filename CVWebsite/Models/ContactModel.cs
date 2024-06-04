using System.ComponentModel.DataAnnotations;

namespace CVWebsite.Models
{
    public class ContactModel
    {
        [Required, Display(Name = "Name")]
        public string SenderName { get; set; } = null!;

        [Required, Display(Name = "Email")]
        public string SenderEmail { get; set; } = null!;

        [Required]
        public string Subject { get; set; } = null!;

        [Required]
        public string Message { get; set; } = null!;
    }
}
