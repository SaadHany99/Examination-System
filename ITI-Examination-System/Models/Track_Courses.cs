using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_ExaminationSystem.Models
{
    public class Track_Courses
    {
        [ForeignKey("track")]
        public int Track_ID { get; set; }
        [ForeignKey("course")]
        public int Course_ID { get; set;}

        public virtual Track track { get; set; }
        public virtual Course course { get; set; }
    }
}
