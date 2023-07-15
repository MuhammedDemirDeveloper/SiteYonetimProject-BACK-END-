using SiteYonetimModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IOgrenimDurumuService
    {
        List<OgrenimDurumu> OgrenimDurumuGetList();
        void Insert(OgrenimDurumu p);
        void Update(OgrenimDurumu p);
        void Delete(OgrenimDurumu p);
    }
}
