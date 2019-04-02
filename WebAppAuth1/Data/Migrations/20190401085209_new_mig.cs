using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppAuth1.Data.Migrations
{
    public partial class new_mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
               name: "DomainServices",
               columns: table => new
               {
                   ServiceId = table.Column<int>(nullable: false),
                   ServiceName = table.Column<string>(maxLength: 256, nullable: true)
               });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DomainServices");
        }
    }
}
