using MediatR;

namespace Proje.Application.Messaging
{
    public interface IQuery<out TResponse> : IRequest<TResponse>
    {

    }
}
