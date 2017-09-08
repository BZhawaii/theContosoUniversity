using theContosoUniversity.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace theContosoUniversity.DAL
{
    public class SchoolContext : DbContext
    {

        public SchoolContext() : base("SchoolContext")
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public System.Data.Entity.DbSet<theContosoUniversity.Models.Department> Departments { get; set; }

        public System.Data.Entity.DbSet<theContosoUniversity.Models.Instructor> Instructors { get; set; }

        public System.Data.Entity.DbSet<theContosoUniversity.Models.OfficeAssignment> OfficeAssignments { get; set; }
    }
}