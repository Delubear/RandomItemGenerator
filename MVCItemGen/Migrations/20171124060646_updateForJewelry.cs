using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MVCItemGen.Migrations
{
    public partial class updateForJewelry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Effect",
                table: "items",
                newName: "Potions_Effect");

            migrationBuilder.AddColumn<string>(
                name: "Effect",
                table: "items",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "JewelryType",
                table: "items",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Effect",
                table: "items");

            migrationBuilder.DropColumn(
                name: "JewelryType",
                table: "items");

            migrationBuilder.RenameColumn(
                name: "Potions_Effect",
                table: "items",
                newName: "Effect");
        }
    }
}
