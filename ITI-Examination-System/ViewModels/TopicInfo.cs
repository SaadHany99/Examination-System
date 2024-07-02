using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_Examination_System.ViewModels
{
    public class TopicInfo
    {
        public string Topic_Name { get; set; }

        public int Course_ID { get; set; }
        public string Course_Name { get; set; }
    }
}
