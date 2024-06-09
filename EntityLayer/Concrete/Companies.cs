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
    public class Companies
    {

        public Companies() 
        {

            JobAdverts = new Collection<JobAdverts>();

        }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string? logo { get; set; }

        [ForeignKey("Adresses")]
        public int? address_id { get; set; }
        public virtual Adresses Adresses { get; set; }
        public string? company_title { get; set; }
        public string? mail { get; set; }
        public string? phone { get; set; }
        public string? fax_phone { get; set; }
        public string? tax_no { get; set; }//il
        public string? explanation { get; set; }//ilçe
        public string? password { get; set; }
        public ICollection<JobAdverts> JobAdverts { get; set; }



    }
}
