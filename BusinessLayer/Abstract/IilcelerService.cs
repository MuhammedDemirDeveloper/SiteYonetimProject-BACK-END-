using SiteYonetimModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IilcelerService
    {
        List<ilceler> ilcelerGetList();
        void Insert(ilceler p);
        void Update(ilceler p);
        void Delete(ilceler p);
    }
}
