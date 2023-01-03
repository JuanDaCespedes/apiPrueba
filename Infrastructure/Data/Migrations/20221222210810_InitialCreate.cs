using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PERSONA",
                columns: table => new
                {
                    ID_PERSONA = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOMBRE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    APELLIDO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NOMBRE_COMPLETO = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TIPO_IDENTIFICACION = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NUMERO_IDENTIFICACION = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NUMERO_IDENTIFICACION_TIPO = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    EMAIL = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PERSONA", x => x.ID_PERSONA);
                });

            migrationBuilder.CreateTable(
                name: "USUARIO",
                columns: table => new
                {
                    ID_USUARIO = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USUARIO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PASS = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USUARIO", x => x.ID_USUARIO);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PERSONA");

            migrationBuilder.DropTable(
                name: "USUARIO");
        }
    }
}
