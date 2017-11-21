using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MVCItemGen.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "items",
                columns: table => new
                {
                    ArmorType = table.Column<int>(nullable: true),
                    ArmorValue = table.Column<int>(nullable: true),
                    ID = table.Column<Guid>(nullable: false),
                    BaseName = table.Column<string>(nullable: true),
                    CurrentDurability = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    ItemType = table.Column<int>(nullable: false),
                    MaxDurability = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Prefix = table.Column<string>(nullable: true),
                    PrefixDescriptor = table.Column<string>(nullable: true),
                    Rarity = table.Column<int>(nullable: false),
                    Suffix = table.Column<string>(nullable: true),
                    Value = table.Column<int>(nullable: false),
                    Effect = table.Column<string>(nullable: true),
                    PropDescription = table.Column<string>(nullable: true),
                    Accuracy = table.Column<double>(nullable: true),
                    DamageType = table.Column<int>(nullable: true),
                    DamageValue = table.Column<int>(nullable: true),
                    WeaponCat = table.Column<int>(nullable: true),
                    WeaponType = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_items", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "items");
        }
    }
}
