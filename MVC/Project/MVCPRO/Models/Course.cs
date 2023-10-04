using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace MVCPRO.Models
{
	public class Course
	{

        [Display(Name ="Course Number")]
		public int id { get; set; }
		
        [Display(Name = "Course Name")]
		[Required]
		[MinLength(length:5, ErrorMessage = "Name Charcaters must be in range between 5 to 20 ")]
		[MaxLength(length:20, ErrorMessage = "Name Charcaters must be in range between 5 to 20 ")]
        [Custom(ErrorMessage = "Name is already taken before")]
        public string? name { get; set; }

        [Display(Name ="Full Marks")]
        [DataType(DataType.Currency)]
		[Range(minimum:50,maximum:100,ErrorMessage ="degree must be in range between 50 to 100 ")]
        public float degree { get; set; }

		[Display(Name = "Minimum Required Marks for Success")]
		[DataType(DataType.Currency)]
		[Remote(action: "checkMinDegree", controller: "Course",AdditionalFields ="mindegree,degree",ErrorMessage ="Minimum Degree must be less than Full Degree")]
		public float? Mindegree { get; set; }

        [ForeignKey("department")]
		[Display(Name = "Department Name")]
		public int dept_id { get; set; }
		public virtual Department? department { get; set; }
	}
}
