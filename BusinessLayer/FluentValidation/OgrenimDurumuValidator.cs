using FluentValidation;
using SiteYonetimModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class OgrenimDurumuValidator:AbstractValidator<OgrenimDurumu>
    {
        public OgrenimDurumuValidator()
        {
            RuleFor(x => x.Ogrenim).MinimumLength(5).MaximumLength(20).NotEmpty().WithMessage("Min(5),Max(20) Karakter Olmalıdır.Boş Bırakmayınız"); 
            
        }
    }
}
