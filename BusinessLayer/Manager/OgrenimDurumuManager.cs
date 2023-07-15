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
    public class OgrenimDurumuManager : IOgrenimDurumuService
    {
        IOgrenimDurumu _OgrenimDurumu;
        public OgrenimDurumuManager(IOgrenimDurumu ogrenimDurumu)
        {
            _OgrenimDurumu = ogrenimDurumu;
        }
    
        public void Delete(OgrenimDurumu p)
        {
            _OgrenimDurumu.Delete(p); 
        }

        public void Insert(OgrenimDurumu p)
        {
            _OgrenimDurumu.Insert(p); 
        }

        public List<OgrenimDurumu> OgrenimDurumuGetList()
        {
            return _OgrenimDurumu.List(); 
        }

        public void Update(OgrenimDurumu p)
        {
            _OgrenimDurumu.Update(p); 
        }
    }
}
