﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.AppFeatures.MainRoleAndUserRLFeatures.Commands.CreateMainRoleAndUserRL
{
    public class CreateMainRoleAndUserRLCommandValidator:AbstractValidator<CreateMainRoleAndUserRLCommand>
    {
        public CreateMainRoleAndUserRLCommandValidator()
        {
            RuleFor(p => p.UserId).NotEmpty().WithMessage("Kullanıcı seçmelisiniz");
            RuleFor(p => p.UserId).NotNull().WithMessage("Kullanıcı seçmelisiniz");

            RuleFor(p => p.CompanyId).NotEmpty().WithMessage("Şirket seçmelisiniz");
            RuleFor(p => p.CompanyId).NotNull().WithMessage("Şirket seçmelisiniz");

            RuleFor(p => p.MainRoleId).NotEmpty().WithMessage("Rol seçmelisiniz");
            RuleFor(p => p.MainRoleId).NotNull().WithMessage("Rol seçmelisiniz");
        }
    }
}
