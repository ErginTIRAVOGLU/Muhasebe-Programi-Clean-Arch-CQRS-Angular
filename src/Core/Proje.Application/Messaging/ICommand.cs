using MediatR;

namespace Proje.Application.Messaging
{
    public interface ICommand<out TResponse>:IRequest<TResponse>
    {
    }
}
