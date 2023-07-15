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
    public class SozlesmeTarihleriManager : ISozlesmeTarihleriService
    {
        ISozlesmeTarihleri _SozlesmeTarihleri;
        public SozlesmeTarihleriManager(ISozlesmeTarihleri sozlesmeTarihleri)
        {
            _SozlesmeTarihleri = sozlesmeTarihleri;
        }
    
        public void Delete(SozlesmeTarihleri p)
        {
            _SozlesmeTarihleri.Delete(p); 
        }

        public void Insert(SozlesmeTarihleri p)
        {
            _SozlesmeTarihleri.Insert(p); 
        }

        public List<SozlesmeTarihleri> SozlesmeGetList()
        {
            return _SozlesmeTarihleri.List(); 
        }

        public void Update(SozlesmeTarihleri p)
        {
            _SozlesmeTarihleri.Update(p); 
        }
    }
}
