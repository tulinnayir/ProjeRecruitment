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
    public class Users
    {
        public Users() 
        {

           
            UserSkills = new Collection<UserSkills>();
            JobApplications = new Collection<JobApplications>();
            JobSkills = new Collection<JobSkills>();
            Categories = new Collection<Categories>();
            JobTypes = new Collection<JobTypes>();

        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }


        [ForeignKey("Adresses")]
        public int? address_id { get; set; }
        public virtual Adresses Adresses { get; set; }
        public string? photo { get; set; }
        public string? name { get; set; }
        public string? surname { get; set; }
        public string? explanation { get; set; }
        public string? mail { get; set; }
        public string? phone { get; set; }

        public DateTime? date_birth { get; set; }

        public string? school_name { get; set; }
        public string? job_name { get; set; }
        public string? note { get; set; }   
        public string? major { get; set; }
        public DateTime? start_date { get; set; }
        public DateTime? end_date { get; set; }
        public string? gender { get; set; }
        public string? password { get; set; }
        public string? link { get; set; }

        //[NotMapped]
        //public int MaxUserLevel { get; set; }


        public ICollection<UserSkills> UserSkills { get; set; }
        public ICollection<JobApplications> JobApplications { get; set; }
        public Collection<JobSkills> JobSkills { get; set; }
        public Collection<Categories> Categories { get; set; }
        public Collection<JobTypes> JobTypes { get; set; }
    }
}
