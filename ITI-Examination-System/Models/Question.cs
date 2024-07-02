#nullable disable
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
    public class Question
    {
        [Key]
        public int Question_ID { get; set; }
        //[StringLength(100)]
        public string Question_Header { get; set; }
        public char Question_Type { get; set; }
        public string Model_Answer { get; set; }
        [ForeignKey("course")]
        public int Course_ID { get; set; }
        [ForeignKey("instructor")]
        public int Instructor_ID { get; set; } 

        public virtual Course course { get; set; }
        public virtual Instructor instructor { get; set; }
        public virtual List<Question_Choices> Questions { get; set; }
        public virtual List<Exam_Questions> Exams { get; set; }
        public virtual List<Student_Answers> student_answers { get; set; }

    }
}
