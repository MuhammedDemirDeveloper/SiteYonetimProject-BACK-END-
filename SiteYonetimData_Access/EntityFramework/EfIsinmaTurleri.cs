using SiteYonetimData_Access.Abstract;
using SiteYonetimData_Access.Repostories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteYonetimModel.Models
{
    public class EfIsinmaTurleri : GenericRepostory<IsinmaTurleri>, IIsinmaTurleri
    {
       
    }
}
