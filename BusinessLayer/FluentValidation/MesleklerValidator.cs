using FluentValidation;
using SiteYonetimModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class MesleklerValidator:AbstractValidator<Meslekler>
    {
        public MesleklerValidator()
        {
            RuleFor(x => x.Meslek).MinimumLength(5).MinimumLength(20).NotEmpty().WithMessage("Min(5),Max(20) Karakter Olmalıdır.Boş Bırakmayınız"); 
         
        }
    }
}
