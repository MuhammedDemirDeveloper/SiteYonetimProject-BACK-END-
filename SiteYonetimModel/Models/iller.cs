using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteYonetimModel.Models
{
    public class iller
    {
        [Key]
        public int ilID { get; set; }
        [Required]
        public string ilAdi { get; set; }
        
        [ForeignKey("Ulkeler")]
        public int? UlkeID { get; set; }
        
        public Ulkeler Ulkeler { get; set; } 
        public List<ilceler> ilceler { get; set; }
        public List<Siteler> Siteler { get; set; }
        public List<Firmalar> Firmalar { get; set; } 

       

    }
}
