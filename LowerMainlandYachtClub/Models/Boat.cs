using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LowerMainlandYachtClub.Models
{
    public class Boat
    {
        [Key]
        public string BoatId { get; set; }
        public string Name { get; set; }
        public double CreditsPerHour { get; set; }
        public string Status { get; set; }
        public byte[] Photo { get; set; }
        public string Description { get; set; }
        public double Length { get; set; }
        public string Make { get; set; }
        public long Year { get; set; }
        public List<Booking> Bookings { get; set; }
    }
}
