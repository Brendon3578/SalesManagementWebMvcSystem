using Microsoft.AspNetCore.Mvc;

namespace SalesManagementWebMvcSystem.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
