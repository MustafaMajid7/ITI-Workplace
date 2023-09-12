using Microsoft.AspNetCore.Mvc;
using MVCPRO.Models;

namespace MVCPRO.Controllers
{
	public class InstructorController : Controller
	{
		InstituteCTX InstituteCTX;
		public IActionResult Index()
		{
			InstituteCTX = new InstituteCTX();
			return View("allInstructors",InstituteCTX.Instructors.ToList());
		}
		public IActionResult showDetails(int id)
		{
			InstituteCTX = new InstituteCTX();
			ViewData["department"] = InstituteCTX.Instructors.
					Where(x => x.id == id).FirstOrDefault().department.name;
			ViewData["course"] = InstituteCTX.Instructors.
					Where(x => x.id == id).FirstOrDefault().course.name;
			return View("allDetails", InstituteCTX.Instructors.Where(x=>x.id == id).FirstOrDefault());
		}
	}
}
