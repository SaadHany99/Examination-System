using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_ExaminationSystem.Models
{
    public class Track
    {
        [Key]
        public int Track_ID { get; set; }
        [StringLength(50)]
        public string Track_Name { get; set; }
        public virtual List<Student> Students { get; set; }
    
        public virtual List<Branch_Tracks> Branches { get; set; }
        public virtual List<Track_Courses> Tracks { get; set; }
        public virtual List<Instructor_Tracks> Instructors { get; set; }
    }
}
