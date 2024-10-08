﻿
using BaiTap07a.Data;
using BaiTap07a.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaiTap07a.Controllers
{
    public class TheLoaiController : Controller
    {
        private readonly ApplicationDbContext _db;
        public TheLoaiController(ApplicationDbContext db)
        {
            _db = db;
           

        }
        
        public IActionResult Index()
        {
            var theLoai = _db.TheLoai.ToList();
            ViewBag.TheLoai = theLoai;
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(TheLoai theloai)
        {
            if (ModelState.IsValid)
            {
                // Thêm thông tin vào bảng TheLoai
                _db.TheLoai.Add(theloai);
                // Lưu lại
                _db.SaveChanges();
                return RedirectToAction("Index");
            }return View();
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var theloai = _db.TheLoai.Find(id);
            return View(theloai);
        }
        [HttpPost]
        public IActionResult Edit(TheLoai theloai)
        {
            if (ModelState.IsValid)
            {
                // Thêm thông tin vào bảng TheLoai
                _db.TheLoai.Update(theloai);
                // Lưu lại
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var theloai = _db.TheLoai.Find(id);
            return View(theloai);
        }

        [HttpPost]
        public IActionResult DeleteConfirm(int id)
        {
            var theloai = _db.TheLoai.Find(id);
            if (theloai == null)
            {
                return NotFound();
            }
            _db.TheLoai.Remove(theloai);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Detail(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var theloai = _db.TheLoai.Find(id);
            return View(theloai);
        }
        [HttpGet]
        public IActionResult Search(string searchString)
        {
            if (!string.IsNullOrEmpty(searchString))
            {
              //Sử dụng LINQ để tìm kiếm
              var theloai = _db.TheLoai.Where(tl => tl.Name.Contains(searchString)).ToList();

                ViewBag.TheLoai = theloai;
            }
            else
            {
                var theLoai = _db.TheLoai.ToList();
                ViewBag.TheLoai = theLoai;
               
            }
            return View("Index"); // Sử dụng lại view Index

        }
    }
}