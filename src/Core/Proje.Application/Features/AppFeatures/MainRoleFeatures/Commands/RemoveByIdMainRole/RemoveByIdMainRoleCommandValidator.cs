﻿using FluentValidation;
using Proje.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateMainRole;
using Proje.Application.Features.AppFeatures.MainRoleFeatures.Commands.RemoveMainRole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.AppFeatures.MainRoleFeatures.Commands.RemoveByIdMainRole
{
    public sealed class RemoveByIdMainRoleCommandValidator : AbstractValidator<RemoveByIdMainRoleCommand>
    {
        public RemoveByIdMainRoleCommandValidator()
        {
            RuleFor(p => p.Id).NotEmpty().WithMessage("Id alanı boş olamaz");
            RuleFor(p => p.Id).NotNull().WithMessage("Id alanı boş olamaz");
        }
    }
}
