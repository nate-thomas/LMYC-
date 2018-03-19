using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LowerMainlandYachtClub.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MemberStatus { get; set; }
        public string SkipperStatus { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string MobilePhone { get; set; }
        public string HomePhone { get; set; }
        public string WorkPhone { get; set; }
        public string SailingQualifications { get; set; }
        public string Skills { get; set; }
        public string SailingExperience { get; set; }
        public int Credits { get; set; } = 320;

        [ForeignKey("EmergencyContactId")]
        public EmergencyContact EmergencyContacts { get; set; }

        [ForeignKey("BookingId")]
        public Booking Bookings { get; set; }
    }
}
