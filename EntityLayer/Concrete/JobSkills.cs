using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class JobSkills
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [ForeignKey("JobTypes")]

        public int? job_type_id { get; set; }
        public virtual JobTypes JobTypes { get; set; }

        [ForeignKey("Competencies")]
        public int? compet_id { get; set; }
        public virtual Competencies Competencies { get; set; }

        [ForeignKey("Categories")]
        public int? category_id { get; set; }
        public virtual Categories Categories { get; set; }
        [ForeignKey("JobAdverts")]
        public int? jobadvert_id { get; set; }
        public virtual JobAdverts JobAdverts { get; set; }
        public string? level { get; set; }
        public int min_level_score { get; set; }
        public int max_level_score { get; set; }
    }
}
