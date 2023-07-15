using SiteYonetimModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IUyruklarService
    {
        List<Uyruklar>UyruklarGetList();
        void Insert(Uyruklar p);
        void Update(Uyruklar p);
        void Delete(Uyruklar p);
    }
}
