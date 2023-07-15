using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteYonetimModel.Models
{
    public class Siteler
    {
        [Key]
        public int SiteID { get; set; }
       
        [Required]
        public string SiteAdi { get; set; }
        
        [Required]
        public string SiteAdres { get; set; }

        [ForeignKey("Firmalar"),Column(Order =0)]
        public int FirmaID { get; set; }

        [ForeignKey("iller"), Column(Order = 1)]
        public int? ilID { get; set; }

        [ForeignKey("ilceler"), Column(Order = 2)]
        public int? ilceID { get; set; }

        [ForeignKey("Ulkeler"), Column(Order = 3)]
        public int? UlkeID { get; set; }
       
        [ForeignKey("IsinmaTurleri"), Column(Order = 4)]
        public int? IsinmaID { get; set; }
        public Firmalar Firmalar { get; set; }
        public iller iller { get; set; }
        public ilceler ilceler { get; set; }
        public Ulkeler Ulkeler { get; set; }
        public IsinmaTurleri IsinmaTurleri { get; set; }
        public List<Personeller> Personeller { get; set; }
        public List<Bloklar> Bloklar { get; set; }   
       
    }
}
