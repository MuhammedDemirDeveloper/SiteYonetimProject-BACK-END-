using SiteYonetimModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMesleklerService
    {
        List<Meslekler> MesleklerGetList();
        void Insert(Meslekler p);
        void Update(Meslekler p);
        void Delete(Meslekler p);
    }
}
