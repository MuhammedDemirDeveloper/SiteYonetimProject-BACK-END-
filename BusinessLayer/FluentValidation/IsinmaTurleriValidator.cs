using FluentValidation;
using SiteYonetimModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class IsinmaTurleriValidator:AbstractValidator<IsinmaTurleri>
    {
        public IsinmaTurleriValidator()
        {
            RuleFor(x => x.IsinmaTuru).MinimumLength(3).MaximumLength(15).NotEmpty().WithMessage("Min(3),Max(15) Karakter olmalıdır.Boş bırakmayınız."); 

        }
    }
}
