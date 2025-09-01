using assignment1.Models;
using assignment1.ViewModel;
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
        public IActionResult Add()
        {
            DepartmentCreateViewModel data = new DepartmentCreateViewModel
            {
                AllInstructors = context.instructors.ToList(),
                AllCourses = context.courses.ToList(),
                AllTrainees = context.trainees.ToList()
            };
            return View("Add",data);
        }
        public IActionResult Create(DepartmentCreateViewModel data)
        {
            if(data.Name == null || data.Manager == null || data.SelectedCourseIds==null || data.SelectedTraineeIds==null || data.SelectedInstructorIds==null)
            {
                
                return RedirectToAction("Add");
            }
            Department department = new Department
            {
                Name = data.Name,
                Manager = data.Manager,
                Instructors = context.instructors.Where(i => data.SelectedInstructorIds.Contains(i.Id)).ToList(),
                Courses = context.courses.Where(c => data.SelectedCourseIds.Contains(c.Id)).ToList(),
                Trainees = context.trainees.Where(t => data.SelectedTraineeIds.Contains(t.Id)).ToList()
            };
            context.departments.Add(department);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
