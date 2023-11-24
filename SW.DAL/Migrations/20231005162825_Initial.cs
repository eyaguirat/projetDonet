using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SW.DAL.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Espece",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nom = table.Column<string>(type: "TEXT", nullable: false),
                    Longevite = table.Column<int>(type: "INTEGER", nullable: false),
                    Majorite = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Espece", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Citoyens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nom = table.Column<string>(type: "TEXT", nullable: false),
                    Prenom = table.Column<string>(type: "TEXT", nullable: false),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    EspeceId = table.Column<int>(type: "INTEGER", nullable: false),
                    PereBiologiqueID = table.Column<int>(type: "INTEGER", nullable: false),
                    MereBiologiqueID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citoyens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Citoyens_Citoyens_MereBiologiqueID",
                        column: x => x.MereBiologiqueID,
                        principalTable: "Citoyens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Citoyens_Citoyens_PereBiologiqueID",
                        column: x => x.PereBiologiqueID,
                        principalTable: "Citoyens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Citoyens_Espece_EspeceId",
                        column: x => x.EspeceId,
                        principalTable: "Espece",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Citoyens_EspeceId",
                table: "Citoyens",
                column: "EspeceId");

            migrationBuilder.CreateIndex(
                name: "IX_Citoyens_MereBiologiqueID",
                table: "Citoyens",
                column: "MereBiologiqueID");

            migrationBuilder.CreateIndex(
                name: "IX_Citoyens_PereBiologiqueID",
                table: "Citoyens",
                column: "PereBiologiqueID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Citoyens");

            migrationBuilder.DropTable(
                name: "Espece");
        }
    }
}
