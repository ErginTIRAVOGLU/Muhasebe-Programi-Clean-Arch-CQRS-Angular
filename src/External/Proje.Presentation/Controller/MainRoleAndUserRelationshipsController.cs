using MediatR;
using Proje.Presentation.Abstraction; 

namespace Proje.Presentation.Controller;

public class MainRoleAndUserRelationshipsController : ApiController
{
    public MainRoleAndUserRelationshipsController(IMediator mediator) : base(mediator) {}
}
