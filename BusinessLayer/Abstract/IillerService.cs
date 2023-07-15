using SiteYonetimModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IillerService
    {
        List<iller> illerGetList();
        void Insert(iller p);
        void Update(iller p);
        void Delete(iller p);
    }
}
