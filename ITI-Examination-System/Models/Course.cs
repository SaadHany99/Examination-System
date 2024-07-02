using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_ExaminationSystem.Models
{
    public class Course
    {
        [Key]
        public int Course_ID { get; set; }
        [StringLength(50)]
        public string Course_Name { get; set; }
        public int Course_Duration { get; set; }
        [ForeignKey("instructor")]
        public int Instructor_ID { get; set; }
        [ForeignKey("topic")]
        public int Topic_ID { get; set; }
        public virtual Instructor instructor { get; set; }
        public virtual Topic topic { get; set; }
        public virtual List<Exam> Exams { get; set;}
        public virtual List<Question>? Questions { get; set; }
        public virtual List<Track_Courses> Tracks { get; set; }
    }
}
