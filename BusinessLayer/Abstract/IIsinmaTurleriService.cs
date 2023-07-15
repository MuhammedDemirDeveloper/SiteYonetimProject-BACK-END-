using SiteYonetimModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IIsinmaTurleriService
    {
        List<IsinmaTurleri> IsinmaTurleriGetList();
        void Insert(IsinmaTurleri p);
        void Update(IsinmaTurleri p);
        void Delete(IsinmaTurleri p);
    }
}
