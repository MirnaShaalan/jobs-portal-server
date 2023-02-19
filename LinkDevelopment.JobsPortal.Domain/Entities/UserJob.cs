using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkDevelopment.JobsPortal.Domain.Entities
{
    public class UserJob 
    {
        public Guid UserId { get; set; }
        public virtual  User User { get; set; }
        public Guid JobId { get; set; }
        public virtual Job Job { get; set; }
    }
}
