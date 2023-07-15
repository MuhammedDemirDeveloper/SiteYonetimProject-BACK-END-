using SiteYonetimModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBloklarService
    {

        List<Bloklar> BloklarGetList();
        void Insert(Bloklar p);
        void Update(Bloklar p);
        void Delete(Bloklar p);

    }
}
