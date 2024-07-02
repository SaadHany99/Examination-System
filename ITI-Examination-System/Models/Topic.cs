using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_ExaminationSystem.Models
{
    public class Topic
    {
        [Key]
        public int Topic_ID { get; set; }
        [StringLength(50)]
        public string Topic_Name { get; set; }
        public virtual List<Course> Courses { get; set; }
    }
}
