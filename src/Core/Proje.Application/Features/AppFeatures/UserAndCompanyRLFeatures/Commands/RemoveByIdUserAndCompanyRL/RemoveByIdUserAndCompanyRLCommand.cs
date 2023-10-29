using Proje.Application.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.AppFeatures.UserAndCompanyRLFeatures.Commands.RemoveByIdUserAndCompanyRL
{
    public sealed record RemoveByIdUserAndCompanyRLCommand(
        string Id):ICommand<RemoveByIdUserAndCompanyRLCommandResponse>;
}
