using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteYonetimModel.Models
{
    public class IsinmaTurleri
    {
        [Key]
        public int IsinmaID { get; set; }
        
        [Required]
        public string IsinmaTuru { get; set; }

       
        public List<Siteler> Siteler { get; set; }
    }
}
