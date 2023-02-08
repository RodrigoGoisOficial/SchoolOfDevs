using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolOfDevs.Entities
{
    public class Note : BaseEntity
    {
        [ForeignKey("User")]
        public int UserId { get; set; }

        [ForeignKey("Course")]
        public int CourseId { get; set; }

        public decimal Value { get; set; }

        public virtual User User { get; set; }

        public virtual Course Course { get; set; }
    }
}
