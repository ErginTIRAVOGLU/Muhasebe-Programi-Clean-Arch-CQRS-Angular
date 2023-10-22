using Proje.Application.Messaging;
using Proje.Domain.AppEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Proje.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateStaticMainRoles
{
    public sealed record CreateStaticMainRolesCommand(
        List<MainRole> MainRoles):ICommand<CreateStaticMainRolesCommandResponse>;
    
}
