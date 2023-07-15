using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiteYonetimModel.Models
{
    public class Daireler
    {
        [Key]
        public int DaireID { get; set; }

        [Required]
        public string DaireTanim { get; set; }

        [Required]
        public int DaireOdaSayisi { get; set; }
       
        [ForeignKey("Bloklar")]
        public int? BlokID { get; set; }
       
        public Bloklar Bloklar { get; set; }
        public List<Kisiler> Kisiler { get; set; }
    }
}
