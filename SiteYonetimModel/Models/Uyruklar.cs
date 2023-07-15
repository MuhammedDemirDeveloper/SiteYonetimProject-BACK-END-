using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteYonetimModel.Models
{
    public class Uyruklar
    {

        [Key]
        public int UyrukID { get; set; }
        [Required]
        public string Uyruk { get; set; }
        public List<Kisiler> Kisiler { get; set; }
    }
}
