using Moq;
using Proje.Application.Features.AppFeatures.RoleFeatures.Commands.CreateRole;
using Proje.Application.Services.AppServices;
using Proje.Domain.AppEntities.Identity;
using Shouldly;

namespace Proje.UnitTest.Features.AppFeatures.RoleFeatures.Commands
{
    public sealed class CreateRoleCommandUnitTest
    {
        private readonly Mock<IRoleService> _roleServiceMock;
        

        public CreateRoleCommandUnitTest()
        {
            _roleServiceMock = new();
        }

        [Fact]
        public async Task AppRoleShouldBeNull()
        {
            AppRole appRole = await _roleServiceMock.Object.GetByCode("UCAF.Create");
            appRole.ShouldBeNull();
        }

        [Fact]
        public async Task CreateRoleCommandResponseShouldNotBeNull()
        {
            var command = new CreateRoleCommand(Name: "Hesap planı test ekleme", Code: "UCAF.Create");

            var handler = new CreateRoleCommandHandler(_roleServiceMock.Object);

            CreateRoleCommandResponse response = await handler.Handle(command, default);
            response.ShouldNotBeNull();
            response.Message.ShouldNotBeEmpty();

        }
    }
}
