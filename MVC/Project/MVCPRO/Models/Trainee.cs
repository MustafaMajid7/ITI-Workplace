using System.ComponentModel.DataAnnotations.Schema;

namespace MVCPRO.Models
{
	public class Trainee
	{
		public int id { get; set; }
		public string name { get; set; }
		public string? img { get; set; }
		public string? address { get; set; }
		public int? grade { get; set; }

		[ForeignKey("department")]
		public int dept_id { get; set; }
		public virtual Department department { get; set; }
	}
}
