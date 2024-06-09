using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Collections.ObjectModel;

namespace EntityLayer.Concrete
{
    public class Adresses
    {
        public Adresses()
        {
            Userss = new Collection<Users>();
            Companies= new Collection<Companies>();
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? id { get; set; }
        public string city_id { get; set; }
        public string distirct_id { get; set; }
        public string?  adresses { get; set; }
        public string?  actie { get; set; }


        public ICollection<Users> Userss { get; set; }
        public ICollection<Companies> Companies { get; set; }
    }
}
