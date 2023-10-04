using MVCPRO.Models;

namespace MVCPRO.Repository.CourseRepository
{
	public class CourseRepository : ICourseRepository
	{
		//private InstituteCTX instituteCTX = new InstituteCTX();
		private InstituteCTX instituteCTX ;
		public CourseRepository(InstituteCTX instituteCTX)
		{
			this.instituteCTX = instituteCTX;
		}
		public void Delete(int ID)
		{
			instituteCTX.Remove(GetByCourseId(ID));
		}

		public List<Course> GetAll()
		{
			return instituteCTX.Courses.ToList();
		}

		public Course GetByCourseId(int courseId)
		{
			return GetAll().FirstOrDefault(c=>c.id==courseId);
		}

		public List<Course> GetcoursesbydeptID(int deptID)
		{
			return instituteCTX.Courses.Where(c=>c.dept_id == deptID).ToList();
		}

		public void Insert(Course course)
		{
			instituteCTX.Add(course);
		}

		public int Save()
		{
			return instituteCTX.SaveChanges();
		}

		public void Update(Course course)
		{
			instituteCTX.Update(course);
		}
	}
}
