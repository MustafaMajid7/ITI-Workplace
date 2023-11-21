using System.ComponentModel.DataAnnotations;

namespace Day1
{
	public class CourseDto
	{
		[Required]
		[StringLength(25, MinimumLength = 5, ErrorMessage = "name must be in range between 5 and 25 chars")]
		public string Cname { get; set; }

		[Required]
		[Range(10, 50, ErrorMessage = "duration must be in between 10 and 50")]
		public int Duration { get; set; }
	}
}