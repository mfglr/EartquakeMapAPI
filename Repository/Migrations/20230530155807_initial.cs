using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Businesses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Businesses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Diseases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diseases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Individuals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Individuals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    PlaceId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Businesses_Id",
                        column: x => x.Id,
                        principalTable: "Businesses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DiseaseIndividual",
                columns: table => new
                {
                    DiseasesId = table.Column<int>(type: "int", nullable: false),
                    IndividualsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiseaseIndividual", x => new { x.DiseasesId, x.IndividualsId });
                    table.ForeignKey(
                        name: "FK_DiseaseIndividual_Diseases_DiseasesId",
                        column: x => x.DiseasesId,
                        principalTable: "Diseases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiseaseIndividual_Individuals_IndividualsId",
                        column: x => x.IndividualsId,
                        principalTable: "Individuals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BusinessProduct",
                columns: table => new
                {
                    BusinessesId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessProduct", x => new { x.BusinessesId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_BusinessProduct_Businesses_BusinessesId",
                        column: x => x.BusinessesId,
                        principalTable: "Businesses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BusinessProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryProduct",
                columns: table => new
                {
                    CategoriesId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryProduct", x => new { x.CategoriesId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DiseaseProduct",
                columns: table => new
                {
                    DiseasesId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiseaseProduct", x => new { x.DiseasesId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_DiseaseProduct_Diseases_DiseasesId",
                        column: x => x.DiseasesId,
                        principalTable: "Diseases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiseaseProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "CreateTime", "Email", "Password", "UpdateTime", "Username" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 30, 18, 58, 7, 763, DateTimeKind.Local).AddTicks(6575), "emailBusiness1", "123456", null, "usernameBusiness1" },
                    { 2, new DateTime(2023, 5, 30, 18, 58, 7, 763, DateTimeKind.Local).AddTicks(6580), "emailBusiness2", "123456", null, "usernameBusiness2" },
                    { 3, new DateTime(2023, 5, 30, 18, 58, 7, 763, DateTimeKind.Local).AddTicks(6582), "emailBusiness3", "123456", null, "usernameBusiness3" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateTime", "Name", "UpdateTime" },
                values: new object[] { 1, new DateTime(2023, 5, 30, 18, 58, 7, 763, DateTimeKind.Local).AddTicks(6762), "Kabuklu Kuruyemiş", null });

            migrationBuilder.InsertData(
                table: "Diseases",
                columns: new[] { "Id", "CreateTime", "Name", "UpdateTime" },
                values: new object[] { 1, new DateTime(2023, 5, 30, 18, 58, 7, 763, DateTimeKind.Local).AddTicks(6965), "Histamin İntoleransı", null });

            migrationBuilder.InsertData(
                table: "Individuals",
                columns: new[] { "Id", "Birthday", "CreateTime", "Email", "LastName", "Name", "Password", "UpdateTime", "Username" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 30, 18, 58, 7, 763, DateTimeKind.Local).AddTicks(7156), new DateTime(2023, 5, 30, 18, 58, 7, 763, DateTimeKind.Local).AddTicks(7153), "emailIndivudual1", "lastname1", "name1", "123456", null, "usernameIdivual1" },
                    { 2, new DateTime(2023, 5, 30, 18, 58, 7, 763, DateTimeKind.Local).AddTicks(7163), new DateTime(2023, 5, 30, 18, 58, 7, 763, DateTimeKind.Local).AddTicks(7161), "emailIndivudual2", "lastname2", "name2", "123456", null, "usernameIdivual2" },
                    { 3, new DateTime(2023, 5, 30, 18, 58, 7, 763, DateTimeKind.Local).AddTicks(7166), new DateTime(2023, 5, 30, 18, 58, 7, 763, DateTimeKind.Local).AddTicks(7165), "emailIndivudual3", "lastname3", "name3", "123456", null, "usernameIdivual3" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreateTime", "Name", "ProductId", "UpdateTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 30, 18, 58, 7, 763, DateTimeKind.Local).AddTicks(7340), "fındık", null, null },
                    { 2, new DateTime(2023, 5, 30, 18, 58, 7, 763, DateTimeKind.Local).AddTicks(7343), "badem", null, null },
                    { 3, new DateTime(2023, 5, 30, 18, 58, 7, 763, DateTimeKind.Local).AddTicks(7345), "ceviz", null, null },
                    { 4, new DateTime(2023, 5, 30, 18, 58, 7, 763, DateTimeKind.Local).AddTicks(7347), "fıstık", null, null },
                    { 5, new DateTime(2023, 5, 30, 18, 58, 7, 763, DateTimeKind.Local).AddTicks(7349), "kaju", null, null }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "CreateTime", "PlaceId", "UpdateTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 30, 18, 58, 7, 763, DateTimeKind.Local).AddTicks(6156), "ChIJyVyJIcM-yhQRmVL98P6vD-4", null },
                    { 2, new DateTime(2023, 5, 30, 18, 58, 7, 763, DateTimeKind.Local).AddTicks(6170), "ChIJ1SkRIsM-yhQRDQUFyzsB0NU", null },
                    { 3, new DateTime(2023, 5, 30, 18, 58, 7, 763, DateTimeKind.Local).AddTicks(6172), "ChIJG4i1GMM-yhQRh26JXS9AXwY", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BusinessProduct_ProductsId",
                table: "BusinessProduct",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryProduct_ProductsId",
                table: "CategoryProduct",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_DiseaseIndividual_IndividualsId",
                table: "DiseaseIndividual",
                column: "IndividualsId");

            migrationBuilder.CreateIndex(
                name: "IX_DiseaseProduct_ProductsId",
                table: "DiseaseProduct",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductId",
                table: "Products",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "BusinessProduct");

            migrationBuilder.DropTable(
                name: "CategoryProduct");

            migrationBuilder.DropTable(
                name: "DiseaseIndividual");

            migrationBuilder.DropTable(
                name: "DiseaseProduct");

            migrationBuilder.DropTable(
                name: "Businesses");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Individuals");

            migrationBuilder.DropTable(
                name: "Diseases");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
