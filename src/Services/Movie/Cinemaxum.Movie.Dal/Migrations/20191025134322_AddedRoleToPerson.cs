using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinemaxum.Movie.Dal.Migrations
{
    public partial class AddedRoleToPerson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Persons",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "Persons");
        }
    }
}
