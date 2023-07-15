using FluentValidation;
using SiteYonetimModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class SitelerValidator:AbstractValidator<Siteler>
    {
        public SitelerValidator()
        {
            RuleFor(x => x.SiteAdi).MinimumLength(5).MaximumLength(20).NotEmpty().WithMessage("Min(5),Max(20) Karakter Olmalıdır.Boş Bırakmayınız");
            RuleFor(x => x.SiteAdres).MaximumLength(100).NotEmpty().WithMessage("Max(100) Karakter Olmalıdır.Boş Bırakmayınız"); 

        }
    }
}
