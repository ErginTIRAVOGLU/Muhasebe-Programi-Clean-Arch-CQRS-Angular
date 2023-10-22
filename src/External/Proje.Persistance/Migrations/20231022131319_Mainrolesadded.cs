using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proje.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class Mainrolesadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsRoleCreatedById",
                table: "MainRoles",
                newName: "IsRoleCreatedByAdmin");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsRoleCreatedByAdmin",
                table: "MainRoles",
                newName: "IsRoleCreatedById");
        }
    }
}
