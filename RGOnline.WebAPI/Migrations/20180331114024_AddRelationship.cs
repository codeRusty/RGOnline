using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace RGOnline.WebAPI.Migrations
{
    public partial class AddRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_ProductSubCategory_M_ProductCategory_M_ProductCategoryId",
                table: "M_ProductSubCategory");

            migrationBuilder.DropIndex(
                name: "IX_M_ProductSubCategory_M_ProductCategoryId",
                table: "M_ProductSubCategory");

            migrationBuilder.DropColumn(
                name: "M_ProductCategoryId",
                table: "M_ProductSubCategory");

            migrationBuilder.AddColumn<long>(
                name: "ProductCategoryID",
                table: "M_ProductSubCategory",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_M_ProductSubCategory_ProductCategoryID",
                table: "M_ProductSubCategory",
                column: "ProductCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_M_ProductSubCategory_M_ProductCategory_ProductCategoryID",
                table: "M_ProductSubCategory",
                column: "ProductCategoryID",
                principalTable: "M_ProductCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_ProductSubCategory_M_ProductCategory_ProductCategoryID",
                table: "M_ProductSubCategory");

            migrationBuilder.DropIndex(
                name: "IX_M_ProductSubCategory_ProductCategoryID",
                table: "M_ProductSubCategory");

            migrationBuilder.DropColumn(
                name: "ProductCategoryID",
                table: "M_ProductSubCategory");

            migrationBuilder.AddColumn<long>(
                name: "M_ProductCategoryId",
                table: "M_ProductSubCategory",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_M_ProductSubCategory_M_ProductCategoryId",
                table: "M_ProductSubCategory",
                column: "M_ProductCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_M_ProductSubCategory_M_ProductCategory_M_ProductCategoryId",
                table: "M_ProductSubCategory",
                column: "M_ProductCategoryId",
                principalTable: "M_ProductCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
