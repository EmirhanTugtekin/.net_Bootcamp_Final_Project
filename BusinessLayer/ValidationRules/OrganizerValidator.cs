using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class OrganizerValidator:AbstractValidator<Organizer>
	{
		public OrganizerValidator()
		{
            RuleFor(x => x.OrganizerName).NotEmpty().WithMessage("Kullanıcı adı boş olamaz");
            RuleFor(x => x.OrganizerSurname).NotEmpty().WithMessage("Kullanıcı soyadı boş olamaz");
            RuleFor(x => x.OrganizerPassword).NotEmpty().WithMessage("şifre boş olamaz");

            RuleFor(x => x.OrganizerName).MinimumLength(2).WithMessage("Kullanıcı adı en az 2 karakter olmalıdır");
            RuleFor(x => x.OrganizerSurname).MinimumLength(2).WithMessage("Kullanıcı soyadı en az 2 karakter olmalıdır");
        }
	}
}
