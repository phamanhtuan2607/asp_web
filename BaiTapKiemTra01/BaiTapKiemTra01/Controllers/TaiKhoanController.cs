using Microsoft.AspNetCore.Mvc;
using BaiTapKiemTra01.Models;
using System.Reflection;

namespace BaiTapKiemTra01.Controllers
{
    public class TaiKhoanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //public IActionResult DangKy(TaiKhoanViewModel taikhoan)
        //{
        //    if (taikhoan != null && taikhoan.Password != null && (taikhoan.Password).Length > 0)
        //    {
        //        taikhoan.Password = taikhoan.Password + "_chuoi_ma_hoa";
        //    }        return View(taikhoan);

        //}
        public IActionResult DangKy(TaiKhoanViewModel model)
        {
            if (model.Username != null)
            {
                return Content(model.Username);

            }
            return View(model);
        }
    }
}