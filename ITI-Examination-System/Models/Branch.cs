using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_ExaminationSystem.Models
{
    public class Branch
    {
        [Key]
        public int Branch_ID { get; set; }
        [StringLength(50)]
        public string Branch_Name { get; set; }
        [StringLength(50)]
        public string Branch_Location { get; set; }
        public virtual List<Instructor> Instructors { get; set; }
        public virtual List<Student> Students { get; set; }

        public virtual List<Branch_Tracks> Branches { get; set; }
    }
}
