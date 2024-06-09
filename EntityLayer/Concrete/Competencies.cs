using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace EntityLayer.Concrete
{
    public class Competencies
    {
        public   Competencies()
        {
           UserSkills = new Collection<UserSkills>();
           JobSkills = new Collection<JobSkills>();

        }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string? name { get; set; }

        [ForeignKey("JobApplications")]
        public int? job_id { get; set; }
        public virtual JobApplications JobApplications { get; set; }

        public ICollection<UserSkills> UserSkills { get; set; }
        public ICollection<JobSkills> JobSkills { get; set; }

    }
}
