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
    public class iletisimDilleriManager : IiletisimDilleriService
    {
        IiletisimDilleri _iletisimDilleri;
      
        public iletisimDilleriManager(IiletisimDilleri iletisimDilleri)
        {
            _iletisimDilleri = iletisimDilleri;
        }



    
        public void Delete(iletisimDilleri p)
        {
            _iletisimDilleri.Delete(p); 
        }

        public List<iletisimDilleri> iletişimDilleriGetList()
        {
            return _iletisimDilleri.List(); 

        }

        public void Insert(iletisimDilleri p)
        {
            _iletisimDilleri.Insert(p); 
        }

        public void Update(iletisimDilleri p)
        {
            _iletisimDilleri.Update(p);
        }
    }
}
