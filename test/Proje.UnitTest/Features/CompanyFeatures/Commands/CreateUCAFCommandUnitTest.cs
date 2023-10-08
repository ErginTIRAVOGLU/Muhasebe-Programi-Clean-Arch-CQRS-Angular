using Moq;
using Proje.Application.Features.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF;
using Proje.Application.Services.CompanyServices;
using Proje.Domain.CompanyEntities;
using Shouldly;

namespace Proje.UnitTest.Features.CompanyFeatures.Commands
{
    public sealed class CreateUCAFCommandUnitTest
    {
        private readonly Mock<IUCAFService> _ucafService;

        public CreateUCAFCommandUnitTest()
        {
            _ucafService = new();
        }

        [Fact]
        public async Task UCAFShouldBeNull()
        {
            UniformCartOfAccount ucaf = await _ucafService.Object.GetByCode("100.01.001");
            ucaf.ShouldBeNull();

        }

        [Fact]
        public async Task CreateUCAFCommandResponseShouldNotBeNull()
        {
            var command = new CreateUCAFCommand(
                Code: "100.01.001",
                Name: "TL Kasa",
                Type: 'M',
                CompanyId: "2AAC3621-FA37-4157-9457-ACBAC3DD83FB");

            var handler = new CreateUCAFCommandHandler(_ucafService.Object);

            CreateUCAFCommandResponse response = await handler.Handle(command, default);
            response.ShouldNotBeNull();
            response.Message.ShouldNotBeEmpty();

        }
    }
}
