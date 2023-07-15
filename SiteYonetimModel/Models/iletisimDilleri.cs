using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteYonetimModel.Models
{
    public class iletisimDilleri
    {
        [Key]
        public int IletisimDiliID { get; set; }

        
        [Required]
        public string Dil { get; set; }

        public List<Kisiler> Kisiler { get; set; }

    }
}
