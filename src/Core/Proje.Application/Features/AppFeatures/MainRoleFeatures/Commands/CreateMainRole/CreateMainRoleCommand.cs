using Proje.Application.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Proje.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateMainRole
{
    public sealed record CreateMainRoleCommand(
        string Title,      
        string CompanyId = null) : ICommand<CreateMainRoleCommandResponse>;

}
