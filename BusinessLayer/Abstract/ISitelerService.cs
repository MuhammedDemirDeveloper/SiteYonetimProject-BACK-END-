using SiteYonetimModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ISitelerService
    {
        List<Siteler> SitelerGetList();
        void Insert(Siteler p);
        void Update(Siteler p);
        void Delete(Siteler p);
    }
}
