using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MVCPRO.Models
{
	public class InstituteCTX : IdentityDbContext<AppUser>
	{
        public InstituteCTX() :base() 
        {}
		public InstituteCTX(DbContextOptions<InstituteCTX> options)
		   : base(options)
		{
			
		}
		public DbSet<Department> Departments{ get; set; }
        public DbSet<Trainee> Trainees{ get; set; }
        public DbSet<Instructor> Instructors{ get; set; }
        public DbSet<Course> Courses{ get; set; }
        public DbSet<CourseResult> CourseResults{ get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Data Source=MOSTAFAMAGED\\SQLEXPRESS;Initial Catalog=MVCPRO;Integrated Security=True;Encrypt=False");
		}
	}
}
