using SiteYonetimModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICinsiyetService


    {
        List<Cinsiyetler> CinsiyetlerGetList();
        void Insert(Cinsiyetler p);
        void Update(Cinsiyetler p);
        void Delete(Cinsiyetler p);
    }
}
