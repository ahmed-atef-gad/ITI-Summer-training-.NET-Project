using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Project.Context;
using Project.Models;

namespace Project.Controllers
{
    public class ProductController : Controller
    {
        MyContext db = new MyContext();

        [HttpGet]
        public IActionResult Index()
        {
            var products = db.Products.Include(p => p.Category);
            return View(products);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var product = db.Products.Include(s => s.Category).FirstOrDefault(p => p.ProductId == id);
            if (product == null)
            {
                return RedirectToAction("Index");
            }
            return View(product);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList(db.Categories, "CategoryId", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product, IFormFile imageFile)
        {

            ModelState.Remove("Category");
            ModelState.Remove("ImagePath");
            ModelState.Remove("imageFile");
            if (product != null && ModelState.IsValid)
            {
                if (imageFile != null && imageFile.Length > 0)
                {
                    var fileName = Path.GetFileNameWithoutExtension(imageFile.FileName)
                        + "_" + DateTime.Now.ToString("yyyyMMddHHmmssfff")
                        + Path.GetExtension(imageFile.FileName);
                    var imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Images", fileName);
                    using (var stream = new FileStream(imagePath, FileMode.Create))
                    {
                        imageFile.CopyTo(stream);
                    }
                    product.ImagePath = "/Images/" + fileName;
                }
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Categories = new SelectList(db.Categories, "CategoryId", "Name");
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var product = db.Products.Include(s => s.Category).FirstOrDefault(p => p.ProductId == id);
            if (product == null)
            {
                return RedirectToAction("Index");
            }
            ViewBag.Categories = new SelectList(db.Categories, "CategoryId", "Name");
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product product, IFormFile imageFile)
        {

            ModelState.Remove("Category");
            ModelState.Remove("ImagePath");
            ModelState.Remove("imageFile");
            if (product != null && ModelState.IsValid)
            {
                if (imageFile != null && imageFile.Length > 0)
                {
                    var oldPath = db.Products.AsNoTracking()
                        .Where(p => p.ProductId == product.ProductId)
                        .Select(p => p.ImagePath)
                        .FirstOrDefault();
                    if (!string.IsNullOrEmpty(oldPath))
                    {
                        var oldImagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", oldPath.TrimStart('/'));
                        if (System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }
                    var fileName = Path.GetFileNameWithoutExtension(imageFile.FileName)
                        + "_" + DateTime.Now.ToString("yyyyMMddHHmmssfff")
                        + Path.GetExtension(imageFile.FileName);
                    var imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Images", fileName);
                    using (var stream = new FileStream(imagePath, FileMode.Create))
                    {
                        imageFile.CopyTo(stream);
                    }
                    product.ImagePath = "/Images/" + fileName;
                }
                else
                {
                    product.ImagePath = db.Products.AsNoTracking()
                        .Where(p => p.ProductId == product.ProductId)
                        .Select(p => p.ImagePath)
                        .FirstOrDefault();
                }
                db.Products.Update(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Categories = new SelectList(db.Categories, "CategoryId", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var product = db.Products.Find(id);
            if (product == null)
            {
                return RedirectToAction("Index");
            }
            if (!string.IsNullOrEmpty(product.ImagePath))
            {
                var imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", product.ImagePath.TrimStart('/'));
                if (System.IO.File.Exists(imagePath))
                {
                    System.IO.File.Delete(imagePath);
                }
            }
            db.Products.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
