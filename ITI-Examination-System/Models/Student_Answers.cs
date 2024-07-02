using ITI_ExaminationSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_Examination_System.Models
{
    public class Student_Answers
    {
        [ForeignKey("student")]
        public int Student_ID { get; set; }
        [ForeignKey("exam")]
        public int Exam_ID { get; set; }
        [ForeignKey("question")]
        public int Question_ID { get; set; }
        public string? Answer { get; set; }

        public virtual Student student { get; set; }
        public virtual Exam exam { get; set; }
        public virtual Question question { get; set; }
    }
}
