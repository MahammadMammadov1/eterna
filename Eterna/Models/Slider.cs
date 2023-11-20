using System.ComponentModel.DataAnnotations;

namespace Eterna.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [StringLength(maximumLength: 50)]
        [Required]
        public string Title { get; set; }
        [StringLength(maximumLength: 255)]
        [Required]
        public string Desccription { get; set; }
        public string ImageUrl { get; set; }
        public string RedirectUrl { get; set; }
    }
}
