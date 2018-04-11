using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LowerMainlandYachtClub.Models
{
    public class Member
    {
        [Key]
        public string BookingId { get; set; }
        public Booking Booking { get; set; }

        [Key]
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }


    }
}
