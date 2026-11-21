using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GestImmo.Migrations
{
    /// <inheritdoc />
    public partial class Initialisation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Biens",
                columns: table => new
                {
                    BienId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nom = table.Column<string>(type: "text", nullable: false),
                    Valeur = table.Column<double>(type: "double precision", nullable: false),
                    Adresse = table.Column<string>(type: "text", nullable: false),
                    Surface = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Biens", x => x.BienId);
                });

            migrationBuilder.CreateTable(
                name: "Prestataires",
                columns: table => new
                {
                    PrestataireId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RaisonSocial = table.Column<string>(type: "text", nullable: false),
                    Nom = table.Column<string>(type: "text", nullable: false),
                    Prenom = table.Column<string>(type: "text", nullable: false),
                    Telephone = table.Column<string>(type: "text", nullable: false),
                    Adresse = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestataires", x => x.PrestataireId);
                });

            migrationBuilder.CreateTable(
                name: "Bails",
                columns: table => new
                {
                    BailId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Loyer = table.Column<double>(type: "double precision", nullable: false),
                    DateDebut = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateFin = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    BienId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bails", x => x.BailId);
                    table.ForeignKey(
                        name: "FK_Bails_Biens_BienId",
                        column: x => x.BienId,
                        principalTable: "Biens",
                        principalColumn: "BienId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Box",
                columns: table => new
                {
                    BienId = table.Column<int>(type: "integer", nullable: false),
                    BoxId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Box", x => x.BienId);
                    table.ForeignKey(
                        name: "FK_Box_Biens_BienId",
                        column: x => x.BienId,
                        principalTable: "Biens",
                        principalColumn: "BienId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Habitable",
                columns: table => new
                {
                    BienId = table.Column<int>(type: "integer", nullable: false),
                    HabitableId = table.Column<int>(type: "integer", nullable: false),
                    NbrPiece = table.Column<int>(type: "integer", nullable: false),
                    NbrChambre = table.Column<int>(type: "integer", nullable: false),
                    NbrCave = table.Column<int>(type: "integer", nullable: false),
                    NbrParking = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habitable", x => x.BienId);
                    table.ForeignKey(
                        name: "FK_Habitable_Biens_BienId",
                        column: x => x.BienId,
                        principalTable: "Biens",
                        principalColumn: "BienId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Prets",
                columns: table => new
                {
                    PretId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Apport = table.Column<double>(type: "double precision", nullable: false),
                    Montant = table.Column<double>(type: "double precision", nullable: false),
                    TauxInteret = table.Column<double>(type: "double precision", nullable: false),
                    Duree = table.Column<int>(type: "integer", nullable: false),
                    DateDebut = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    BienId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prets", x => x.PretId);
                    table.ForeignKey(
                        name: "FK_Prets_Biens_BienId",
                        column: x => x.BienId,
                        principalTable: "Biens",
                        principalColumn: "BienId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Interventitons",
                columns: table => new
                {
                    InterventionId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DateIntervention = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    MontantIntervention = table.Column<double>(type: "double precision", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    BienId = table.Column<int>(type: "integer", nullable: false),
                    PrestataireId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interventitons", x => x.InterventionId);
                    table.ForeignKey(
                        name: "FK_Interventitons_Biens_BienId",
                        column: x => x.BienId,
                        principalTable: "Biens",
                        principalColumn: "BienId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Interventitons_Prestataires_PrestataireId",
                        column: x => x.PrestataireId,
                        principalTable: "Prestataires",
                        principalColumn: "PrestataireId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Locataires",
                columns: table => new
                {
                    LocataireId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nom = table.Column<string>(type: "text", nullable: false),
                    Prenom = table.Column<string>(type: "text", nullable: false),
                    Age = table.Column<int>(type: "integer", nullable: false),
                    Profession = table.Column<string>(type: "text", nullable: false),
                    LocationBailId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locataires", x => x.LocataireId);
                    table.ForeignKey(
                        name: "FK_Locataires_Bails_LocationBailId",
                        column: x => x.LocationBailId,
                        principalTable: "Bails",
                        principalColumn: "BailId");
                });

            migrationBuilder.CreateTable(
                name: "Appartement",
                columns: table => new
                {
                    BienId = table.Column<int>(type: "integer", nullable: false),
                    AppartementId = table.Column<int>(type: "integer", nullable: false),
                    Etage = table.Column<int>(type: "integer", nullable: false),
                    Ascenseur = table.Column<string>(type: "text", nullable: false),
                    ChauffageCommun = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appartement", x => x.BienId);
                    table.ForeignKey(
                        name: "FK_Appartement_Habitable_BienId",
                        column: x => x.BienId,
                        principalTable: "Habitable",
                        principalColumn: "BienId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Maison",
                columns: table => new
                {
                    BienId = table.Column<int>(type: "integer", nullable: false),
                    MaisonId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maison", x => x.BienId);
                    table.ForeignKey(
                        name: "FK_Maison_Habitable_BienId",
                        column: x => x.BienId,
                        principalTable: "Habitable",
                        principalColumn: "BienId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bails_BienId",
                table: "Bails",
                column: "BienId");

            migrationBuilder.CreateIndex(
                name: "IX_Interventitons_BienId",
                table: "Interventitons",
                column: "BienId");

            migrationBuilder.CreateIndex(
                name: "IX_Interventitons_PrestataireId",
                table: "Interventitons",
                column: "PrestataireId");

            migrationBuilder.CreateIndex(
                name: "IX_Locataires_LocationBailId",
                table: "Locataires",
                column: "LocationBailId");

            migrationBuilder.CreateIndex(
                name: "IX_Prets_BienId",
                table: "Prets",
                column: "BienId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appartement");

            migrationBuilder.DropTable(
                name: "Box");

            migrationBuilder.DropTable(
                name: "Interventitons");

            migrationBuilder.DropTable(
                name: "Locataires");

            migrationBuilder.DropTable(
                name: "Maison");

            migrationBuilder.DropTable(
                name: "Prets");

            migrationBuilder.DropTable(
                name: "Prestataires");

            migrationBuilder.DropTable(
                name: "Bails");

            migrationBuilder.DropTable(
                name: "Habitable");

            migrationBuilder.DropTable(
                name: "Biens");
        }
    }
}
