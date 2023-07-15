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
    public class ilcelerManager : IilcelerService

    {
        Iilceler _ilceler;
        public ilcelerManager(Iilceler ilceler)
        {
            _ilceler = ilceler;
        }

        public void Delete(ilceler p)
        {
            _ilceler.Delete(p); 
        }

        public List<ilceler> ilcelerGetList()
        {
            return _ilceler.List(); 
        }

        public void Insert(ilceler p)
        {
            _ilceler.Insert(p); 

        }

        public void Update(ilceler p)
        {
           _ilceler.Update(p);  
        }
    }
}
