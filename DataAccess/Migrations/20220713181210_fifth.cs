using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class fifth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "UserAuthEntityID",
                table: "WeatherDatas",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_WeatherDatas_UserAuthEntityID",
                table: "WeatherDatas",
                column: "UserAuthEntityID");

            migrationBuilder.AddForeignKey(
                name: "FK_WeatherDatas_UserAuths_UserAuthEntityID",
                table: "WeatherDatas",
                column: "UserAuthEntityID",
                principalTable: "UserAuths",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WeatherDatas_UserAuths_UserAuthEntityID",
                table: "WeatherDatas");

            migrationBuilder.DropIndex(
                name: "IX_WeatherDatas_UserAuthEntityID",
                table: "WeatherDatas");

            migrationBuilder.DropColumn(
                name: "UserAuthEntityID",
                table: "WeatherDatas");
        }
    }
}
