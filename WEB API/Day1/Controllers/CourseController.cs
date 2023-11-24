using System.Drawing;
using AutoMapper;
using Day1.Models;
using Day1.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;

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

        [HttpGet("getAllCourses")]
		public ActionResult getAllCourses()
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
					unitOfWork.Course.update(course);
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
				if(unitOfWork.Course.add(course) is null)
				{
					return BadRequest("error in adding object");
				}
				unitOfWork.Course.add(course);
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

		[HttpGet("DownloadXLS")]
		public ActionResult DownloadXLS()
		{
			var stream = new MemoryStream();

			using(var excelPackage = new ExcelPackage(stream))
			{
				var workSheet = excelPackage.Workbook.Worksheets.Add("Courses");

				workSheet.Cells[1,4,1,8].Value = "All Courses Data";
				workSheet.Cells[1, 4, 1, 8].Merge = true;

				workSheet.Cells[1,4,1,8].Style.Font.Bold = true;
				workSheet.Cells[1,4,1,8].Style.Font.Color.SetColor(Color.Gray);
				workSheet.Cells[1, 4, 1, 8].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
				workSheet.Cells[1,4,1,8].Style.Fill.BackgroundColor.SetColor(Color.Beige);

				workSheet.Cells[3, 5].Value = "ID";
				workSheet.Cells[3, 6].Value = "Name";
				workSheet.Cells[3, 7].Value = "Duration";

				int row = 4;
                foreach (var item in unitOfWork.Course.getAll())
                {
					workSheet.Cells[row, 5].Value = item.CRS_ID;
					workSheet.Cells[row, 6].Value = item.Cname;
					workSheet.Cells[row, 7].Value = item.Duration;
					row++;
                }

				excelPackage.Workbook.Properties.Title = "Courses";

				excelPackage.Save();

            }
			stream.Position = 0;
			return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet","Mostafa's Courses");
		}

		[HttpPost("UploadXLS")]
		public ActionResult UploadXLS(IFormFile formfile)
		{
			var stream = formfile.OpenReadStream();

            if (stream.Length ==0 || stream is null)
            {
				return BadRequest("invalid file");
            }

			using(var excelStream = new ExcelPackage(stream))
			{
				var worksheet = excelStream.Workbook.Worksheets.First();

				var rows = worksheet.Dimension.Rows;

				List<Country> countryList = new List<Country>();
				for (int i = 2; i <= rows; i++)
				{
					#region Old Code
					//var name = worksheet.Cells[i, 1].Value.ToString();
					//int.TryParse(worksheet.Cells[i, 2].Value.ToString(), out var duration);

					//if (duration == default || name is null)
					//	continue;
					#endregion
					
					Country country = new Country();

					for (int j = 1; j <= worksheet.Dimension.Columns; j++)
					{
						if (worksheet.Cells[1, j].Value is null)
						{
							continue;
						}
						StaticClass.SetValue(country,
							worksheet.Cells[1, j].Value.ToString()
							,worksheet.Cells[i, j].Value);
					}
					countryList.Add(country);
				}
				unitOfWork.Country.addRange(countryList);
				unitOfWork.complete();
            }
			return Created(unitOfWork.Course.getAll()?.ToString()??"Empty","");

        }
		
	}
}
