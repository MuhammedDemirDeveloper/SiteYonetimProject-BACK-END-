using FluentValidation;
using SiteYonetimModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class UyruklarValidator:AbstractValidator<Uyruklar>
    {
        public UyruklarValidator()
        {
            RuleFor(x => x.Uyruk).MinimumLength(3).MaximumLength(10).NotEmpty().WithMessage("Min(3),Max(10) Karakter Olmalıdır.Boş Bırakmayınız"); 

        }
    }
}
