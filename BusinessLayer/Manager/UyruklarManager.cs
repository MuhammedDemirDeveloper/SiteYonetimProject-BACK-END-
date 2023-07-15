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
    public class UyruklarManager : IUyruklarService
    {
        IUyruklar _Uyruklar;
        public UyruklarManager(IUyruklar uyruklar)
        {
            _Uyruklar = uyruklar;
        }

        public void Delete(Uyruklar p)
        {
            _Uyruklar.Delete(p); 
        }

        public void Insert(Uyruklar p)
        {
            _Uyruklar.Insert(p); 
        }

        public void Update(Uyruklar p)
        {
            _Uyruklar.Update(p); 
        }

        public List<Uyruklar> UyruklarGetList()
        {
            return _Uyruklar.List(); 
        }
    }
}
