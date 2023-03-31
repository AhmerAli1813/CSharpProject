using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyWebAppDemo.Models
{
    public class userModel
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Username { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }

    }
}
