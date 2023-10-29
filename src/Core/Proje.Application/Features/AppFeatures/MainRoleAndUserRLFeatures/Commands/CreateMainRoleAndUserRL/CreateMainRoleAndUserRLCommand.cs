using Proje.Application.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.AppFeatures.MainRoleAndUserRLFeatures.Commands.CreateMainRoleAndUserRL
{
    public sealed record CreateMainRoleAndUserRLCommand(
        string UserId,
        string MainRoleId,
        string CompanyId): ICommand<CreateMainRoleAndUserRLCommandResponse>;
}
