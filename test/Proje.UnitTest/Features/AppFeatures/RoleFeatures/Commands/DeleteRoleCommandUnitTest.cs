using Moq;
using Proje.Application.Features.AppFeatures.RoleFeatures.Commands.DeleteRole;
using Proje.Application.Services.AppServices;
using Proje.Domain.AppEntities.Identity;
using Shouldly;

namespace Proje.UnitTest.Features.AppFeatures.RoleFeatures.Commands
{
    public sealed class DeleteRoleCommandUnitTest
    {
        private readonly Mock<IRoleService> _roleServiceMock;

        public DeleteRoleCommandUnitTest()
        {
            _roleServiceMock = new();
        }

        [Fact]
        public async Task AppRoleShouldNotBeNull()
        {
            _roleServiceMock.Setup(
                x=>x.GetById(It.IsAny<string>()))
                .ReturnsAsync(new AppRole());

        }

        [Fact]
        public async Task DeleteRoleCommandResponseShouldNotBeNull()
        {
            var command = new DeleteRoleCommand(
                Id: "1133446C-8C76-4863-BA6D-4B473C919024");

            _roleServiceMock.Setup(
                x => x.GetById(It.IsAny<string>()))
                .ReturnsAsync(new AppRole());

            var handler = new DeleteRoleCommandHandler(_roleServiceMock.Object);
            DeleteRoleCommandResponse response = await handler.Handle(command, default);
            response.ShouldNotBeNull();
            response.Message.ShouldNotBeEmpty();
             
        }
    }
}
