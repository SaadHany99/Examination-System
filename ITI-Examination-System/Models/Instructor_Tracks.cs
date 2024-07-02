using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_ExaminationSystem.Models
{
    public class Instructor_Tracks
    {
        [ForeignKey("instructor")]
        public int InstructorTrack_ID { get; set; }
        [ForeignKey("track")]
        public int Track_ID { get; set; }

        public virtual Instructor instructor { get; set; }
        public virtual Track track { get; set; }
    }
}
