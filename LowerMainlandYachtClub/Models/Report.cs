using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LowerMainlandYachtClub.Models
{
    public class Report
    {
        [Key]
        public string ReportID { get; set; }
        public string Content { get; set; }
        public int Hours { get; set; } = 0;
        public Boolean Approved { get; set; } = false;

        [ForeignKey("UserId")]
        public User User { get; set; }

        [ForeignKey("CodeId")]
        public ClassificationCode Code { get; set; }
    }
}
