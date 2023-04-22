using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AkarDataAccess.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsPublicOrPrivate = table.Column<bool>(type: "bit", nullable: false),
                    MaxUserCount = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    CreateUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GecerliFlg = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Groups_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tokens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(type: "int", nullable: true),
                    GruoupId = table.Column<int>(type: "int", nullable: true),
                    IsUsed = table.Column<bool>(type: "bit", nullable: false),
                    CreateUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GecerliFlg = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tokens_Groups_GruoupId",
                        column: x => x.GruoupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tokens_Users_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModDate" },
                values: new object[] { new DateTime(2023, 4, 20, 18, 49, 32, 674, DateTimeKind.Local).AddTicks(1410), new DateTime(2023, 4, 20, 18, 49, 32, 674, DateTimeKind.Local).AddTicks(4435) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModDate" },
                values: new object[] { new DateTime(2023, 4, 20, 18, 49, 32, 674, DateTimeKind.Local).AddTicks(6306), new DateTime(2023, 4, 20, 18, 49, 32, 674, DateTimeKind.Local).AddTicks(6309) });

            migrationBuilder.CreateIndex(
                name: "IX_Groups_UserId",
                table: "Groups",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tokens_GruoupId",
                table: "Tokens",
                column: "GruoupId");

            migrationBuilder.CreateIndex(
                name: "IX_Tokens_PersonId",
                table: "Tokens",
                column: "PersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tokens");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModDate" },
                values: new object[] { new DateTime(2023, 4, 20, 14, 52, 47, 301, DateTimeKind.Local).AddTicks(3464), new DateTime(2023, 4, 20, 14, 52, 47, 301, DateTimeKind.Local).AddTicks(5076) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModDate" },
                values: new object[] { new DateTime(2023, 4, 20, 14, 52, 47, 301, DateTimeKind.Local).AddTicks(5929), new DateTime(2023, 4, 20, 14, 52, 47, 301, DateTimeKind.Local).AddTicks(5931) });
        }
    }
}
