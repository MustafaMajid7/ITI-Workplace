using AutoMapper;
using Day1.Models;

namespace Day1
{
	public class AutoMapperProfile:Profile
	{
        public AutoMapperProfile()
        {
            CreateMap<InstructorDto, Instructor>();
            CreateMap<Instructor, InstructorDto>();
			CreateMap<Course, CourseDto>();
			CreateMap<CourseDto, Course>();
		}
    }
}
