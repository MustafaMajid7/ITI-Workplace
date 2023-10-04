using MVCPRO.Models;

namespace MVCPRO.Repository.CourseRepository
{
	public interface ICourseRepository
	{
		List<Course> GetAll();
		List<Course> GetcoursesbydeptID(int deptID);

		Course GetByCourseId(int courseId);
		void Insert(Course course);
		void Update(Course course);
		void Delete(int ID);
		int Save();
	}
}
