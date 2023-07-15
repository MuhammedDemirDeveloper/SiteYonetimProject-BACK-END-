using SiteYonetimModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ISozlesmeTarihleriService
    {
        List<SozlesmeTarihleri> SozlesmeGetList();
        void Insert(SozlesmeTarihleri p);
        void Update(SozlesmeTarihleri p);
        void Delete(SozlesmeTarihleri p);
    }
}
