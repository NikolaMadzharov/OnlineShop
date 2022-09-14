using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyWebProject.Infrastructure.Migrations
{
    public partial class CreatedModelsForEachEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Model",
                table: "Mobilephones");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Cases");

            migrationBuilder.RenameColumn(
                name: "Model",
                table: "Protectors",
                newName: "Url");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Protectors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Protectors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Protectors",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "CaseModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CaseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CaseModel_Cases_CaseId",
                        column: x => x.CaseId,
                        principalTable: "Cases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhoneModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobilephoneId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhoneModel_Mobilephones_MobilephoneId",
                        column: x => x.MobilephoneId,
                        principalTable: "Mobilephones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProtectorModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProtectorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProtectorModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProtectorModel_Protectors_ProtectorId",
                        column: x => x.ProtectorId,
                        principalTable: "Protectors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CaseModel_CaseId",
                table: "CaseModel",
                column: "CaseId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneModel_MobilephoneId",
                table: "PhoneModel",
                column: "MobilephoneId");

            migrationBuilder.CreateIndex(
                name: "IX_ProtectorModel_ProtectorId",
                table: "ProtectorModel",
                column: "ProtectorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CaseModel");

            migrationBuilder.DropTable(
                name: "PhoneModel");

            migrationBuilder.DropTable(
                name: "ProtectorModel");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Protectors");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Protectors");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Protectors");

            migrationBuilder.RenameColumn(
                name: "Url",
                table: "Protectors",
                newName: "Model");

            migrationBuilder.AddColumn<double>(
                name: "Model",
                table: "Mobilephones",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Cases",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
