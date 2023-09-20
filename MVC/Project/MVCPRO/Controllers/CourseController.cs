using Microsoft.AspNetCore.Mvc;
using MVCPRO.Models;
using MVCPRO.VwModels;

namespace MVCPRO.Controllers
{
	public class CourseController : Controller
	{
		InstituteCTX InstituteCTX = new InstituteCTX();

		public IActionResult Index()
		{		
			return View(InstituteCTX.Courses.ToList());
		}
		public IActionResult NewCourse()
		{
			ViewBag.departs = InstituteCTX.Departments.ToList();
            return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
        public IActionResult NewCourse(Course course)
        {
			if (ModelState.IsValid)
			{
            InstituteCTX.Add(course);
			InstituteCTX.SaveChanges();
            return RedirectToAction("index");
			}
			ViewBag.departs = InstituteCTX.Departments.ToList();
			return View(course);
        }
		public IActionResult checkMinDegree(float minDegree,float degree)
		{
			return minDegree>=degree?Json(false):Json(true);
		}

		public IActionResult EditCourse(CourseModel courseModel)
		{
            courseModel.departments = InstituteCTX.Departments.ToList();
            return View("EditCourse",courseModel);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult EditCourse(CourseModel courseModel, int id)
		{
			Course course = InstituteCTX.Courses.Where(x=>x.id == id).FirstOrDefault();
			course.dept_id = courseModel.depID;
			course.name	= courseModel.name;
			course.degree = courseModel.degree;
			course.Mindegree = courseModel.mindegree;
			if (ModelState.IsValid)
			{
				InstituteCTX.Update(course);
				InstituteCTX.SaveChanges();
				return RedirectToAction("index");
			}
			ViewBag.departs = InstituteCTX.Departments.ToList();
			return View("EditCourse", course);
		}
	}
}
