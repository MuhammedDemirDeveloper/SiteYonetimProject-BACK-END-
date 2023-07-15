using SiteYonetimModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IKisilerService
    {
        List<Kisiler> KisilerGetList();
        void Insert(Kisiler p);
        void Update(Kisiler p);
        void Delete(Kisiler p);
    }
}
