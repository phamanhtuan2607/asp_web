using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaiKiemTra03_02.Models
{
    public class book
    {
        [Key]
        public int bookId { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public DateTime publiicationYear { get; set; }
        [Required]
        public string genre { get; set; }
        [Required]
        public int AuthorId { get; set; }
        [ForeignKey("AuthorId")]
        [ValidateNever]
        public Author Author { get; set; }
    }
}
