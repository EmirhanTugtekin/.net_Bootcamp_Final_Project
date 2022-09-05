using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class CompanyValidator: AbstractValidator<Company>
	{
		public CompanyValidator()
		{
            RuleFor(x => x.CompanyName).NotEmpty().WithMessage("Kullanıcı adı boş olamaz");
            RuleFor(x => x.CompanyWebSite).NotEmpty().WithMessage("Kullanıcı soyadı boş olamaz");
            RuleFor(x => x.CompanyPassword).NotEmpty().WithMessage("şifre boş olamaz");

            RuleFor(x => x.CompanyName).MinimumLength(2).WithMessage("Kullanıcı adı en az 2 karakter olmalıdır");
            RuleFor(x => x.CompanyWebSite).MinimumLength(2).WithMessage("Kullanıcı soyadı en az 2 karakter olmalıdır");
        }
	}
}
