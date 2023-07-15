using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SiteYonetimData_Access.Migrations
{
    public partial class EklePersonelerTablosuPersonelTelSutunu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "PersonelTel",
                table: "tb_Personeller",
                type: "bigint",
                maxLength: 10,
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PersonelTel",
                table: "tb_Personeller");
        }
    }
}
