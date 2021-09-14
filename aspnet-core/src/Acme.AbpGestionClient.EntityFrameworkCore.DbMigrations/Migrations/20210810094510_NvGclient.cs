using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Acme.AbpGestionClient.Migrations
{
    public partial class NvGclient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "AppGClients");

            migrationBuilder.AddColumn<string>(
                name: "PathImg",
                table: "AppGClients",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PathImg",
                table: "AppGClients");

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "AppGClients",
                type: "varbinary(max)",
                nullable: true);
        }
    }
}
