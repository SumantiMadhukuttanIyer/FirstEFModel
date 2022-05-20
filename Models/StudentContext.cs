using System.Data.Entity;
 
namespace FirstEFModel.Models
{ 
    public class StudentContext : DbContext
    {
        public StudentContext() : base("StudentDatabase")
        {
        }
        public DbSet<Student> Students { get; set; }
    }
}