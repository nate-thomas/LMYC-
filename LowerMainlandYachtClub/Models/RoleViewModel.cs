using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LowerMainlandYachtClub.Models
{
    public class RoleViewModel
    {
        [Key]
        public string RoleId { get; set; }
        [Display(Name = "Name")]
        public string RoleName { get; set; }
        public string UserId { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
