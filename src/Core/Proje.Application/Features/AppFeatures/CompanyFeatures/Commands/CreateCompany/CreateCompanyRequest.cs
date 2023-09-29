using MediatR;

namespace Proje.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany
{
    public sealed class CreateCompanyRequest:IRequest<CreateCompanyResponse>
    {
        public string Name { get; set; }       
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string UserName { get; set; }
        public string ServerPassword { get; set; }
    }
}
