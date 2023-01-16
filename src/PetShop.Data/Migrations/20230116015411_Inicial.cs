using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "pet_owner",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    primeironome = table.Column<string>(name: "primeiro_nome", type: "nvarchar(15)", maxLength: 15, nullable: false),
                    sobrenome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    telefone = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    ruaendereco = table.Column<string>(name: "rua_endereco", type: "nvarchar(max)", nullable: false),
                    bairroendereco = table.Column<string>(name: "bairro_endereco", type: "nvarchar(max)", nullable: false),
                    numeroendereco = table.Column<string>(name: "numero_endereco", type: "nvarchar(max)", nullable: false),
                    cependereco = table.Column<string>(name: "cep_endereco", type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pet_owner", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "procedimento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomeprocedimento = table.Column<string>(name: "nome_procedimento", type: "nvarchar(200)", maxLength: 200, nullable: false),
                    valorprocedimento = table.Column<decimal>(name: "valor_procedimento", type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_procedimento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "veterinario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    primeironome = table.Column<string>(name: "primeiro_nome", type: "nvarchar(50)", maxLength: 50, nullable: false),
                    sobrenome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_veterinario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "pet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PetOwnerId = table.Column<int>(type: "int", nullable: false),
                    nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_pet_pet_owner_PetOwnerId",
                        column: x => x.PetOwnerId,
                        principalTable: "pet_owner",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "consulta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PetId = table.Column<int>(type: "int", nullable: false),
                    VetId = table.Column<int>(type: "int", nullable: false),
                    dataconsulta = table.Column<DateTime>(name: "data_consulta", type: "date", nullable: false),
                    horaconsulta = table.Column<TimeSpan>(name: "hora_consulta", type: "time", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_consulta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_consulta_pet_PetId",
                        column: x => x.PetId,
                        principalTable: "pet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_consulta_veterinario_VetId",
                        column: x => x.VetId,
                        principalTable: "veterinario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CareProcedures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProcedureId = table.Column<int>(type: "int", nullable: false),
                    VetCareId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CareProcedures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CareProcedures_consulta_VetCareId",
                        column: x => x.VetCareId,
                        principalTable: "consulta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CareProcedures_procedimento_ProcedureId",
                        column: x => x.ProcedureId,
                        principalTable: "procedimento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CareProcedures_ProcedureId",
                table: "CareProcedures",
                column: "ProcedureId");

            migrationBuilder.CreateIndex(
                name: "IX_CareProcedures_VetCareId",
                table: "CareProcedures",
                column: "VetCareId");

            migrationBuilder.CreateIndex(
                name: "IX_consulta_PetId",
                table: "consulta",
                column: "PetId");

            migrationBuilder.CreateIndex(
                name: "IX_consulta_VetId",
                table: "consulta",
                column: "VetId");

            migrationBuilder.CreateIndex(
                name: "IX_pet_PetOwnerId",
                table: "pet",
                column: "PetOwnerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CareProcedures");

            migrationBuilder.DropTable(
                name: "consulta");

            migrationBuilder.DropTable(
                name: "procedimento");

            migrationBuilder.DropTable(
                name: "pet");

            migrationBuilder.DropTable(
                name: "veterinario");

            migrationBuilder.DropTable(
                name: "pet_owner");
        }
    }
}
