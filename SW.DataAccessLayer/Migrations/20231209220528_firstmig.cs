using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SW.DataAccessLayer.Migrations
{
    public partial class firstmig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Especes",
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
                    table.PrimaryKey("PK_Especes", x => x.Id);
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
                    EspeceId = table.Column<int>(type: "INTEGER", nullable: true),
                    PereBiologiqueID = table.Column<int>(type: "INTEGER", nullable: true),
                    MereBiologiqueID = table.Column<int>(type: "INTEGER", nullable: true),
                    Bonheur = table.Column<int>(type: "INTEGER", nullable: true),
                    Fertilite = table.Column<int>(type: "INTEGER", nullable: true),
                    PointsDeMerites = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citoyens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Citoyens_Citoyens_MereBiologiqueID",
                        column: x => x.MereBiologiqueID,
                        principalTable: "Citoyens",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Citoyens_Citoyens_PereBiologiqueID",
                        column: x => x.PereBiologiqueID,
                        principalTable: "Citoyens",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Citoyens_Especes_EspeceId",
                        column: x => x.EspeceId,
                        principalTable: "Especes",
                        principalColumn: "Id");
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
                name: "Especes");
        }
    }
}
