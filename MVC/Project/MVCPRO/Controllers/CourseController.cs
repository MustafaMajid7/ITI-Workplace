using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVCPRO.Models;
using MVCPRO.Repository.CourseRepository;
using MVCPRO.Repository.DepartmentRepository;
using MVCPRO.VwModels;

namespace MVCPRO.Controllers
{
	[Authorize]
    public class CourseController : Controller
	{
		public ICourseRepository courseRepository;
		public IDepartmentRepository departmentRepository;
        public CourseController(ICourseRepository courseRepository,
			   IDepartmentRepository departmentRepository)
        {
            this.courseRepository = courseRepository;
			this.departmentRepository = departmentRepository;
        }

        public IActionResult Index()
		{		
			return View(courseRepository.GetAll());
		}

		//course/getcoursesbydeptid?deptID=2
		public IActionResult getcoursesbydeptid(int deptID)
		{
			List<Course> crses = courseRepository.GetcoursesbydeptID(deptID);
			List<Course> courses = new List<Course>();
            foreach (var item in crses)
            {
				courses.Add(new Course() { id = item.id, name = item.name });
            }
            return Json(courses);
		}
		public IActionResult NewCourse()
		{
			ViewBag.departs = departmentRepository.GetAll();
            return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
        public IActionResult NewCourse(Course course)
        {
			if (ModelState.IsValid)
			{
				//InstituteCTX.Add(course);
				//InstituteCTX.SaveChanges();
				try { 
					courseRepository.Insert(course);
					courseRepository.Save();
					return RedirectToAction("index");
				}
				catch(Exception ex)
				{
					ModelState.AddModelError("dept_id", "you must choose a department");
				}
			}
			//ViewBag.departs = InstituteCTX.Departments.ToList();
			ViewBag.departs = departmentRepository.GetAll();
			return View(course);
        }
		public IActionResult checkMinDegree(float minDegree,float degree)
		{
			return minDegree>=degree?Json(false):Json(true);
		}

		public IActionResult EditCourse(CourseModel courseModel)
		{
            courseModel.departments = departmentRepository.GetAll();
            return View(courseModel);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult EditCourse(CourseModel courseModel, int id)
		{
			//Course course = InstituteCTX.Courses.Where(x=>x.id == id).FirstOrDefault();
			Course course = courseRepository.GetByCourseId(id);
			course.dept_id = courseModel.depID;
			course.name = courseModel.name;
			course.degree = courseModel.degree;
			course.Mindegree = courseModel.mindegree;
			if (ModelState.IsValid)
			{
				//InstituteCTX.Update(course);
				//InstituteCTX.SaveChanges();
				courseRepository.Update(course);
				courseRepository.Save();
				return RedirectToAction("index");
			}
			ViewBag.departs = departmentRepository.GetAll();
			return View(course);
		}
	}
}
