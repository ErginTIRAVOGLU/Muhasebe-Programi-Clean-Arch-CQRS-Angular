using Moq;
using Proje.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using Proje.Application.Services.AppServices;
using Proje.Domain.AppEntities;
using Shouldly;

namespace Proje.UnitTest.Features.AppFeatures.CompanyFeatures.Commands
{
    public class CreateCompanyCommandUnitTest
    {
        private readonly Mock<ICompanyService> _companyService;

        public CreateCompanyCommandUnitTest()
        {
            _companyService = new();
        }

        [Fact]
        public async Task CompanyShouldBeNull()
        {
            Company company = (await _companyService.Object.GetCompanyByName("Ergin Ltd Şti Anonim"));

            company.ShouldBeNull();
        }

        [Fact]
        public async Task CreateCompanyCommandResponseShouldNotBeNull()
        {
            var command = new CreateCompanyCommand(Name: "Ergin Ltd Şti", ServerName: ".", "ErginTestMuhasebeDb", "sa", "159357Et!1");
            var handler = new CreateCompanyCommandHandler(_companyService.Object);
            CreateCompanyCommandResponse response = await handler.Handle(command, default);
            response.ShouldNotBeNull();
            response.Message.ShouldNotBeEmpty();
        }
    }
}
