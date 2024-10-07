using BaiKiemTra03_02.Data;
using BaiKiemTra03_02.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaiKiemTra03_02.Controllers
{
    public class BookController : Controller
    {
        private readonly ApplicationDbContext _db;
        public BookController(ApplicationDbContext db)
        {
            _db = db;


        }
        public IActionResult Index()
        {
            var book = _db.book.ToList();
            ViewBag.book = book;
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(book book)
        {
            if (ModelState.IsValid)
            {
                // Thêm thông tin vào bảng TheLoai
                _db.book.Add(book);
                // Lưu lại
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
   
        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var book = _db.book.Find(id);
            return View(book);
        }
        [HttpPost]
        public IActionResult Edit(book theloai)
        {
            if (ModelState.IsValid)
            {
                _db.book.Update(theloai);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Deleted(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var theloai = _db.book.Find(id);
            return View(theloai);
        }
        [HttpPost]
        public IActionResult DeletedConfirm(int id)
        {
            var theloai = _db.book.Find(id);
            if (theloai == null)
            {
                return NotFound();
            }
            _db.book.Remove(theloai);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult details(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var theloai = _db.book.Find(id);
            return View(theloai);
        }
        [HttpGet]
        public IActionResult Search(String search)
        {
            if (!string.IsNullOrEmpty(search))
            {
                var book = _db.book.Where(tl => tl.title
                .Contains(search)).ToList();
                ViewBag.Search = search;
                ViewBag.book = book;

            }
            else
            {
                var book = _db.book.ToList();
                ViewBag.book = book;
            }
            return View("Index");
        }

    }
}
