using BusinessLayer.Abstract;
using SiteYonetimData_Access.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteYonetimModel.Models
{
    public class MesleklerManager : IMesleklerService
    {
        IMeslekler _Meslekler;
        public MesleklerManager(IMeslekler meslekler)
        {
            _Meslekler = meslekler;
        }
        
        public void Delete(Meslekler p)
        {
            _Meslekler.Delete(p); 
        }

        public void Insert(Meslekler p)
        {
            _Meslekler.Insert(p); 
        }

        public List<Meslekler> MesleklerGetList()
        {
            return _Meslekler.List(); 

        }

        public void Update(Meslekler p)
        {
            _Meslekler.Update(p); 
        }
    }
}
