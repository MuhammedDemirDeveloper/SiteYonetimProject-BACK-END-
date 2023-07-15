using SiteYonetimModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IFirmalarService
    {
        List<Firmalar> FirmalarGetList();
        void Insert(Firmalar p);
        void Update(Firmalar p);
        void Delete(Firmalar p);
    }
}
