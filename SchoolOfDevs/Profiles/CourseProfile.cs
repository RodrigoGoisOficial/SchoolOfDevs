using AutoMapper;
using SchoolOfDevs.Dto.Course;
using SchoolOfDevs.Entities;

namespace SchoolOfDevs.Profiles
{
    public class CourseProfile : Profile
    {
        public CourseProfile()
        {
            CreateMap<Note, CourseRequest>();
            CreateMap<Note, CourseResponse>();
        }
    }
}
