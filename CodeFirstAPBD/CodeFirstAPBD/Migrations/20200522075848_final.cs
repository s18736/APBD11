using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstAPBD.Migrations
{
    public partial class final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MedicamentPrescription",
                table: "MedicamentPrescription");

            migrationBuilder.DropIndex(
                name: "IX_MedicamentPrescription_IdMedicament",
                table: "MedicamentPrescription");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MedicamentPrescription",
                table: "MedicamentPrescription",
                columns: new[] { "IdMedicament", "IdPrescription" });

            migrationBuilder.CreateIndex(
                name: "IX_MedicamentPrescription_IdPrescription",
                table: "MedicamentPrescription",
                column: "IdPrescription");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MedicamentPrescription",
                table: "MedicamentPrescription");

            migrationBuilder.DropIndex(
                name: "IX_MedicamentPrescription_IdPrescription",
                table: "MedicamentPrescription");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MedicamentPrescription",
                table: "MedicamentPrescription",
                column: "IdPrescription");

            migrationBuilder.CreateIndex(
                name: "IX_MedicamentPrescription_IdMedicament",
                table: "MedicamentPrescription",
                column: "IdMedicament");
        }
    }
}
