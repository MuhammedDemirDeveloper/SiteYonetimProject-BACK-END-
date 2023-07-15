using BusinessLayer.Abstract;
using SiteYonetimData_Access.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiteYonetimModel.Models
{
    public class DairelerManager : IDairelerService


    {
        IDaireler _Daireler;
        public DairelerManager(IDaireler daireler)
        {
            _Daireler = daireler;
        }
    
        public List<Daireler> DairelerGetList()
        {
            return _Daireler.List(); 
        }

        public void Delete(Daireler p)
        {
            _Daireler.Delete(p); 
        }

        public void Insert(Daireler p)
        {
            _Daireler.Insert(p); 
        }

        public void Update(Daireler p)
        {
            _Daireler.Update(p); 
        }
    }
}
