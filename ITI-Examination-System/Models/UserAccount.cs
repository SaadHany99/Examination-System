using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_ExaminationSystem.Models
{
    public class UserAccount
    {
        [Key]
        public int User_ID { get; set; }
        [StringLength(20)]
        public string User_Password { get; set; }
        [StringLength(50)]
        public string User_Email { get; set; }
        public char Account_Type { get; set; }
        public virtual Instructor instructor { get; set; }
        public virtual Student student { get; set; }
    }
}
