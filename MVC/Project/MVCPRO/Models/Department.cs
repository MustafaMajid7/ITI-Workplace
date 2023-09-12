using System.ComponentModel.DataAnnotations.Schema;

namespace MVCPRO.Models
{
	public class Department
	{
		public int id { get; set; }
		public string name { get; set; }
		public string? Manager { get; set; }

		public virtual List<Instructor> Instructors{ get;} = new List<Instructor>();
		public virtual List<Course> Courses{ get; } = new List<Course>();
		public virtual List<Trainee> Trainees { get; } = new List<Trainee>();


	}
}
