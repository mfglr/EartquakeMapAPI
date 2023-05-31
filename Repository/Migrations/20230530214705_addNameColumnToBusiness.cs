using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class addNameColumnToBusiness : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Businesses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2023, 5, 31, 0, 47, 5, 300, DateTimeKind.Local).AddTicks(2621));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2023, 5, 31, 0, 47, 5, 300, DateTimeKind.Local).AddTicks(2631));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2023, 5, 31, 0, 47, 5, 300, DateTimeKind.Local).AddTicks(2632));

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "Name" },
                values: new object[] { new DateTime(2023, 5, 31, 0, 47, 5, 300, DateTimeKind.Local).AddTicks(2781), "name1" });

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "Name" },
                values: new object[] { new DateTime(2023, 5, 31, 0, 47, 5, 300, DateTimeKind.Local).AddTicks(2783), "name2" });

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "Name" },
                values: new object[] { new DateTime(2023, 5, 31, 0, 47, 5, 300, DateTimeKind.Local).AddTicks(2785), "name3" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2023, 5, 31, 0, 47, 5, 300, DateTimeKind.Local).AddTicks(2872));

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2023, 5, 31, 0, 47, 5, 300, DateTimeKind.Local).AddTicks(2988));

            migrationBuilder.UpdateData(
                table: "Individuals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Birthday", "CreateTime" },
                values: new object[] { new DateTime(2023, 5, 31, 0, 47, 5, 300, DateTimeKind.Local).AddTicks(3067), new DateTime(2023, 5, 31, 0, 47, 5, 300, DateTimeKind.Local).AddTicks(3066) });

            migrationBuilder.UpdateData(
                table: "Individuals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Birthday", "CreateTime" },
                values: new object[] { new DateTime(2023, 5, 31, 0, 47, 5, 300, DateTimeKind.Local).AddTicks(3073), new DateTime(2023, 5, 31, 0, 47, 5, 300, DateTimeKind.Local).AddTicks(3072) });

            migrationBuilder.UpdateData(
                table: "Individuals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Birthday", "CreateTime" },
                values: new object[] { new DateTime(2023, 5, 31, 0, 47, 5, 300, DateTimeKind.Local).AddTicks(3074), new DateTime(2023, 5, 31, 0, 47, 5, 300, DateTimeKind.Local).AddTicks(3074) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2023, 5, 31, 0, 47, 5, 300, DateTimeKind.Local).AddTicks(3151));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2023, 5, 31, 0, 47, 5, 300, DateTimeKind.Local).AddTicks(3152));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2023, 5, 31, 0, 47, 5, 300, DateTimeKind.Local).AddTicks(3153));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2023, 5, 31, 0, 47, 5, 300, DateTimeKind.Local).AddTicks(3154));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2023, 5, 31, 0, 47, 5, 300, DateTimeKind.Local).AddTicks(3154));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Businesses");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2023, 5, 30, 18, 58, 7, 763, DateTimeKind.Local).AddTicks(6156));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2023, 5, 30, 18, 58, 7, 763, DateTimeKind.Local).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2023, 5, 30, 18, 58, 7, 763, DateTimeKind.Local).AddTicks(6172));

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2023, 5, 30, 18, 58, 7, 763, DateTimeKind.Local).AddTicks(6575));

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2023, 5, 30, 18, 58, 7, 763, DateTimeKind.Local).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2023, 5, 30, 18, 58, 7, 763, DateTimeKind.Local).AddTicks(6582));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2023, 5, 30, 18, 58, 7, 763, DateTimeKind.Local).AddTicks(6762));

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2023, 5, 30, 18, 58, 7, 763, DateTimeKind.Local).AddTicks(6965));

            migrationBuilder.UpdateData(
                table: "Individuals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Birthday", "CreateTime" },
                values: new object[] { new DateTime(2023, 5, 30, 18, 58, 7, 763, DateTimeKind.Local).AddTicks(7156), new DateTime(2023, 5, 30, 18, 58, 7, 763, DateTimeKind.Local).AddTicks(7153) });

            migrationBuilder.UpdateData(
                table: "Individuals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Birthday", "CreateTime" },
                values: new object[] { new DateTime(2023, 5, 30, 18, 58, 7, 763, DateTimeKind.Local).AddTicks(7163), new DateTime(2023, 5, 30, 18, 58, 7, 763, DateTimeKind.Local).AddTicks(7161) });

            migrationBuilder.UpdateData(
                table: "Individuals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Birthday", "CreateTime" },
                values: new object[] { new DateTime(2023, 5, 30, 18, 58, 7, 763, DateTimeKind.Local).AddTicks(7166), new DateTime(2023, 5, 30, 18, 58, 7, 763, DateTimeKind.Local).AddTicks(7165) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2023, 5, 30, 18, 58, 7, 763, DateTimeKind.Local).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2023, 5, 30, 18, 58, 7, 763, DateTimeKind.Local).AddTicks(7343));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2023, 5, 30, 18, 58, 7, 763, DateTimeKind.Local).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2023, 5, 30, 18, 58, 7, 763, DateTimeKind.Local).AddTicks(7347));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2023, 5, 30, 18, 58, 7, 763, DateTimeKind.Local).AddTicks(7349));
        }
    }
}
