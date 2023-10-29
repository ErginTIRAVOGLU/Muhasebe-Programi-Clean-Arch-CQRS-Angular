using Moq;
using Proje.Application.Features.AppFeatures.UserAndCompanyRLFeatures.Commands.RemoveByIdUserAndCompanyRL;
using Proje.Application.Services.AppServices;
using Shouldly;

namespace Proje.UnitTest.Features.AppFeatures.UserAndCompanyRLFeatures
{
    public sealed class RemoveByIdUserAndCompanyRLCommandUnitTest
    {
        private readonly Mock<IUserAndCompanyRelationshipService> _serviceMock;

        public RemoveByIdUserAndCompanyRLCommandUnitTest()
        {
            _serviceMock = new();
        }

        [Fact]
        public async Task RemoveByIdUserAndCompanyRLCommandResponseShouldNotBeNull()
        {
            RemoveByIdUserAndCompanyRLCommand command = new(
                Id: "77B21D60-5E6E-4E86-A83E-618ED2E80088");

            RemoveByIdUserAndCompanyRLCommandHandler handler=new(_serviceMock.Object);
            RemoveByIdUserAndCompanyRLCommandResponse response = await handler.Handle(command, default);
            response.ShouldNotBeNull();
            response.Message.ShouldNotBeEmpty();
        }
    }
}
