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
    public class JobTypes
    {
        public JobTypes() 
        {
            JobSkills = new Collection<JobSkills>();
            UserSkills = new Collection<UserSkills>();
        }
       
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string? name { get; set; }

        public ICollection<JobSkills> JobSkills { get; set; }
        public ICollection<UserSkills> UserSkills { get; set; }
    }
}
