using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AkarDataAccess.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserPhoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GecerliFlg = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreateDate", "CreateUser", "GecerliFlg", "ModDate", "ModUser", "Password", "UserName", "UserPhoto" },
                values: new object[] { 1, new DateTime(2023, 4, 20, 14, 52, 47, 301, DateTimeKind.Local).AddTicks(3464), "BERKAY AKAR", true, new DateTime(2023, 4, 20, 14, 52, 47, 301, DateTimeKind.Local).AddTicks(5076), "BERKAY AKAR", "mberkayakar", "mberkayakar", "https://media.licdn.com/dms/image/C4D03AQH0lx3tESYC7w/profile-displayphoto-shrink_800_800/0/1607277130794?e=2147483647&v=beta&t=mWbd1TIxwSp7B_vA_RkHuJi2tvdrMqAj9EvAyIntub0" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreateDate", "CreateUser", "GecerliFlg", "ModDate", "ModUser", "Password", "UserName", "UserPhoto" },
                values: new object[] { 2, new DateTime(2023, 4, 20, 14, 52, 47, 301, DateTimeKind.Local).AddTicks(5929), "BERKAY AKAR", true, new DateTime(2023, 4, 20, 14, 52, 47, 301, DateTimeKind.Local).AddTicks(5931), "BERKAY AKAR", "atelyon", "atelyon", "https://media.licdn.com/dms/image/C4D03AQH0lx3tESYC7w/profile-displayphoto-shrink_800_800/0/1607277130794?e=2147483647&v=beta&t=mWbd1TIxwSp7B_vA_RkHuJi2tvdrMqAj9EvAyIntub0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
