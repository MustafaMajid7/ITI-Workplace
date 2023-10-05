using Day1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Day1.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CourseController : ControllerBase
	{
		PcContext context;

        public CourseController(PcContext pcContext)
        {
            context = pcContext;
        }

        [HttpGet]
		public ActionResult get()
		{
			if (context.Courses.Any())
				return Ok(context.Courses.ToList());
			else
				return NotFound();
		}

		[HttpDelete]
		public ActionResult delete(int id) 
		{
			if (context.Courses.Any(x=>x.CRS_ID == id))
			{
				context.Remove(context.Courses.FirstOrDefault(x => x.CRS_ID == id));
				context.SaveChanges();
				return Ok(context.Courses.ToList());
			}
			else
				return NotFound();
		}

		[HttpPut("id:int")]
		public ActionResult put(int id,Course course)
		{
            if (ModelState.IsValid)
            {
				if (context.Courses.Any(x => x.CRS_ID == id))
				{
					context.Update(course);
					context.SaveChanges();
					return NoContent(); 
                }
            }
			return NotFound(ModelState);
        }

		[HttpPost]
		public ActionResult post(Course course)
		{
			if (course != null)
			{
				if(ModelState.IsValid) 
				{ 
					context.Add(course);
					context.SaveChanges();
					return Created($"API/Course/{course.CRS_ID}",course);
				}
			}
			return BadRequest(ModelState);
		}

		[HttpGet("{id:int}")]
		public ActionResult getByID(int id)
		{
			if (context.Courses.Any(x => x.CRS_ID == id))
				return Ok(context.Courses.FirstOrDefault(x => x.CRS_ID == id));
			else
				return NotFound();
		}

		[HttpGet(@"{name:regex(^[[a-zA-Z]]{{3,25}}$)}")]
		public ActionResult getByName(string name)
		{
			if (context.Courses.Any(x => x.Cname == name))
				return Ok(context.Courses.FirstOrDefault(x => x.Cname == name));
			else
				return NotFound();
		}
	}
}
