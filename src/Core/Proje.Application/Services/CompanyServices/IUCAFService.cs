using Proje.Application.Features.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF;

namespace Proje.Application.Services.CompanyServices
{
    public interface IUCAFService
    {
        Task CreateUcafAsync(CreateUCAFCommand request, CancellationToken cancellationToken);

    }
}
