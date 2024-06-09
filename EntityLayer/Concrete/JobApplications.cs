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
    public class JobApplications

    {

        public JobApplications()
        {
            Competencies = new Collection<Competencies>();

        }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }


        [ForeignKey("Userss")]
        public int? user_id { get; set; }
        public virtual Users Userss { get; set; }


        [ForeignKey("JobAdverts")]
        public int? job_id { get; set; }
        public virtual JobAdverts JobAdverts { get; set; }



        public DateTime? job_app_date { get; set; }

        public ICollection<Competencies> Competencies { get; set; }

    }
}
