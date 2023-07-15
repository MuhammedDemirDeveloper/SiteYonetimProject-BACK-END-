using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteYonetimModel.Models
{
    public class OgrenimDurumu
    {
        [Key]
        public int OgrenimID { get; set; }
      
        [Required]
        public string Ogrenim { get; set; }
        public List<Kisiler> Kisiler { get; set; }

    }
}
