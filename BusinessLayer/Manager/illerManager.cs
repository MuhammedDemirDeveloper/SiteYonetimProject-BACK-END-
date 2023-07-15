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
    public class illerManager : IillerService
    {
        Iiller _iller;
        public illerManager(Iiller iller)
        {
            _iller = iller;
        }
    
        public void Delete(iller p)
        {
            _iller.Delete(p);   
        }

        public List<iller> illerGetList()
        {
            return _iller.List();
        }

        public void Insert(iller p)
        {
            _iller.Insert(p); 
        }

        public void Update(iller p)
        {
            _iller.Update(p); 
        }
    }
}
