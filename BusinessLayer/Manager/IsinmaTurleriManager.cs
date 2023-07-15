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
    public class IsinmaTurleriManager : IIsinmaTurleriService
    {
        IIsinmaTurleri _IsinmaTurleri;
        public IsinmaTurleriManager(IIsinmaTurleri ısinmaTurleri)
        {
            _IsinmaTurleri = ısinmaTurleri;
        }
    
        public void Delete(IsinmaTurleri p)
        {
            _IsinmaTurleri.Delete(p);
        }

        public void Insert(IsinmaTurleri p)
        {
            _IsinmaTurleri.Insert(p); 
        }

        public List<IsinmaTurleri> IsinmaTurleriGetList()
        {
            return _IsinmaTurleri.List(); 
        }

        public void Update(IsinmaTurleri p)
        {
            _IsinmaTurleri.Update(p); 
        }
    }
}
