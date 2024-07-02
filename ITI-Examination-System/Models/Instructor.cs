using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_ExaminationSystem.Models
{
    public class Instructor
    {
        [Key]
        public int Instructor_ID { get; set; }
        [StringLength(50)]
        public string Instructor_Name { get; set; }
        [Column(TypeName = "money")]
        public decimal Instructor_Salary { get; set; }
        public char Instructor_Gender { get; set; }
        public byte[]? Instructor_Image { get; set; }
        [ForeignKey("User")]
        public int User_ID { get; set; }
        [ForeignKey("branch")]
        public int Branch_ID { get; set; }

        public virtual UserAccount User { get; set; }
        public virtual Branch branch { get; set; }
        public virtual List<Course>? Courses { get; set;}
        public virtual List<Exam> Exams { get; set;}
        public virtual List<Question>? Questions { get; set;}
        public virtual List<Instructor_Tracks> Instructors { get; set; }

    }
}
