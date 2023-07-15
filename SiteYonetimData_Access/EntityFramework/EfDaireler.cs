using SiteYonetimData_Access.Abstract;
using SiteYonetimData_Access.Repostories;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiteYonetimModel.Models
{
    public class EfDaireler : GenericRepostory<Daireler>, IDaireler
    {
      
    }
}
