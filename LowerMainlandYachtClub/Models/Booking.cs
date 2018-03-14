using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LowerMainlandYachtClub.Models
{
    public class Booking
    {
        [Key]
        public string BookingId { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string BoatId { get; set; }
        public Boat Boat { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
