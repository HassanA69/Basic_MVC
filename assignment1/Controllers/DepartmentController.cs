using assignment1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace assignment1.Controllers
{
    public class DepartmentController : Controller
    {
        AppDbContext context = new AppDbContext();
        public IActionResult Index()
        {
            List<Department> departments = context
                                         .departments
                                         .Include(d => d.Instructors)
                                         .ToList();
            return View("Index", departments);

        }
        
    }
}
