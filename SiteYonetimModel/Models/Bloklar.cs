using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteYonetimModel.Models
{
    public class Bloklar
    {
        [Key]
        public int BlokID { get; set; }

        [Required]
        public string BlokTanim { get; set; }

        [Required]
        public int BlokDaireSayisi { get; set; }

        [ForeignKey("Firmalar"),Column(Order =0)]
        public int? FirmaID { get; set; }

        [ForeignKey("Siteler"), Column(Order = 1)]
        public int? SiteID { get; set; }

        public Firmalar Firmalar { get; set; }
        public Siteler Siteler { get; set; }
        public List<Daireler> Daireler { get; set; }    
    }
}
