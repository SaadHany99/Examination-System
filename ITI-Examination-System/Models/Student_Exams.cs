using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_ExaminationSystem.Models
{
    public class Student_Exams
    {
        [ForeignKey("student")]
        public int Student_ID { get; set; }
        [ForeignKey("exam")]
        public int Exam_ID { get; set; }
        public int? Student_Degree { get; set; }

        public virtual Student student { get; set; }
        public virtual Exam exam { get; set; }
    }
}
