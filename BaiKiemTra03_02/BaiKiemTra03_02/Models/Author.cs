using System.ComponentModel.DataAnnotations;

namespace BaiKiemTra03_02.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        [Required]
        public string authorName { get; set; }
        [Required]
        public string nationality { get; set; }
        [Required]
        public DateTime brirthYear { get; set; }
    }
}
