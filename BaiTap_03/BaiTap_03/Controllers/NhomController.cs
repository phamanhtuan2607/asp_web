using Microsoft.AspNetCore.Mvc;

namespace BaiTap_03.Controllers
{
    public class NhomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
