using System.Data.Entity;

namespace CreateDatabaseApp
{
    public class StudentContext: DbContext
    {
        public StudentContext(): base("Students")
        {

        }
        public DbSet<Student> Students { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {            
            modelBuilder.Entity<Student>().ToTable("Students");
        }
    }
}
