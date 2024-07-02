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
    public class Student
    {
        [Key]
        public int Student_ID { get; set; }
        [StringLength(50)]
        public string Student_Name { get; set; }
        public int Student_Age { get; set; }
        public char Student_Gender { get; set; }
        public byte[]? Student_Image { get; set; }
        [ForeignKey("User")]
        public int User_ID { get; set; }
        [ForeignKey("branch")]
        public int Branch_ID { get; set; }
        [ForeignKey("track")]
        public int Track_ID { get; set; }

        public virtual UserAccount User { get; set; }
        public virtual Branch branch { get; set; }
        public virtual Track track { get; set; }
        public virtual List<Student_Exams> Students { get; set; }
        public virtual List<Student_Answers> student_answers { get; set; }
    }
    
}
