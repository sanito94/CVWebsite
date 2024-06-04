using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CVWebsite.Data.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        [Required, Display(Name = "Email")]
        public string SenderEmail { get; set; } = null!;

        [Required, Display(Name = "Name")]
        public string SenderName { get; set; } = null!;

        [Required]
        public string Subject { get; set; } = null!;

        [Required]
        public string Message { get; set; } = null!;

        [Required]
        public DateTime Date { get; set; }

    }
}
