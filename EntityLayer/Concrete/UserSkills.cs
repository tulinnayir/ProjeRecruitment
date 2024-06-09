using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class UserSkills
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

        [ForeignKey("Userss")]
        public int? user_id { get; set; }
        public virtual Users Userss { get; set; }
       
        public string? level { get; set; }
        public int? Beg { get; set; }
        public int? Ju { get; set; }
        public int? Mid { get; set; }
        public int? Exper { get; set; }
        public int? Expert { get; set; }



        public string? level_score { get; set; }
    }
}
