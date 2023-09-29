using MediatR;
using Proje.Application.Messaging;
using Proje.Application.Services.CompanyServices;

namespace Proje.Application.Features.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF
{
    public sealed class CreateUCAFCommandHandler : ICommandHandler<CreateUCAFCommand, CreateUCAFCommandResponse>
    {
        private readonly IUCAFService _ucafService;

        public CreateUCAFCommandHandler(IUCAFService ucafService)
        {
            _ucafService = ucafService;
        }

        public async Task<CreateUCAFCommandResponse> Handle(CreateUCAFCommand request, CancellationToken cancellationToken)
        {
            await _ucafService.CreateUcafAsync(request,cancellationToken);
            return new();
        }
    }
}
