using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MbaApp.Mvc.Controllers
{
    public class ProductController : Controller
    {
        // Mock list of products for display
        private readonly List<Product> _products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 1500 },
            new Product { Id = 2, Name = "Smartphone", Price = 800 },
            new Product { Id = 3, Name = "Headphones", Price = 100 }
        };

        // Action to display the list of products (returns ViewResult)
        public IActionResult Index()
        {
            ViewBag.Title = "Product Catalog";
            ViewBag.TotalProducts = _products.Count;
            ViewData["Message"] = "Welcome to the Product Catalog!";
            return View(_products);
        }

        // Action to display details of a single product (returns ViewResult or NotFoundResult)
        public IActionResult Details(int id)
        {
            var product = _products.Find(p => p.Id == id);
            if (product == null)
            {
                return NotFound(); // Returns a 404 status
            }
            return View(product);
        }

        // Action to return JSON data (returns JsonResult)
        public IActionResult GetProductJson(int id)
        {
            var product = _products.Find(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Json(product);
        }

        // Action to redirect to another page (returns RedirectToActionResult)
        public IActionResult RedirectToIndex()
        {
            return RedirectToAction("Index", "Product");
        }

        // Action to return a simple string (returns ContentResult)
        public IActionResult WelcomeMessage()
        {
            return Content("Welcome to the Product API!");
        }
    }

    // Product class to define the structure of a product
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}