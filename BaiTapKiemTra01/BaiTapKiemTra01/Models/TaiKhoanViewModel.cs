using Microsoft.AspNetCore.Mvc;

namespace BaiTapKiemTra01.Models
{
    public class TaiKhoanViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public int Age { get; set; }
    }
}