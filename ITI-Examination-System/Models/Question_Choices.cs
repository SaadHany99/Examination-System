using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_ExaminationSystem.Models
{
    public class Question_Choices
    {
        [ForeignKey("question")]
        public int Question_ID { get; set; }
        [ForeignKey("choice")]
        public int Choice_ID { get; set; }
        public string Choice { get; set; }
        public virtual Question question { get; set; }
        //public virtual Question question { get; set; }

    }
}
