using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GameWorld.Migrations
{
    public partial class ShippedOrders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Screenshot1",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Screenshot2",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Screenshot3",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Shipped",
                table: "Orders",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Screenshot1",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Screenshot2",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Screenshot3",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Shipped",
                table: "Orders");
        }
    }
}
