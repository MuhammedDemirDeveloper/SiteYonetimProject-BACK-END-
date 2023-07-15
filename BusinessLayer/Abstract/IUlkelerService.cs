using SiteYonetimModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IUlkelerService
    {
        List<Ulkeler> UlkelerGetList();
        void Insert(Ulkeler p);
        void Update(Ulkeler p);
        void Delete(Ulkeler p);
    }
}
