using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_Examination_System.ViewModels
{
    public class StudentInfo
    {
        public int Student_ID { get; set; }
        public string Student_Name { get; set; }
        public int Student_Age { get; set; }
        public char Student_Gender { get; set; }
        public byte[]? Student_Image { get; set; }
        public string User_Email { get; set; }
        public string Branch_Name { get; set; }
        public int Track_ID { get; set; }
        public string Track_Name { get; set; }
    }
}
