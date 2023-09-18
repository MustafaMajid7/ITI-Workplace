using Microsoft.AspNetCore.Mvc;
using MVCPRO.Models;

namespace MVCPRO.Controllers
{
	public class InstructorController : Controller
	{
		InstituteCTX InstituteCTX = new InstituteCTX();
		public IActionResult Index()
		{
			return View(InstituteCTX.Instructors.ToList());
		}
		public IActionResult showDetails(int id)
		{
			ViewData["department"] = InstituteCTX.Instructors.
					Where(x => x.id == id).FirstOrDefault().department.name;
			ViewData["course"] = InstituteCTX.Instructors.
					Where(x => x.id == id).FirstOrDefault().course.name;
			return View(InstituteCTX.Instructors.Where(x => x.id == id).FirstOrDefault());
		}
		public IActionResult editInstructor(int id)
		{
			ViewBag.departments = InstituteCTX.Departments.ToList();
			ViewBag.courses = InstituteCTX.Courses.ToList();
			return View(InstituteCTX.Instructors.Where(x => x.id == id).FirstOrDefault());
		}
		public IActionResult confirmEditing(Instructor instructor)
		{
			Instructor oldIns = InstituteCTX.Instructors.Where(x => x.id == instructor.id).FirstOrDefault();
			oldIns.name = instructor.name;
			oldIns.salary = instructor.salary;
			oldIns.address = instructor.address;
			oldIns.dept_id = instructor.dept_id;
			oldIns.crs_id = instructor.crs_id;
			//InstituteCTX.Update(instructor);
			InstituteCTX.SaveChanges();
			return RedirectToAction("index");
		}
		public IActionResult newInstructor()
		{
			ViewBag.departments = InstituteCTX.Departments.ToList();
			ViewBag.courses = InstituteCTX.Courses.ToList();
			return View();
		}
		public IActionResult ConfirmAdd(Instructor instructor)
		{
			InstituteCTX.Add(instructor);
			InstituteCTX.SaveChanges();
			return RedirectToAction("index");
		}
	}
}
