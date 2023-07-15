using SiteYonetimModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IDairelerService

    {
        List<Daireler> DairelerGetList();
        void Insert(Daireler p);
        void Update(Daireler p);
        void Delete(Daireler p);
    }
}
