using System.ComponentModel.DataAnnotations.Schema;

namespace MVCPRO.Models
{
	public class CourseResult
	{
		public int id { get; set; }
		public int degree { get; set; }

		[ForeignKey("course")]
		public int crs_id { get; set; }
		public virtual Course course{ get; set; }

		[ForeignKey("trainee")]
		public int trainee_id { get; set; }
		public virtual Trainee trainee { get; set; }
	}
}
