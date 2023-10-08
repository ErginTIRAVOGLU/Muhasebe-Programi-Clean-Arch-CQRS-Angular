using Proje.Application.Messaging;

namespace Proje.Application.Features.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF
{
    public sealed record CreateUCAFCommand(string CompanyId, string Code, string Name, char Type) : ICommand<CreateUCAFCommandResponse>;//AnaGrup,Grup,Muavin
}
