using System.ComponentModel.DataAnnotations.Schema;

namespace MVCPRO.Models
{
	public class Course
	{
        public int id { get; set; }
        public string name { get; set; }
        public float degree { get; set; }
		public float? Mindegree { get; set; }

        [ForeignKey("department")]
        public int dept_id { get; set; }
        public virtual Department department { get; set; }
    }
}
