using Microsoft.AspNetCore.Mvc;
using MVCPRO.Models;
using MVCPRO.VwModels;

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
			InstituteCTX.Update(instructor);
			InstituteCTX.SaveChanges();
			return RedirectToAction("index");
		}
		public IActionResult newInstructor()
		{
			ViewBag.departments = InstituteCTX.Departments.ToList();
			ViewBag.courses = InstituteCTX.Courses.ToList();
			return View();
		}

		/// <summary>
		/// sending old data of instructor by ViewModel instead of ViewData and ViewBag
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public IActionResult editInstructorModel(int id)
		{
			var modelData = new departmentsCoursesModel();

			foreach (var item in InstituteCTX.Departments.ToList())
				modelData.departments.Add(item.name, item.id);

			foreach (var item in InstituteCTX.Courses.ToList())
				modelData.courses.Add(item.name, item.id);
			modelData.Instructor = InstituteCTX.Instructors.Where(x => x.id == id).FirstOrDefault();

			return View(modelData);
		}

		/// <summary>
		/// sending instructor by model instead of ViewData and ViewBag
		/// </summary>
		/// <returns></returns>
		public IActionResult newInstructorModel()
		{
			var modelData = new departmentsCoursesModel();

            foreach (var item in InstituteCTX.Departments.ToList())
				modelData.departments.Add(item.name, item.id);

			foreach (var item in InstituteCTX.Courses.ToList())
				modelData.courses.Add(item.name, item.id);

			return View("newInstructor",modelData);
		}
		public IActionResult ConfirmAdd(Instructor instructor)
		{
			InstituteCTX.Add(instructor);
			InstituteCTX.SaveChanges();
			return RedirectToAction("index");
		}
	}
}
