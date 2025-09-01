namespace assignment1.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public decimal Salary { get; set; }

        public string address { get; set; }

        public int DepartmentId { get; set; }

        public int CourseId { get; set; }

        public Department Department { get; set; }
        public Course Course { get; set; }
    }
}
