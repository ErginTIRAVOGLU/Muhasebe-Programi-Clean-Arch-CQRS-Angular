using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateMainRole
{
    public sealed class CreateMainRoleCommandValidator:AbstractValidator<CreateMainRoleCommand>
    {
        public CreateMainRoleCommandValidator()
        {            
            RuleFor(p => p.Title).NotEmpty().WithMessage("Başlık boş olamaz");
            RuleFor(p => p.Title).NotNull().WithMessage("Başlık boş olamaz");
        }
    }
}
