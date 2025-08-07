using Microsoft.AspNetCore.Mvc;
using Project.Context;
using Project.Models;

namespace Project.Controllers
{
    public class CategoryController : Controller
    {
        MyContext db = new MyContext();

        [HttpGet]
        public IActionResult Index()
        {
            var categories = db.Categories;
            return View(categories);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var category = db.Categories.Find(id);
            if (category == null)
            {
                return RedirectToAction("Index");
            }
            return View(category);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            var ExistCateg = db.Categories.FirstOrDefault(c => c.Name == category.Name);
            if (ExistCateg != null)
            {
                ModelState.AddModelError("", "Category Already Exist");
                return View();
            }

            if (category != null && ModelState.IsValid)
            {
                db.Categories.Add(category);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var category = db.Categories.Find(id);
            if (category == null)
            {
                return RedirectToAction("Index");
            }
            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {

            if (category != null && ModelState.IsValid)
            {
                db.Categories.Update(category);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var dept = db.Categories.Find(id);
            if (dept == null)
            {
                return RedirectToAction("Index");
            }
            db.Categories.Remove(dept);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
