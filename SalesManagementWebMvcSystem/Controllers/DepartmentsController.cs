using Microsoft.AspNetCore.Mvc;
using SalesManagementWebMvcSystem.Models;

namespace SalesManagementWebMvcSystem.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = [
                new Department { Id = 1, Name = "Fashion" },
                new Department { Id = 2, Name = "Eletronics" }
            ];

            return View(list);
        }
    }
}
