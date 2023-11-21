using AutoMapper;
using Day1.Models;
using Day1.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Day1.Controllers
{
	//[Authorize]
	[Route("api/[controller]")]
	[ApiController]
	public class CourseController : ControllerBase
	{
		private readonly IUnitOfWork unitOfWork;
		private readonly IMapper mapper;

		public CourseController(IUnitOfWork unitOfWork, IMapper mapper)
        {
			this.unitOfWork = unitOfWork;
			this.mapper = mapper;
		}

        [HttpGet]
		public ActionResult get()
		{
			if (unitOfWork.Course.getAll().Any())
			{
				return Ok(unitOfWork.Course.getAll().Select(c=>mapper.Map<CourseDto>(c)));
			}
			else
				return NotFound();
		}

		//[HttpDelete]
		//public ActionResult delete(int id) 
		//{
		//	if (context.Courses.Any(x=>x.CRS_ID == id))
		//	{
		//		context.Remove(context.Courses.FirstOrDefault(x => x.CRS_ID == id));
		//		context.SaveChanges();
		//		return Ok(context.Courses.ToList());
		//	}
		//	else
		//		return NotFound();
		//}

		[HttpPut("id:int")]
		public ActionResult put([FromQuery]int id, Course course)
		{
			if (ModelState.IsValid)
			{
				if (unitOfWork.Course.getAll().Any(x => x.CRS_ID == id))
				{
					unitOfWork.Course.updateCourse(course);
					unitOfWork.complete();
					return NoContent();
				}
				return NotFound(ModelState);
			}
			return BadRequest(ModelState.Values);
		}

		[HttpPost]
		public ActionResult post(CourseDto courseDto)
		{
			if (ModelState.IsValid)
			{
				Course course = mapper.Map<Course>(courseDto);
				if(unitOfWork.Course.addCourse(course) is null)
				{
					return BadRequest("error in adding object");
				}
				unitOfWork.Course.addCourse(course);
				unitOfWork.complete();
				return Created("",course);
			}

			return BadRequest(ModelState);
		}

		[HttpGet("{id:int}")]
		public ActionResult getByID(int id)
		{
			if (unitOfWork.Course.getOne(c=>c.CRS_ID ==id) is not null)
				return Ok(unitOfWork.Course.getOne(c => c.CRS_ID == id));
			else
				return NotFound();
		}

		[HttpGet(@"{name:regex(^[[a-zA-Z]]{{3,25}}$)}")]
		public ActionResult getByName(string name)
		{
			if (unitOfWork.Course.getOne(c => c.Cname.Equals(name,StringComparison.InvariantCultureIgnoreCase)) is not null)
				return Ok(unitOfWork.Course.getOne(c => c.Cname.Equals(name, StringComparison.InvariantCultureIgnoreCase)));
			else
				return NotFound();
		}
		[HttpGet("getRange")]
		public ActionResult getRange(int max,int min)
		{
			if (unitOfWork.Course.getRange(c=>c.Duration<=max && c.Duration>=min).Any())
				return Ok(unitOfWork.Course.getRange(c => c.Duration <= max && c.Duration >= min));
			else
				return NotFound();
		}

	}
}
