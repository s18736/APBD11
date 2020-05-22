using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstAPBD.Migrations
{
    public partial class corrected : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicamentPrescriptions_Medicament_IdMedicament",
                table: "MedicamentPrescriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicamentPrescriptions_Prescription_IdPrescription",
                table: "MedicamentPrescriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MedicamentPrescriptions",
                table: "MedicamentPrescriptions");

            migrationBuilder.RenameTable(
                name: "MedicamentPrescriptions",
                newName: "MedicamentPrescription");

            migrationBuilder.RenameIndex(
                name: "IX_MedicamentPrescriptions_IdMedicament",
                table: "MedicamentPrescription",
                newName: "IX_MedicamentPrescription_IdMedicament");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MedicamentPrescription",
                table: "MedicamentPrescription",
                column: "IdPrescription");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicamentPrescription_Medicament_IdMedicament",
                table: "MedicamentPrescription",
                column: "IdMedicament",
                principalTable: "Medicament",
                principalColumn: "IdMedicament",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicamentPrescription_Prescription_IdPrescription",
                table: "MedicamentPrescription",
                column: "IdPrescription",
                principalTable: "Prescription",
                principalColumn: "IdPrescription",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicamentPrescription_Medicament_IdMedicament",
                table: "MedicamentPrescription");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicamentPrescription_Prescription_IdPrescription",
                table: "MedicamentPrescription");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MedicamentPrescription",
                table: "MedicamentPrescription");

            migrationBuilder.RenameTable(
                name: "MedicamentPrescription",
                newName: "MedicamentPrescriptions");

            migrationBuilder.RenameIndex(
                name: "IX_MedicamentPrescription_IdMedicament",
                table: "MedicamentPrescriptions",
                newName: "IX_MedicamentPrescriptions_IdMedicament");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MedicamentPrescriptions",
                table: "MedicamentPrescriptions",
                column: "IdPrescription");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicamentPrescriptions_Medicament_IdMedicament",
                table: "MedicamentPrescriptions",
                column: "IdMedicament",
                principalTable: "Medicament",
                principalColumn: "IdMedicament",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicamentPrescriptions_Prescription_IdPrescription",
                table: "MedicamentPrescriptions",
                column: "IdPrescription",
                principalTable: "Prescription",
                principalColumn: "IdPrescription",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
