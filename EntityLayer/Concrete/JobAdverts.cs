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
    public class JobAdverts
    {
        public JobAdverts()
        {
            JobSkills = new Collection<JobSkills>();
            JobApplications = new Collection<JobApplications>();

        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [ForeignKey("Companies")]
        public int? company_id { get; set; }
        public virtual Companies Companies { get; set; }


        public string? title { get; set; }
        public string? status { get; set; }
        public DateTime? advert_end_date { get; set; }
        public string? description {  get; set; }
        public string? type_of_work {  get; set; }
        public string? JobLocation { get; set; }
        public string? Position { get; set; }
        public string? Level { get; set; }
        public string? Department { get; set; }
        public string? Experience { get; set; }
        public string? EducationLevel { get; set; }
        public string? MilitaryStatus { get; set; }
        

        public ICollection<JobSkills> JobSkills { get; set; }
        public ICollection<JobApplications> JobApplications { get; set; }
    }
}
