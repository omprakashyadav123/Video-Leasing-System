using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorPagesMovie.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addmovie",
                columns: table => new
                {
                    VID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Moviename = table.Column<string>(nullable: true),
                    Actor = table.Column<string>(nullable: true),
                    Director = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addmovie", x => x.VID);
                });

            migrationBuilder.CreateTable(
                name: "Adduser",
                columns: table => new
                {
                    UID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Uname = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    phone = table.Column<int>(nullable: false),
                    password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adduser", x => x.UID);
                });

            migrationBuilder.CreateTable(
                name: "Record",
                columns: table => new
                {
                    RecordsId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AdduserUID = table.Column<int>(nullable: false),
                    AddmovieVID = table.Column<int>(nullable: false),
                    TakenDate = table.Column<DateTime>(nullable: false),
                    ReturnDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Record", x => x.RecordsId);
                    table.ForeignKey(
                        name: "FK_Record_Addmovie_AddmovieVID",
                        column: x => x.AddmovieVID,
                        principalTable: "Addmovie",
                        principalColumn: "VID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Record_Adduser_AdduserUID",
                        column: x => x.AdduserUID,
                        principalTable: " Adduser",
                        principalColumn: "UID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Record_AddmovieVID",
                table: "Record",
                column: "AddmovieVID");

            migrationBuilder.CreateIndex(
                name: "IX_Record_AdduserUID",
                table: "Record",
                column: "AdduserUID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Record");

            migrationBuilder.DropTable(
                name: "Addmovie");

            migrationBuilder.DropTable(
                name: "Adduser");
        }
    }
}
