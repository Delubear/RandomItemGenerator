using Microsoft.AspNetCore.Mvc;

namespace MVCItemGen.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
            //return RedirectToAction("List", "Item");
        }      
    }
}