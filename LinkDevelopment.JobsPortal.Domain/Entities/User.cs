using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkDevelopment.JobsPortal.Domain.Entities
{
    public class User : BaseEntity
    {
        [Required]
        public String Password { get; set; }
        [Required]
        public String Email { get; set; }
        [Required]
        public int PhoneNumber { get; set; }
        public String? Role { get; set; }
        public List<UserJob>? UserJob { get; set; }

    }
}
