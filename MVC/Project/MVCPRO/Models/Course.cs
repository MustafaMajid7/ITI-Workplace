using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCPRO.Models
{
	public class Course
	{

        [Display(Name ="Course Number")]
		public int id { get; set; }
		
        [Display(Name = "Course Name")]
		public string name { get; set; }

        [Display(Name ="Marks")]
        [DataType(DataType.Currency)]
        public float degree { get; set; }

		[Display(Name = "Minimum Required Marks for Success")]
		[DataType(DataType.Currency)]
		public float? Mindegree { get; set; }

        [ForeignKey("department")]
		[Display(Name = "Department Name")]
		public int dept_id { get; set; }
        public virtual Department department { get; set; }
    }
}
