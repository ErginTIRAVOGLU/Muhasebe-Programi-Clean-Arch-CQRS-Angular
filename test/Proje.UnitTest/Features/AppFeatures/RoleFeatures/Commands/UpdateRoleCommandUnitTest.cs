using Moq;
using Proje.Application.Features.AppFeatures.RoleFeatures.Commands.UpdateRole;
using Proje.Application.Services.AppServices;
using Proje.Domain.AppEntities.Identity;
using Shouldly;

namespace Proje.UnitTest.Features.AppFeatures.RoleFeatures.Commands
{
    public sealed class UpdateRoleCommandUnitTest
    {
        private readonly Mock<IRoleService> _roleServiceMock;


        public UpdateRoleCommandUnitTest()
        {
            _roleServiceMock = new();
        }

        [Fact]
        public async Task AppRoleShouldBeNull()
        {
            _ =  _roleServiceMock.Setup(
                x=>x.GetById(It.IsAny<string>()))
                .ReturnsAsync(new AppRole());
            
        }
        [Fact]
        public async Task AppRoleCodeShouldBeUnique()
        {
            AppRole checkRoleCode = await _roleServiceMock.Object.GetByCode("UCAF.Create");
            checkRoleCode.ShouldBeNull();

        }

        [Fact]
        public async Task UpdateRoleCommandResponseShouldNotBeNull()
        {
            var command = new UpdateRoleCommand(Name: "Hesap planı test ekleme", Code: "UCAF.Create",Id: "e49d3bf7-ec2c-4743-ae45-eeabe01f08f5");
            _roleServiceMock.Setup(
               x => x.GetById(It.IsAny<string>()))
               .ReturnsAsync(new AppRole());
            var handler = new UpdateRoleCommandHandler(_roleServiceMock.Object);

            UpdateRoleCommandResponse response = await handler.Handle(command, default);
            response.ShouldNotBeNull();
            response.Message.ShouldNotBeEmpty();

        }
        
    }
}
