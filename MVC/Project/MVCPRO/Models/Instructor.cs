using System.ComponentModel.DataAnnotations.Schema;

namespace MVCPRO.Models
{
	public class Instructor
	{
		public int id { get; set; }
		public string name { get; set; }
		public string? img { get; set; }
		public float? salary { get; set; }
		public string? address { get; set; }

		[ForeignKey("department")]
		public int dept_id { get; set; }
		public virtual Department department { get; set; }

		[ForeignKey("course")]
		public int crs_id { get; set; }
		public virtual Course course { get; set; }
	}
}
