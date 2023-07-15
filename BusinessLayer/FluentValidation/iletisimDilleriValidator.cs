using FluentValidation;
using SiteYonetimModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class iletisimDilleriValidator:AbstractValidator<iletisimDilleri>

    {
        public iletisimDilleriValidator()
        {
            RuleFor(x => x.Dil).MinimumLength(3).MaximumLength(10).NotEmpty().WithMessage("Min(3),Max(10) Karakter olmalıdır.Boş Bırakmayınız."); 

        }
    }
}
