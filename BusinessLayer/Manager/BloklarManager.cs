using BusinessLayer.Abstract;
using SiteYonetimData_Access.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiteYonetimModel.Models
{
    public class BloklarManager : IBloklarService
    
    {
        IBloklar _Bloklar;
        public BloklarManager(IBloklar bloklar)
        {
            _Bloklar = bloklar;
        }

        public List<Bloklar> BloklarGetList()
        {
            return _Bloklar.List();
        }

        public void Delete(Bloklar p)
        {
             _Bloklar.Delete(p); 
        }

        public void Insert(Bloklar p)
        {
            _Bloklar.Insert(p);
        }

        public void Update(Bloklar p)
        {
            _Bloklar.Update(p); 
        }
    }
}
