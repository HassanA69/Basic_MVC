﻿namespace assignment1.Models
{
    public class Trainee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Address { get; set; }
       
        public int Grade { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public List<CourseResult> CourseResults { get; set; }

    }
}
