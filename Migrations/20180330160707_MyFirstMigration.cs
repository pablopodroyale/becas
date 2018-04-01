using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Beca.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Encuesta",
                columns: table => new
                {
                    EncuestaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Apellido = table.Column<string>(nullable: false),
                    Chequeado = table.Column<bool>(nullable: false),
                    Dni_Libreta = table.Column<int>(nullable: false),
                    Domicilio = table.Column<string>(maxLength: 256, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Localidad = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    Pregunta_Aumento_Transporte = table.Column<string>(nullable: false),
                    Pregunta_Beca_Transporte = table.Column<string>(nullable: false),
                    Pregunta_Boleto_Edu = table.Column<string>(nullable: false),
                    Pregunta_Comentarios = table.Column<string>(maxLength: 256, nullable: false),
                    Pregunta_Politica_Iniciativas = table.Column<string>(nullable: false),
                    Pregunta_Politica_Permanencia = table.Column<string>(nullable: false),
                    Telefono = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Encuesta", x => x.EncuestaID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Encuesta");
        }
    }
}
