using ITI_Examination_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_ExaminationSystem.Models
{
    public class Exam
    {
        [Key]
        public int Exam_ID { get; set; }
        public int Exam_Duration { get; set; }
        public DateTime Start_Time { get; set; }
        [ForeignKey("course")]
        public int Course_ID { get; set; }
        [ForeignKey("instructor")]
        public int Instructor_ID { get; set; }
        public virtual Course course { get; set; }
        public virtual Instructor instructor { get; set; }
        public virtual List<Student_Exams> Students { get; set; }
        public virtual List<Exam_Questions> Exams { get; set; }
        public virtual List<Student_Answers> student_answers { get; set; }

    }
}
