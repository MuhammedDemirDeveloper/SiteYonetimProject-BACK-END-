using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteYonetimModel.Models
{
    public class Ulkeler
    {
        [Key]
        public int UlkeID { get; set; }
        [Required]
        public string UlkeAdi { get; set; }
        
        public List<iller>iller { get; set; }
        public List<Siteler> Siteler { get; set; }
        public List<Firmalar>Firmalar { get; set; } 

    }
}
