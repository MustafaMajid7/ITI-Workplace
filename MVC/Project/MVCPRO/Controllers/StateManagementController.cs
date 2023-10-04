using Microsoft.AspNetCore.Mvc;

namespace MVCPRO.Controllers
{
	public class StateManagementController : Controller
	{
		public IActionResult SetSession()
		{
			HttpContext.Session.SetString("Name", "Mostafa Maged");
			HttpContext.Session.SetString("Track", "Dot Net");

			return Content("Data Saved");
		}
		public IActionResult GetSession()
		{
			String output=String.Empty;
            foreach (var item in HttpContext.Session.Keys)
            {
				output += item + " ====>>>> ";
				output += HttpContext.Session.GetString(item)+"\n";
            }
            return Content(output);
		}
	}
}
