using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyWebProject.Infrastructure.Migrations
{
    public partial class RemoveTheAbstractClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Size",
                table: "Mobilephones");

            migrationBuilder.AddColumn<string>(
                name: "CPU",
                table: "Mobilephones",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CPU",
                table: "Mobilephones");

            migrationBuilder.AddColumn<double>(
                name: "Size",
                table: "Mobilephones",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
