using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkDevelopment.JobsPortal.Domain.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
