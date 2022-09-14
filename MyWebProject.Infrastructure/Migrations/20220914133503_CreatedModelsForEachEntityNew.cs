using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyWebProject.Infrastructure.Migrations
{
    public partial class CreatedModelsForEachEntityNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CaseModel_Cases_CaseId",
                table: "CaseModel");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneModel_Mobilephones_MobilephoneId",
                table: "PhoneModel");

            migrationBuilder.DropForeignKey(
                name: "FK_ProtectorModel_Protectors_ProtectorId",
                table: "ProtectorModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProtectorModel",
                table: "ProtectorModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PhoneModel",
                table: "PhoneModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CaseModel",
                table: "CaseModel");

            migrationBuilder.RenameTable(
                name: "ProtectorModel",
                newName: "ProtectedModels");

            migrationBuilder.RenameTable(
                name: "PhoneModel",
                newName: "PhoneModels");

            migrationBuilder.RenameTable(
                name: "CaseModel",
                newName: "CaseModels");

            migrationBuilder.RenameIndex(
                name: "IX_ProtectorModel_ProtectorId",
                table: "ProtectedModels",
                newName: "IX_ProtectedModels_ProtectorId");

            migrationBuilder.RenameIndex(
                name: "IX_PhoneModel_MobilephoneId",
                table: "PhoneModels",
                newName: "IX_PhoneModels_MobilephoneId");

            migrationBuilder.RenameIndex(
                name: "IX_CaseModel_CaseId",
                table: "CaseModels",
                newName: "IX_CaseModels_CaseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProtectedModels",
                table: "ProtectedModels",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PhoneModels",
                table: "PhoneModels",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CaseModels",
                table: "CaseModels",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CaseModels_Cases_CaseId",
                table: "CaseModels",
                column: "CaseId",
                principalTable: "Cases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneModels_Mobilephones_MobilephoneId",
                table: "PhoneModels",
                column: "MobilephoneId",
                principalTable: "Mobilephones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProtectedModels_Protectors_ProtectorId",
                table: "ProtectedModels",
                column: "ProtectorId",
                principalTable: "Protectors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CaseModels_Cases_CaseId",
                table: "CaseModels");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneModels_Mobilephones_MobilephoneId",
                table: "PhoneModels");

            migrationBuilder.DropForeignKey(
                name: "FK_ProtectedModels_Protectors_ProtectorId",
                table: "ProtectedModels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProtectedModels",
                table: "ProtectedModels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PhoneModels",
                table: "PhoneModels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CaseModels",
                table: "CaseModels");

            migrationBuilder.RenameTable(
                name: "ProtectedModels",
                newName: "ProtectorModel");

            migrationBuilder.RenameTable(
                name: "PhoneModels",
                newName: "PhoneModel");

            migrationBuilder.RenameTable(
                name: "CaseModels",
                newName: "CaseModel");

            migrationBuilder.RenameIndex(
                name: "IX_ProtectedModels_ProtectorId",
                table: "ProtectorModel",
                newName: "IX_ProtectorModel_ProtectorId");

            migrationBuilder.RenameIndex(
                name: "IX_PhoneModels_MobilephoneId",
                table: "PhoneModel",
                newName: "IX_PhoneModel_MobilephoneId");

            migrationBuilder.RenameIndex(
                name: "IX_CaseModels_CaseId",
                table: "CaseModel",
                newName: "IX_CaseModel_CaseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProtectorModel",
                table: "ProtectorModel",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PhoneModel",
                table: "PhoneModel",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CaseModel",
                table: "CaseModel",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CaseModel_Cases_CaseId",
                table: "CaseModel",
                column: "CaseId",
                principalTable: "Cases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneModel_Mobilephones_MobilephoneId",
                table: "PhoneModel",
                column: "MobilephoneId",
                principalTable: "Mobilephones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProtectorModel_Protectors_ProtectorId",
                table: "ProtectorModel",
                column: "ProtectorId",
                principalTable: "Protectors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
