using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mvvm.Migrations
{
    /// <inheritdoc />
    public partial class salfetka : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GenerationEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    NameGeneration = table.Column<string>(type: "nvarchar(22)", maxLength: 22, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Generati__3214EC07D8791B49", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "logins",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    Logins = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    pass = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    roles = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__logins__3214EC27C4277C0C", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MarkEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    NameModelCar = table.Column<string>(type: "nvarchar(22)", maxLength: 22, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__MarkEnti__3214EC0788753415", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ModelEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Название_модели = table.Column<string>(type: "nvarchar(22)", maxLength: 22, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ModelEnt__3214EC07949F7CCA", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PacageEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    FuelType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    EngineVolume = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    EnginePower = table.Column<int>(type: "int", nullable: false),
                    KPPType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DriveType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CallType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CallColor = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Rudder = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    NamePacage = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PacageEn__3214EC07037E7C4B", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    MarkID = table.Column<int>(type: "int", nullable: true),
                    ModelID = table.Column<int>(type: "int", nullable: true),
                    GenerationID = table.Column<int>(type: "int", nullable: true),
                    Mileage = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    ReleaseYear = table.Column<int>(type: "int", nullable: false),
                    PacageID = table.Column<int>(type: "int", nullable: true),
                    Picture = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CarEntit__3214EC07EBDBAC32", x => x.Id);
                    table.ForeignKey(
                        name: "FK__CarEntity__Gener__6D0D32F4",
                        column: x => x.GenerationID,
                        principalTable: "GenerationEntity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__CarEntity__MarkI__6B24EA82",
                        column: x => x.MarkID,
                        principalTable: "MarkEntity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__CarEntity__Model__6C190EBB",
                        column: x => x.ModelID,
                        principalTable: "ModelEntity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__CarEntity__Pacag__6E01572D",
                        column: x => x.PacageID,
                        principalTable: "PacageEntity",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarEntity_GenerationID",
                table: "CarEntity",
                column: "GenerationID");

            migrationBuilder.CreateIndex(
                name: "IX_CarEntity_MarkID",
                table: "CarEntity",
                column: "MarkID");

            migrationBuilder.CreateIndex(
                name: "IX_CarEntity_ModelID",
                table: "CarEntity",
                column: "ModelID");

            migrationBuilder.CreateIndex(
                name: "IX_CarEntity_PacageID",
                table: "CarEntity",
                column: "PacageID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarEntity");

            migrationBuilder.DropTable(
                name: "logins");

            migrationBuilder.DropTable(
                name: "GenerationEntity");

            migrationBuilder.DropTable(
                name: "MarkEntity");

            migrationBuilder.DropTable(
                name: "ModelEntity");

            migrationBuilder.DropTable(
                name: "PacageEntity");
        }
    }
}
