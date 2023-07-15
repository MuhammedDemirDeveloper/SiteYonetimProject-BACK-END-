using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteYonetimModel.Models
{
    public class Firmalar
    {
        [Key]
        public int FirmaID { get; set; }

        [Required]
        public string FirmaAdi { get; set; }

        [Required]
        [MaxLength(10),MinLength(10)]
        public long FirmaTelNo { get; set; }

        [Required]
        [EmailAddress]
        public string FirmaEmail { get; set; }

        [Required]
        public string FirmaSifre { get; set; }

        [Required]
        public string FirmaAdres { get; set; }
       
        [Required]
        public DateTime FirmaKayitTarihi { get; set; }


        [ForeignKey("iller"),Column(Order =0)]
        public int? ilID { get; set; }
       
        [ForeignKey("ilceler"),Column(Order =1)]
        public int? ilceID { get; set; }
       
        [ForeignKey("Ulkeler"),Column(Order =2)]
        public int? UlkeID { get; set; }
        
        [ForeignKey("SozlesmeTarihleri"),Column(Order =3)]
        public int? SozlesmeTarihiID { get; set; }
      
        public SozlesmeTarihleri SozlesmeTarihleri { get; set; }
        public iller iller { get; set; }
        public ilceler ilceler { get; set; }
        public Ulkeler Ulkeler { get; set; }
        public List<Siteler> Siteler { get; set; }
        public List<Personeller> Personeller { get; set; }
        public List<Bloklar> Bloklar { get; set; } 
    }
}
