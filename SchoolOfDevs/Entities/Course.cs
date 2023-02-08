using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolOfDevs.Entities
{
    public class Course : BaseEntity
    {
        [ForeignKey("User")]
        public int TeacherId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public virtual User Teacher { get; set; }
        public ICollection<User> Students { get; set; }
        public List<StudentCourse> StudentCourses { get; set; }
    }
}
