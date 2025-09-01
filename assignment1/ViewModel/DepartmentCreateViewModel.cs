using assignment1.Models;

namespace assignment1.ViewModel
{
    public class DepartmentCreateViewModel
    {

        public string Name { get; set; }
        public string Manager { get; set; }

       
        public List<int> SelectedInstructorIds { get; set; }
        public List<int> SelectedCourseIds { get; set; }
        public List<int> SelectedTraineeIds { get; set; }


        public List<Instructor> AllInstructors { get; set; }
        public List<Course> AllCourses { get; set; }
        public List<Trainee> AllTrainees { get; set; }
    }
}
