using Day1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day1.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult ShowProducts()
        {
            return View("VProducts",new sampleProducts().getAllProducts());
        }
        public IActionResult detailedProduct(int id) 
        {
            return View("productDetails", new sampleProducts()
                .getAllProducts().Where(x=>x.id==id).FirstOrDefault());
        }
    }
}
