
using SiteYonetimModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IiletisimDilleriService

    {
        List<iletisimDilleri> iletişimDilleriGetList();
        void Insert(iletisimDilleri p);
        void Update(iletisimDilleri p);
        void Delete(iletisimDilleri p);


    }
}
