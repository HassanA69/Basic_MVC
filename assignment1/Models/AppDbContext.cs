using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace assignment1.Models
{
    public class AppDbContext : DbContext
    {
      public  DbSet<Department> departments { get; set; }
      public  DbSet<Trainee> trainees { get; set; }
      public  DbSet<Course> courses { get; set; }
      public  DbSet<CourseResult> couseResults { get; set; }
       
      public  DbSet<Instructor> instructors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("Models\\appsetting.json")
                .Build();

            var constr = config.GetSection("constr").Value;
            optionsBuilder.UseSqlServer(constr);
            base.OnConfiguring(optionsBuilder);

        }

    }
}
