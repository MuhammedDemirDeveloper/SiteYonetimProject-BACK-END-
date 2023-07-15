using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteYonetimModel.Models
{
    public  class Personeller
    {

        [Key]
        public int PersonelID { get; set; }
       
        [Required]
        public string PersonelAdi { get; set; }
       
        [Required]
        public string PersonelSoyadi { get; set; }
       
        [Required]
        public string PersonelDurum { get; set; }
       
        [Required]
        [MaxLength(11)]
        public long  PersonelTc { get; set; }
        [Required]
        [MaxLength(10)]
        [MinLength(10)]
        public long PersonelTel { get; set; }

        [ForeignKey("Firmalar"),Column(Order =0)]
        public int? FirmaID { get; set; }
        public Firmalar Firmalar { get; set; }


        [ForeignKey("Siteler"),Column(Order =1)]
        public int? SiteID { get; set; }
        public Siteler Siteler { get; set; }

    }
}
