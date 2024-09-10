using Microsoft.AspNetCore.Mvc;
using BaiTapKiemTra01.Models;

namespace BaiTapKiemTra01.Controllers
{
    public class SanPhamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BaiTap2()
        {
            var sanpham = new SanPhamViewModel()
            {
                TenSanPham = "Áo Thun Nam",
                GiaBan = 200000,// Giá bán
                AnhMoTa = "~/images/aothun.jpg", // Đường dẫn đến ảnh mô tả
            };  
            return View(sanpham);
        }
    }
}
