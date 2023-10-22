using MediatR;
using Proje.Presentation.Abstraction; 

namespace Proje.Presentation.Controller;

public class UserAndCompanyRelationshipsController : ApiController
{
    public UserAndCompanyRelationshipsController(IMediator mediator) : base(mediator) {}
}
