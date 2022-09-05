using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class UserValidator:AbstractValidator<User>
	{
		public UserValidator()
		{
			RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı adı boş olamaz");
			RuleFor(x => x.UserSurname).NotEmpty().WithMessage("Kullanıcı soyadı boş olamaz");
			RuleFor(x => x.UserPassword).NotEmpty().WithMessage("şifre boş olamaz");

			RuleFor(x => x.UserName).MinimumLength(2).WithMessage("Kullanıcı adı en az 2 karakter olmalıdır");
			RuleFor(x => x.UserSurname).MinimumLength(2).WithMessage("Kullanıcı soyadı en az 2 karakter olmalıdır");
		}
	}
}
