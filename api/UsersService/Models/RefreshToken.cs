using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UsersService.Models
{
    public class RefreshToken {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public string? IP { get; set; }
        public bool Blocked { get; set; } = false;
        [Required]
        public DateTime ExpiredAt { get; set; }
    }
}