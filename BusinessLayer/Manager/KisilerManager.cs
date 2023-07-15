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
    public class KisilerManager : IKisilerService

    {
        IKisiler _kisiler;
        public KisilerManager(IKisiler kisiler)
        {
            _kisiler = kisiler;
        }
    
        public void Delete(Kisiler p)
        {
            _kisiler.Delete(p); 
        }

        public void Insert(Kisiler p)
        {
            _kisiler.Insert(p); 
        }

        public List<Kisiler> KisilerGetList()
        {
            return _kisiler.List(); 
        }

        public void Update(Kisiler p)
        {
            _kisiler.Update(p); 
        }
    }
}
