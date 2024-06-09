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
    public class Categories

    {
        public Categories()
        {
            UserSkills = new Collection<UserSkills>();
            JobSkills = new Collection<JobSkills>();
         

        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string? name { get; set; }

        [ForeignKey("Competencies")]

        public int? competence_id { get; set; }
        public virtual Competencies Competencies { get; set; }


        public ICollection<UserSkills> UserSkills { get; set; }

        public ICollection<JobSkills> JobSkills { get; set; }

    }
}
