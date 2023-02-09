using SchoolOfDevs.Entities;
using SchoolOfDevs.Enuns;

namespace SchoolOfDevs.Dto.User
{
    public class UserResponse
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string UserName { get; set; }
        public TypeUser TypeUser { get; set; }
        public List<Course> CoursesStuding { get; set; } // TypeUser == Student
        public List<Course> CoursesTeaching { get; set; } // TypeUser == Teacher
    }
}
