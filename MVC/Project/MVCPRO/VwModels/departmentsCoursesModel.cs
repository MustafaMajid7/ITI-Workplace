using MVCPRO.Models;

namespace MVCPRO.VwModels
{
	public class departmentsCoursesModel
	{
		public Instructor Instructor { get; set; }
        public Dictionary<string,int> courses { get; set; } = new Dictionary<string,int>();
		public Dictionary<string, int> departments { get; set; } = new Dictionary<string, int>();

	}
}
