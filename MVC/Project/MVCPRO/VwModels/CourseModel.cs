using MVCPRO.Models;

namespace MVCPRO.VwModels
{
	public class CourseModel
	{
        public string name { get; set; }
        public float degree { get; set; }
        public float mindegree { get; set; }
        public int depID { get; set; }
        public List<Department>? departments { get; set; }
    }
}
