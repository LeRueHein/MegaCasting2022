using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MegaCasting2022.DBLib.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Civilite",
                columns: table => new
                {
                    Identifiant = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LibelShort = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    LibelLong = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Civilite__DD380E4E01EAD5A6", x => x.Identifiant);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Identifiant = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Ville = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Telephone = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Login = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Client__DD380E4E9D67E92C", x => x.Identifiant);
                });

            migrationBuilder.CreateTable(
                name: "Conseil",
                columns: table => new
                {
                    Identifiant = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libel = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Contenu = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Conseil__DD380E4E157B2F5C", x => x.Identifiant);
                });

            migrationBuilder.CreateTable(
                name: "doctrine_migration_versions",
                columns: table => new
                {
                    version = table.Column<string>(type: "nvarchar(191)", maxLength: 191, nullable: false),
                    executed_at = table.Column<DateTime>(type: "datetime2(6)", precision: 6, nullable: true),
                    execution_time = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__doctrine__79B5C94C76A55E6D", x => x.version);
                });

            migrationBuilder.CreateTable(
                name: "DomaineMetier",
                columns: table => new
                {
                    Identifiant = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libel = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DomaineM__DD380E4E999C6DDE", x => x.Identifiant);
                });

            migrationBuilder.CreateTable(
                name: "Interview",
                columns: table => new
                {
                    Identifiant = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libel = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Url = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Intervie__DD380E4E652293D6", x => x.Identifiant);
                });

            migrationBuilder.CreateTable(
                name: "Pack",
                columns: table => new
                {
                    Identifiant = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libel = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    NombreOffre = table.Column<int>(type: "int", nullable: false),
                    Tarif = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Pack__DD380E4E21F50E1A", x => x.Identifiant);
                });

            migrationBuilder.CreateTable(
                name: "PartenaireDiffusion",
                columns: table => new
                {
                    Identifiant = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Partenai__DD380E4EC3719D87", x => x.Identifiant);
                });

            migrationBuilder.CreateTable(
                name: "TypeContrat",
                columns: table => new
                {
                    Identifiant = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libel = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TypeCont__DD380E4E12219398", x => x.Identifiant);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    email = table.Column<string>(type: "nvarchar(180)", maxLength: 180, nullable: false),
                    roles = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false, comment: "(DC2Type:json)"),
                    password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    is_verified = table.Column<bool>(type: "bit", nullable: false),
                    nom = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    numtel = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ville = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Metier",
                columns: table => new
                {
                    Identifiant = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libel = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: false),
                    IdentifiantDomaineMetier = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Metier__DD380E4E094284A5", x => x.Identifiant);
                    table.ForeignKey(
                        name: "FK_560C08BAE52D612A",
                        column: x => x.IdentifiantDomaineMetier,
                        principalTable: "DomaineMetier",
                        principalColumn: "Identifiant");
                });

            migrationBuilder.CreateTable(
                name: "OffreCasting",
                columns: table => new
                {
                    Identifiant = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libel = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Reference = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: false),
                    ParutionDateTime = table.Column<DateTime>(type: "datetime2(6)", precision: 6, nullable: false),
                    OffreDateStart = table.Column<DateTime>(type: "datetime2(6)", precision: 6, nullable: false),
                    OffreDateEnd = table.Column<DateTime>(type: "datetime2(6)", precision: 6, nullable: false),
                    Localisation = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IdentifiantClient = table.Column<int>(type: "int", nullable: false),
                    IdentifiantTypeContrat = table.Column<int>(type: "int", nullable: false),
                    sponso = table.Column<bool>(type: "bit", nullable: true),
                    nivurgence = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__OffreCas__DD380E4E203ACBC3", x => x.Identifiant);
                    table.ForeignKey(
                        name: "FK_982EDF9C9251261A",
                        column: x => x.IdentifiantTypeContrat,
                        principalTable: "TypeContrat",
                        principalColumn: "Identifiant");
                    table.ForeignKey(
                        name: "FK_982EDF9C93C1B089",
                        column: x => x.IdentifiantClient,
                        principalTable: "Client",
                        principalColumn: "Identifiant");
                });

            migrationBuilder.CreateTable(
                name: "CiviliteOffreCasting",
                columns: table => new
                {
                    IdentifiantCivilite = table.Column<int>(type: "int", nullable: false),
                    IdentifiantOffreCasting = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Civilite__0ECB1DAEFBB8978A", x => new { x.IdentifiantCivilite, x.IdentifiantOffreCasting });
                    table.ForeignKey(
                        name: "FK_5CC7CA8DB196B681",
                        column: x => x.IdentifiantOffreCasting,
                        principalTable: "Civilite",
                        principalColumn: "Identifiant");
                    table.ForeignKey(
                        name: "FK_5CC7CA8DCDCDB2D5",
                        column: x => x.IdentifiantCivilite,
                        principalTable: "OffreCasting",
                        principalColumn: "Identifiant");
                });

            migrationBuilder.CreateTable(
                name: "MetierOffreCasting",
                columns: table => new
                {
                    IdentifiantMetier = table.Column<int>(type: "int", nullable: false),
                    IdentifiantOffreCasting = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__MetierOf__45F38DB504ABBE02", x => new { x.IdentifiantMetier, x.IdentifiantOffreCasting });
                    table.ForeignKey(
                        name: "FK_A740572E525B950",
                        column: x => x.IdentifiantMetier,
                        principalTable: "OffreCasting",
                        principalColumn: "Identifiant");
                    table.ForeignKey(
                        name: "FK_A740572EB196B681",
                        column: x => x.IdentifiantOffreCasting,
                        principalTable: "Metier",
                        principalColumn: "Identifiant");
                });

            migrationBuilder.CreateIndex(
                name: "IDX_5CC7CA8DB196B681",
                table: "CiviliteOffreCasting",
                column: "IdentifiantOffreCasting");

            migrationBuilder.CreateIndex(
                name: "IDX_5CC7CA8DCDCDB2D5",
                table: "CiviliteOffreCasting",
                column: "IdentifiantCivilite");

            migrationBuilder.CreateIndex(
                name: "IDX_560C08BAE52D612A",
                table: "Metier",
                column: "IdentifiantDomaineMetier");

            migrationBuilder.CreateIndex(
                name: "IDX_A740572E525B950",
                table: "MetierOffreCasting",
                column: "IdentifiantMetier");

            migrationBuilder.CreateIndex(
                name: "IDX_A740572EB196B681",
                table: "MetierOffreCasting",
                column: "IdentifiantOffreCasting");

            migrationBuilder.CreateIndex(
                name: "IDX_982EDF9C9251261A",
                table: "OffreCasting",
                column: "IdentifiantTypeContrat");

            migrationBuilder.CreateIndex(
                name: "IDX_982EDF9C93C1B089",
                table: "OffreCasting",
                column: "IdentifiantClient");

            migrationBuilder.CreateIndex(
                name: "UNIQ_8D93D649E7927C74",
                table: "user",
                column: "email",
                unique: true,
                filter: "([email] IS NOT NULL)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CiviliteOffreCasting");

            migrationBuilder.DropTable(
                name: "Conseil");

            migrationBuilder.DropTable(
                name: "doctrine_migration_versions");

            migrationBuilder.DropTable(
                name: "Interview");

            migrationBuilder.DropTable(
                name: "MetierOffreCasting");

            migrationBuilder.DropTable(
                name: "Pack");

            migrationBuilder.DropTable(
                name: "PartenaireDiffusion");

            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.DropTable(
                name: "Civilite");

            migrationBuilder.DropTable(
                name: "OffreCasting");

            migrationBuilder.DropTable(
                name: "Metier");

            migrationBuilder.DropTable(
                name: "TypeContrat");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "DomaineMetier");
        }
    }
}
