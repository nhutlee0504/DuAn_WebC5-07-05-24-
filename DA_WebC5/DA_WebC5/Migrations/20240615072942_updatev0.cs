using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DA_WebC5.Migrations
{
    public partial class updatev0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    UserName = table.Column<string>(type: "varchar(20)", nullable: false),
                    Password = table.Column<string>(type: "varchar(50)", nullable: false),
                    Email = table.Column<string>(type: "varchar(150)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(3)", nullable: false),
                    Phone = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    Address = table.Column<string>(type: "ntext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.UserName);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    IDCategory = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.IDCategory);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    IDColor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.IDColor);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    IDSale = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    DiscountValue = table.Column<int>(type: "int", nullable: false),
                    MinAmount = table.Column<int>(type: "int", nullable: true),
                    MaxAmount = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.IDSale);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    IDSize = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SizeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.IDSize);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    IDSupplier = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "varchar(150)", nullable: false),
                    Phone = table.Column<string>(type: "varchar(12)", nullable: false),
                    Address = table.Column<string>(type: "ntext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.IDSupplier);
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    IDBill = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "varchar(20)", nullable: true),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.IDBill);
                    table.ForeignKey(
                        name: "FK_Bills_Accounts_UserName",
                        column: x => x.UserName,
                        principalTable: "Accounts",
                        principalColumn: "UserName",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Histories",
                columns: table => new
                {
                    IDHistory = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "varchar(20)", nullable: true),
                    Describe = table.Column<string>(type: "ntext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Histories", x => x.IDHistory);
                    table.ForeignKey(
                        name: "FK_Histories_Accounts_UserName",
                        column: x => x.UserName,
                        principalTable: "Accounts",
                        principalColumn: "UserName",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SaleDetails",
                columns: table => new
                {
                    IDSaleDetail = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDSale = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "varchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleDetails", x => x.IDSaleDetail);
                    table.ForeignKey(
                        name: "FK_SaleDetails_Accounts_UserName",
                        column: x => x.UserName,
                        principalTable: "Accounts",
                        principalColumn: "UserName",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SaleDetails_Sales_IDSale",
                        column: x => x.IDSale,
                        principalTable: "Sales",
                        principalColumn: "IDSale",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    IDProduct = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDSupplier = table.Column<int>(type: "int", nullable: false),
                    IDCategory = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Image = table.Column<string>(type: "varchar(150)", nullable: true),
                    Describe = table.Column<string>(type: "ntext", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.IDProduct);
                    table.ForeignKey(
                        name: "FK_Products_Categories_IDCategory",
                        column: x => x.IDCategory,
                        principalTable: "Categories",
                        principalColumn: "IDCategory",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Suppliers_IDSupplier",
                        column: x => x.IDSupplier,
                        principalTable: "Suppliers",
                        principalColumn: "IDSupplier",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Evaluates",
                columns: table => new
                {
                    IDEvaluate = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "varchar(20)", nullable: true),
                    IDProduct = table.Column<int>(type: "int", nullable: false),
                    Point = table.Column<int>(type: "int", nullable: true),
                    Describe = table.Column<string>(type: "ntext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evaluates", x => x.IDEvaluate);
                    table.ForeignKey(
                        name: "FK_Evaluates_Accounts_UserName",
                        column: x => x.UserName,
                        principalTable: "Accounts",
                        principalColumn: "UserName",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Evaluates_Products_IDProduct",
                        column: x => x.IDProduct,
                        principalTable: "Products",
                        principalColumn: "IDProduct",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ImageDetails",
                columns: table => new
                {
                    IDImage = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDProduct = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "varchar(150)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageDetails", x => x.IDImage);
                    table.ForeignKey(
                        name: "FK_ImageDetails_Products_IDProduct",
                        column: x => x.IDProduct,
                        principalTable: "Products",
                        principalColumn: "IDProduct",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductDetails",
                columns: table => new
                {
                    IDPDetail = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDProduct = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false),
                    IDColor = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDetails", x => x.IDPDetail);
                    table.ForeignKey(
                        name: "FK_ProductDetails_Colors_IDColor",
                        column: x => x.IDColor,
                        principalTable: "Colors",
                        principalColumn: "IDColor",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductDetails_Products_IDProduct",
                        column: x => x.IDProduct,
                        principalTable: "Products",
                        principalColumn: "IDProduct",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductDetails_Sizes_Size",
                        column: x => x.Size,
                        principalTable: "Sizes",
                        principalColumn: "IDSize",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BillDetails",
                columns: table => new
                {
                    IDBDetail = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDBill = table.Column<int>(type: "int", nullable: false),
                    IDPDetail = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillDetails", x => x.IDBDetail);
                    table.ForeignKey(
                        name: "FK_BillDetails_Bills_IDBill",
                        column: x => x.IDBill,
                        principalTable: "Bills",
                        principalColumn: "IDBill",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BillDetails_ProductDetails_IDPDetail",
                        column: x => x.IDPDetail,
                        principalTable: "ProductDetails",
                        principalColumn: "IDPDetail",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    IDCart = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "varchar(20)", nullable: false),
                    IDPDetail = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.IDCart);
                    table.ForeignKey(
                        name: "FK_Carts_Accounts_UserName",
                        column: x => x.UserName,
                        principalTable: "Accounts",
                        principalColumn: "UserName",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Carts_ProductDetails_IDPDetail",
                        column: x => x.IDPDetail,
                        principalTable: "ProductDetails",
                        principalColumn: "IDPDetail",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BillDetails_IDBill",
                table: "BillDetails",
                column: "IDBill");

            migrationBuilder.CreateIndex(
                name: "IX_BillDetails_IDPDetail",
                table: "BillDetails",
                column: "IDPDetail");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_UserName",
                table: "Bills",
                column: "UserName");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_IDPDetail",
                table: "Carts",
                column: "IDPDetail");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserName",
                table: "Carts",
                column: "UserName");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluates_IDProduct",
                table: "Evaluates",
                column: "IDProduct");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluates_UserName",
                table: "Evaluates",
                column: "UserName");

            migrationBuilder.CreateIndex(
                name: "IX_Histories_UserName",
                table: "Histories",
                column: "UserName");

            migrationBuilder.CreateIndex(
                name: "IX_ImageDetails_IDProduct",
                table: "ImageDetails",
                column: "IDProduct");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_IDColor",
                table: "ProductDetails",
                column: "IDColor");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_IDProduct",
                table: "ProductDetails",
                column: "IDProduct");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_Size",
                table: "ProductDetails",
                column: "Size");

            migrationBuilder.CreateIndex(
                name: "IX_Products_IDCategory",
                table: "Products",
                column: "IDCategory");

            migrationBuilder.CreateIndex(
                name: "IX_Products_IDSupplier",
                table: "Products",
                column: "IDSupplier");

            migrationBuilder.CreateIndex(
                name: "IX_SaleDetails_IDSale",
                table: "SaleDetails",
                column: "IDSale");

            migrationBuilder.CreateIndex(
                name: "IX_SaleDetails_UserName",
                table: "SaleDetails",
                column: "UserName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BillDetails");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Evaluates");

            migrationBuilder.DropTable(
                name: "Histories");

            migrationBuilder.DropTable(
                name: "ImageDetails");

            migrationBuilder.DropTable(
                name: "SaleDetails");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "ProductDetails");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Suppliers");
        }
    }
}
