using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateMainRole
{
    public sealed record CreateMainRoleCommandResponse(
        string Message = "Ana rol kaydı başarıyla tamamlandı.");
}
