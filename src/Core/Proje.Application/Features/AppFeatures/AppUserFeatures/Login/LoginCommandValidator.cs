using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.AppFeatures.AppUserFeatures.Login
{
    public sealed class LoginCommandValidator : AbstractValidator<LoginCommand>
    {
        public LoginCommandValidator()
        {
            RuleFor(p => p.EmailOrUsername).NotEmpty().NotNull().WithMessage("Mail yada Kullanıcı adı boş olamaz.");
            RuleFor(p => p.EmailOrUsername).NotNull().WithMessage("Mail yada Kullanıcı adı boş olamaz.");
            RuleFor(p => p.Password).NotEmpty().WithMessage("Şifre boş olamaz.");
            RuleFor(p => p.Password).NotNull().WithMessage("Şifre boş olamaz.");
            RuleFor(p => p.Password).MinimumLength(6).WithMessage("Şifre enaz 6 karakter olmalı.");
            RuleFor(p => p.Password).Matches("[A-Z]").WithMessage("Şifre büyük harf içermeli");
            RuleFor(p => p.Password).Matches("[a-z]").WithMessage("Şifre küçük harf içermeli");
            RuleFor(p => p.Password).Matches("[0-9]").WithMessage("Şifre sayı harf içermeli");
            RuleFor(p => p.Password).Matches("[a-zA-Z0-9]").WithMessage("Şifre özel karakter içermeli");

        }
    }
}
