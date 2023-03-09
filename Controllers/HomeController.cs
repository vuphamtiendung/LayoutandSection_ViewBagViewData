using Microsoft.AspNetCore.Mvc;
using MVCLayout_003.Models;

namespace MVCLayout_003.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Greeting"] = "Hello word";
            ViewBag.Products = new ProductModel()
            {
                Id = 1,
                Name = "Product 1",
                Brand = "TEDU",
                Price = 500000
            };
            return View();
        }
    }
}
