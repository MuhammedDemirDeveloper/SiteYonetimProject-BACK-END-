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
    public class PersonellerManager : IPersonellerService
    {
        IPersoneller _Personeller;
        public PersonellerManager(IPersoneller personeller)
        {
            _Personeller = personeller;
        }
    
        public void Delete(Personeller p)
        {
            _Personeller.Delete(p); 
        }

        public void Insert(Personeller p)
        {
            _Personeller.Insert(p); 
        }

        public List<Personeller> PersonellerGetList()
        {
            return _Personeller.List();
        }

        public void Update(Personeller p)
        {
            _Personeller.Update(p); 
        }
    }
}
