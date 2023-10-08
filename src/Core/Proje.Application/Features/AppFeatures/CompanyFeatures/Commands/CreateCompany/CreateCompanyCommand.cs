using Proje.Application.Messaging;

namespace Proje.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany
{
    public sealed record CreateCompanyCommand(
         string Name, 
         string ServerName, 
         string DatabaseName, 
         string UserName, 
         string ServerPassword) :ICommand<CreateCompanyCommandResponse>;
    
         
}
