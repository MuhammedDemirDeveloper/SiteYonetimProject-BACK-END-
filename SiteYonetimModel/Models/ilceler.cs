using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteYonetimModel.Models
{
    public class ilceler
    {
        [Key]
        public int ilceID { get; set; }
        
        [Required]
        public string ilceAdi { get; set; }
       
        [ForeignKey("iller")]
        public int? ilID { get; set; }
        public iller iller { get; set; }
        public List<Siteler> Siteler { get; set; }
        public List<Firmalar> Firmalar { get; set; }

        

    }
}
