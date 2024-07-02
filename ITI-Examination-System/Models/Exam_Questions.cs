using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_ExaminationSystem.Models
{
    public class Exam_Questions
    {
        [ForeignKey("exam")]
        public int Exam_ID { get; set; }
        [ForeignKey("question")]
        public int Question_ID { get; set; }

        public virtual Exam exam { get; set; }
        public virtual Question question { get; set; }
    }
}
