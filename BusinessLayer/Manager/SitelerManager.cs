using BusinessLayer.Abstract;
using SiteYonetimData_Access.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteYonetimModel.Models
{
    public class SitelerManager : ISitelerService
    {
        ISiteler _Siteler;
        public SitelerManager(ISiteler siteler)
        {
            _Siteler = siteler;
        }
    
        public void Delete(Siteler p)
        {
            _Siteler.Delete(p); 
        }

        public void Insert(Siteler p)
        {
            _Siteler.Insert(p); 
        }

        public List<Siteler> SitelerGetList()
        {
            return _Siteler.List(); 
        }

        public void Update(Siteler p)
        {
            _Siteler.Update(p); 

        }
    }
}
