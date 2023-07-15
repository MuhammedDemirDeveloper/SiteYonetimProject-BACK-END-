using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using SiteYonetimData_Access.Abstract;

namespace SiteYonetimModel.Models
{
    public class CinsiyetlerManager : ICinsiyetService
    {
        ICinsiyetler _Cinsyetler;
        public CinsiyetlerManager(ICinsiyetler cinsyetler)
        {
            _Cinsyetler = cinsyetler;
        }
    
        public List<Cinsiyetler> CinsiyetlerGetList()
        {
            return _Cinsyetler.List(); 
        }

        public void Delete(Cinsiyetler p)
        {
            _Cinsyetler.Delete(p); 

        }

        public void Insert(Cinsiyetler p)
        {
            _Cinsyetler.Insert(p);
        }

        public void Update(Cinsiyetler p)
        {
            _Cinsyetler.Update(p); 
        }
    }
}
