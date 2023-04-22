using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AkarDataAccess.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Users_UserId",
                table: "Groups");

            migrationBuilder.DropIndex(
                name: "IX_Groups_UserId",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Groups");

            migrationBuilder.CreateTable(
                name: "GroupUser",
                columns: table => new
                {
                    GroupsId = table.Column<int>(type: "int", nullable: false),
                    MembersListId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupUser", x => new { x.GroupsId, x.MembersListId });
                    table.ForeignKey(
                        name: "FK_GroupUser_Groups_GroupsId",
                        column: x => x.GroupsId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupUser_Users_MembersListId",
                        column: x => x.MembersListId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModDate" },
                values: new object[] { new DateTime(2023, 4, 20, 22, 46, 49, 965, DateTimeKind.Local).AddTicks(8153), new DateTime(2023, 4, 20, 22, 46, 49, 965, DateTimeKind.Local).AddTicks(9902) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModDate" },
                values: new object[] { new DateTime(2023, 4, 20, 22, 46, 49, 966, DateTimeKind.Local).AddTicks(2954), new DateTime(2023, 4, 20, 22, 46, 49, 966, DateTimeKind.Local).AddTicks(2956) });

            migrationBuilder.CreateIndex(
                name: "IX_GroupUser_MembersListId",
                table: "GroupUser",
                column: "MembersListId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GroupUser");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Groups",
                type: "int",
                nullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Users_UserId",
                table: "Groups",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
