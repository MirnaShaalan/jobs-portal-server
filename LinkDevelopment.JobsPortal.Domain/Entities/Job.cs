using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkDevelopment.JobsPortal.Domain.Entities
{
    public class Job :BaseEntity
    {
        [Required]
        public string Description { get; set; }
        [Required]
        public string Skills { get; set; }
        [Required]
        public string Responsibilities { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public int MaxApplications { get; set; }
        public List<UserJob>? UserJob { get; set; }


    }
}
