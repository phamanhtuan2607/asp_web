﻿using BaiKiemTra02.Data;
using BaiKiemTra02.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaiKiemTra02.Controllers
{
    public class LopHocController : Controller
    {
        private readonly ApplicationDbContext _db;
        public LopHocController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var lophoc = _db.LopHoc.ToList();
            ViewBag.LopHoc = lophoc;
            return View(lophoc);
         
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(LopHoc lophoc)
        {
            if (ModelState.IsValid)
            {
                // Thêm thông tin vào bảng TheLoai
                _db.LopHoc.Add(lophoc);
                // Lưu lại
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var lophoc = _db.LopHoc.Find(id);
            return View(lophoc);
        }
        [HttpPost]
        public IActionResult Edit(LopHoc lophoc)
        {
            if (ModelState.IsValid)
            {
                // Thêm thông tin vào bảng TheLoai
                _db.LopHoc.Update(lophoc);
                // Lưu lại
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Delete()
        {
            return View();
        }
        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var lophoc = _db.LopHoc.Find(id);
            return View(lophoc);
        }

        [HttpPost]
        public IActionResult DeleteConfirm(int id)
        {
            var lophoc = _db.LopHoc.Find(id);
            if (lophoc == null)
            {
                return NotFound();
            }
            _db.LopHoc.Remove(lophoc);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Search()
        {
            return View();
        }
        public IActionResult Search(string searchString)
        {
            if (!string.IsNullOrEmpty(searchString))
            {
                //Sử dụng LINQ để tìm kiếm
                var lophoc = _db.LopHoc.Where(lh => lh.TenLopHoc.Contains(searchString)).ToList();

                ViewBag.LopHoc = lophoc;
            }
            else
            {
                var lophoc = _db.LopHoc.ToList();
                ViewBag.TheLoai = lophoc;

            }
            return View("Index"); // Sử dụng lại view Index

        }
    }
}
