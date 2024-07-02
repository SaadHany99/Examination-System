using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_ExaminationSystem.Models
{
    public class Branch_Tracks
    {
        [ForeignKey("branch")]
        public int Branch_ID { get; set; }
        [ForeignKey("track")]
        public int Track_ID { get; set; }
        
        public virtual Branch branch { get; set; }
        public virtual Track track { get; set; }
    
    }
}
