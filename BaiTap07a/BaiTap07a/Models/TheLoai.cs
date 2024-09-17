﻿using System.ComponentModel.DataAnnotations;

namespace BaiTap07a.Models
{
    public class TheLoai
    {
        [Key]
        public int? Id { get; set; }

        [Required(ErrorMessage = "Không được để trống Tên thể loại!")]
        [Display(Name = "Thể loại")]
        [StringLength(10, ErrorMessage = "{0} phải có độ dài phải từ {2} đến {1} ký tự.", MinimumLength = 8)]
        public string? Name { get; set; }
        
        
        
        [Display(Name = "Ngày tạo")]
        [Required(ErrorMessage = "Không đúng định dạng ngày!")]
        public DateTime? DateCreated { get; set; } = DateTime.Now;
        
    } 
}
