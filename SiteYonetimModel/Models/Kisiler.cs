using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteYonetimModel.Models
{
    public class Kisiler
    {
        [Key]
        public int KisiID { get; set; }

        [Required]
        public string Adi { get; set; }

        [Required]
        public string Soyadi { get; set; }

        [Required]
        [MaxLength(11)]
        public long TcKimlikNo { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Durum { get; set; }

        [Required]
        [MaxLength(10)]
        public long TelNo1 { get; set; }

        [Required]
        [MaxLength(10)]
        public long TelNo2 { get; set; }
        
        [ForeignKey("Cinsiyetler"),Column(Order =0)]
        public int? CinsiyetID { get; set; }

        [ForeignKey("Meslekler"), Column(Order = 1)]
        public int? MeslekID { get; set; }
       
        [ForeignKey("Uyruklar"), Column(Order = 2)]
        public int? UyrukID { get; set; }
     
        [ForeignKey("Daireler"), Column(Order =3)]
        public int? DaireID { get; set; }

        [ForeignKey("iletisimDilleri"), Column(Order = 4)]
        public int? IletisimDiliID { get; set; }

        [ForeignKey("OgrenimDurumu"), Column(Order = 5)]
        public int? OgrenimID { get; set; }

        public Cinsiyetler Cinsiyetler { get; set; }    
        public Meslekler Meslekler { get; set; }    
        public Uyruklar Uyruklar { get; set; }  
        public Daireler Daireler { get; set; }
        public iletisimDilleri iletisimDilleri{ get; set; }

        public OgrenimDurumu OgrenimDurumu { get; set; }    
    }
}
