using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstAPBD.Migrations
{
    public partial class allConnected : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MedicamentPrescriptions",
                columns: table => new
                {
                    IdPrescription = table.Column<int>(nullable: false),
                    IdMedicament = table.Column<int>(nullable: false),
                    Dose = table.Column<int>(nullable: false),
                    Details = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicamentPrescriptions", x => x.IdPrescription);
                    table.ForeignKey(
                        name: "FK_MedicamentPrescriptions_Medicament_IdMedicament",
                        column: x => x.IdMedicament,
                        principalTable: "Medicament",
                        principalColumn: "IdMedicament",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicamentPrescriptions_Prescription_IdPrescription",
                        column: x => x.IdPrescription,
                        principalTable: "Prescription",
                        principalColumn: "IdPrescription",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MedicamentPrescriptions_IdMedicament",
                table: "MedicamentPrescriptions",
                column: "IdMedicament");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicamentPrescriptions");
        }
    }
}
