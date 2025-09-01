using assignment1.Models;
using assignment1.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace assignment1.Controllers
{
    public class InstructorController : Controller
    {
        public IActionResult Index()
        {
            AppDbContext context = new AppDbContext();
            var instructors = context.instructors
                .Include(x => x.Course)
                .Include(x => x.Department)
                .ToList();
            return View("Index", instructors);
        }

        public IActionResult Details(int id)
        {
            
            AppDbContext context = new AppDbContext();
            var query = context.instructors
                .Include(x => x.Course)
                .Include(x => x.Department)
                .FirstOrDefault(x => x.Id == id);
            
            var instructor = new InstructorcustomData();

            if (query == null)
            {
                return Content("NO Found");
            }

            instructor.InsturctorId = query.Id;
            instructor.InsturctorName = query.Name;
            instructor.InsturctorImageUrl = query.ImageUrl;
            instructor.InsturctorSalary = query.Salary;
            instructor.InsturctorAddress = query.address;
            instructor.DepartmentName = query.Department.Name;
            instructor.CourseName = query.Course.Name;
            

            return View("Details", instructor);
        }

    }
}
 
