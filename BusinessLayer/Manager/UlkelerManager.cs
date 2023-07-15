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
    public class UlkelerManager : IUlkelerService
    {
        IUlkeler _Ulkeler;
        public UlkelerManager(IUlkeler ulkeler)
        {
            _Ulkeler = ulkeler;
        }

        public void Delete(Ulkeler p)
        {
            _Ulkeler.Delete(p); 
        }

        public void Insert(Ulkeler p)
        {
            _Ulkeler.Insert(p); 
        }

        public List<Ulkeler> UlkelerGetList()
        {
            return _Ulkeler.List(); 
        }

        public void Update(Ulkeler p)
        {
            _Ulkeler.Update(p); 
        }
    }
}
