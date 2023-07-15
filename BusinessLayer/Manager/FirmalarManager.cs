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
    public class FirmalarManager : IFirmalarService
    {
        IFirmalar _Firmalar;
        public FirmalarManager(IFirmalar firmalar)
        {
            _Firmalar = firmalar;
        }
    
        public void Delete(Firmalar p)
        {
           _Firmalar.Delete(p); 
        }

        public List<Firmalar> FirmalarGetList()
        {
            return _Firmalar.List(); 
        }

        public void Insert(Firmalar p)
        {
            _Firmalar.Insert(p); 
        }

        public void Update(Firmalar p)
        {
           _Firmalar.Update(p); 
        }
    }
}
