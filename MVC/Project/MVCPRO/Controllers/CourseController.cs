using Microsoft.AspNetCore.Mvc;
using MVCPRO.Models;

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
            InstituteCTX.Add(course);
			InstituteCTX.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
