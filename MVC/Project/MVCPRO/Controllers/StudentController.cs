using Microsoft.AspNetCore.Mvc;
using MVCPRO.Models;
using MVCPRO.VwModels;

namespace MVCPRO.Controllers
{
	public class StudentController : Controller
	{
		InstituteCTX InstituteCTX = new InstituteCTX();
		public IActionResult ShowResults(int crs_id)
		{
			List<Trainee> trainees = InstituteCTX.Trainees.ToList();
			List<Course> courses = InstituteCTX.Courses.ToList();
			List<CourseResult> results = InstituteCTX.CourseResults.Where(x=>x.crs_id == crs_id).ToList();
			List<studentResultCourseColor> studentResults = new List<studentResultCourseColor>();
            foreach (var item in results)
            {
				studentResults.Add(new studentResultCourseColor
				{
					st_id = item.trainee_id,
					st_name = trainees.Where(x=>x.id == item.trainee_id).Select(x => x.name).FirstOrDefault(),
					degree = item.degree,
					crs_name= courses.Where(x => x.id == item.crs_id).Select(x => x.name).FirstOrDefault(),
					color = item.degree > courses.Where(x => x.id == item.crs_id)
						.Select(x => x.Mindegree).FirstOrDefault()?"green":"red"
				});  
            }
            return View("ShowResult", studentResults);
		}

		public IActionResult showStudentResult(int std_id, int crs_id)
		{
			Trainee? trainee = InstituteCTX.Trainees.Where(x=>x.id == std_id).FirstOrDefault();
			Course? course = InstituteCTX.Courses.Where(x=>x.id == crs_id).FirstOrDefault();
			CourseResult? result = InstituteCTX.CourseResults.
								Where(x=> x.crs_id == crs_id && x.trainee_id == std_id).FirstOrDefault();
			var studentResult = new studentResultCourseColor();
			
			studentResult.st_id = std_id;
			studentResult.st_name = trainee.name;
			studentResult.degree = result.degree;
			studentResult.crs_name = course.name;
			studentResult.color = result.degree > course.Mindegree ? "green" : "red";
				
			return View("showStudentResult",studentResult);
		}
	}
}
