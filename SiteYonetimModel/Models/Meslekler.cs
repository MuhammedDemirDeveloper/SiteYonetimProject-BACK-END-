using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteYonetimModel.Models
{
    public class Meslekler
    {
        [Key]
        public int MeslekID { get; set; }

        [Required]
        public string Meslek { get; set; }
        public List<Kisiler> Kisiler { get; set; }
    }
}
