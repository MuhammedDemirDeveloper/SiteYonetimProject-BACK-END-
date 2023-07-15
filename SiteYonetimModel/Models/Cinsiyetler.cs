using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteYonetimModel.Models
{
    public class Cinsiyetler
    {
        [Key]
        public int CinsiyetID { get; set; }

        [Required]
        public string Cinsiyet { get; set; }
        public List<Kisiler> Kisiler { get; set; }
    }
}
