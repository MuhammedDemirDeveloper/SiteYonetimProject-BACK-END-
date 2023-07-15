using FluentValidation;
using SiteYonetimModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class SozlesmeTarihleriValidator:AbstractValidator<SozlesmeTarihleri>

    {
        public SozlesmeTarihleriValidator()
        {
            RuleFor(x => x.Tarih).NotEmpty().WithMessage("Sözleşme Tarihi Alanını Boş Bırakmayınız."); 

        }
    }
}
