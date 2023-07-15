using FluentValidation;
using SiteYonetimModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public  class ilcelerValidator:AbstractValidator<ilceler>
    {
        public ilcelerValidator()
        {
            RuleFor(x => x.ilceAdi).MinimumLength(3).MaximumLength(10).NotEmpty().WithMessage("Min(3),Max(10) Karakter olmalıdır.Boş bırakmayınız."); 

        }
    }
}
