using SiteYonetimModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IPersonellerService

    {
        List<Personeller> PersonellerGetList();
        void Insert(Personeller p);
        void Update(Personeller p);
        void Delete(Personeller p);
    }
}
