using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkDevelopment.JobsPortal.Domain.Entities
{
    public class JobDTO
    {
        public List<Job> jobs { get; set; }
        public int jobsCount { get; set; }
        public int pagesCount { get; set; }
    }
}
