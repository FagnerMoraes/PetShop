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
                name: "dono",
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
                    cependereco = table.Column<string>(name: "cep_endereco", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dono", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "procedimento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    valorprocedimento = table.Column<string>(name: "valor_procedimento", type: "nvarchar(200)", maxLength: 200, precision: 18, scale: 2, nullable: false),
                    ValorProcedimento = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
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
                    primeironome = table.Column<string>(name: "primeiro_nome", type: "nvarchar(15)", maxLength: 15, nullable: false),
                    sobrenome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
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
                    DonoId = table.Column<int>(type: "int", nullable: false),
                    nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_pet_dono_DonoId",
                        column: x => x.DonoId,
                        principalTable: "dono",
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
                    VeterinarioId = table.Column<int>(type: "int", nullable: false),
                    dataconsulta = table.Column<DateTime>(name: "data_consulta", type: "date", nullable: false),
                    horaconsulta = table.Column<TimeSpan>(name: "hora_consulta", type: "time", nullable: false)
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
                        name: "FK_consulta_veterinario_VeterinarioId",
                        column: x => x.VeterinarioId,
                        principalTable: "veterinario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProcedimentosDasConsultas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProcedimentoId = table.Column<int>(type: "int", nullable: false),
                    ConsultaId = table.Column<int>(type: "int", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcedimentosDasConsultas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProcedimentosDasConsultas_consulta_ConsultaId",
                        column: x => x.ConsultaId,
                        principalTable: "consulta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProcedimentosDasConsultas_procedimento_ProcedimentoId",
                        column: x => x.ProcedimentoId,
                        principalTable: "procedimento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_consulta_PetId",
                table: "consulta",
                column: "PetId");

            migrationBuilder.CreateIndex(
                name: "IX_consulta_VeterinarioId",
                table: "consulta",
                column: "VeterinarioId");

            migrationBuilder.CreateIndex(
                name: "IX_pet_DonoId",
                table: "pet",
                column: "DonoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProcedimentosDasConsultas_ConsultaId",
                table: "ProcedimentosDasConsultas",
                column: "ConsultaId");

            migrationBuilder.CreateIndex(
                name: "IX_ProcedimentosDasConsultas_ProcedimentoId",
                table: "ProcedimentosDasConsultas",
                column: "ProcedimentoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProcedimentosDasConsultas");

            migrationBuilder.DropTable(
                name: "consulta");

            migrationBuilder.DropTable(
                name: "procedimento");

            migrationBuilder.DropTable(
                name: "pet");

            migrationBuilder.DropTable(
                name: "veterinario");

            migrationBuilder.DropTable(
                name: "dono");
        }
    }
}
