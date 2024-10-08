using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using projectA.Data;
using projectA.Models;
using System.Diagnostics;

namespace Project_a.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;
        
        public HomeController(ILogger<HomeController> logger,ApplicationDbContext db)
        {
            _logger = logger;
            _db= db;
        }

        public IActionResult Index()
        {
            IEnumerable<SanPhamViewModel>sanpham= _db.SanPham.Include(sp=>sp.TheLoai).ToList();

            return View(sanpham);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            SanPhamViewModel sanpham = new SanPhamViewModel();
             sanpham = _db.SanPham.Include(sanpham => sanpham.TheLoai).FirstOrDefault(s => s.Id == id);
            return View(sanpham);

        }
    }
}
