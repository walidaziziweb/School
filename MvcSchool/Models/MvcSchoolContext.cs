using Microsoft.EntityFrameworkCore;

namespace MvcSchool.Models
{
    public class MvcSchoolContext : DbContext
    {

        public MvcSchoolContext(DbContextOptions<MvcSchoolContext> options)
            :base(options) 
            {
            
            }
        public DbSet<Student> Students { get; set; } = default!;
        public DbSet<Course> Courses { get; set; } = default!;

    }
}
