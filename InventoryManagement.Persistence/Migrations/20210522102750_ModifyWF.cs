using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InventoryManagement.Persistence.Migrations
{
    public partial class ModifyWF : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_ProductCategoryId",
                schema: "Identity",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_TransactionLines_Products_ProductId",
                schema: "Identity",
                table: "TransactionLines");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductCategoryId",
                schema: "Identity",
                table: "Products");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "935da6b5-6723-44c6-96c1-b53aca7df8ce", "09fba445-13e9-46f6-aa30-782d4bd2ff1c" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "85413410-4d36-44ee-89dd-77109fabd589", "20a38564-83af-46d9-88f6-1c7e4bbf82ff" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "86a0b243-bb4f-4e62-aa1a-61e4ac399d6f", "20a38564-83af-46d9-88f6-1c7e4bbf82ff" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "916176dd-8099-4b0b-be20-6b27c433ab2f", "20a38564-83af-46d9-88f6-1c7e4bbf82ff" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "935da6b5-6723-44c6-96c1-b53aca7df8ce", "20a38564-83af-46d9-88f6-1c7e4bbf82ff" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "85413410-4d36-44ee-89dd-77109fabd589");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "86a0b243-bb4f-4e62-aa1a-61e4ac399d6f");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "916176dd-8099-4b0b-be20-6b27c433ab2f");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "935da6b5-6723-44c6-96c1-b53aca7df8ce");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "09fba445-13e9-46f6-aa30-782d4bd2ff1c");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "20a38564-83af-46d9-88f6-1c7e4bbf82ff");

            migrationBuilder.DropColumn(
                name: "BoxNumber",
                schema: "Identity",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "BoxPrice",
                schema: "Identity",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "BuyingPrice",
                schema: "Identity",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Description",
                schema: "Identity",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ExpiryDate",
                schema: "Identity",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ItemsInBox",
                schema: "Identity",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductCategoryId",
                schema: "Identity",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductCode",
                schema: "Identity",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductionDate",
                schema: "Identity",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SellingPrice",
                schema: "Identity",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "UnitPrice",
                schema: "Identity",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                schema: "Identity",
                table: "TransactionLines",
                newName: "ProductDetailId");

            migrationBuilder.RenameIndex(
                name: "IX_TransactionLines_ProductId",
                schema: "Identity",
                table: "TransactionLines",
                newName: "IX_TransactionLines_ProductDetailId");

            migrationBuilder.AddColumn<long>(
                name: "CategoryId",
                schema: "Identity",
                table: "Products",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProductDetails",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    SellingPrice = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    BuyingPrice = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    ProductCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    BoxNumber = table.Column<int>(type: "int", nullable: true),
                    ItemsInBox = table.Column<int>(type: "int", nullable: true),
                    BoxPrice = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
                    ProductionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "Identity",
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "bae68c63-aa86-4eea-bff9-2e7670b95510", "b499fc35-068f-4025-a35b-6d84673e4f5b", "SuperAdmin", "SuperAdmin" },
                    { "0ba1712a-62f1-4b8c-b41a-e6961cec75ef", "cf0d9575-ac76-49e3-ae0d-4d4698ca5fc3", "Admin", "Admin" },
                    { "ad0a9ab9-8780-470d-8cd3-82e2437f7a53", "98dd286d-1482-4a76-8407-25e93b52a375", "Moderator", "Moderator" },
                    { "db73c240-5ec6-4ecb-a1cd-03cb4510c881", "25b3fec8-6f33-4106-a25e-3b21fb4b0782", "Basic", "Basic" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "771cf00b-9e4f-4539-b076-4e9a6b75be93", 0, "5b039a31-7afc-48e9-af46-1837755f260f", "superadmin@gmail.com", true, "Amit", "Naik", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, true, "8ff23087-4d96-4d70-923c-3a5055b4c339", false, "superadmin" },
                    { "d859a21e-0cc9-455b-9d2e-90fa933d07fe", 0, "4a257f32-0a2a-49cc-921b-2a7c90c1eefd", "basicuser@gmail.com", true, "Basic", "User", false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, true, "901d1982-a91c-4333-b531-5948d178435e", false, "basicuser" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "bae68c63-aa86-4eea-bff9-2e7670b95510", "771cf00b-9e4f-4539-b076-4e9a6b75be93" },
                    { "0ba1712a-62f1-4b8c-b41a-e6961cec75ef", "771cf00b-9e4f-4539-b076-4e9a6b75be93" },
                    { "ad0a9ab9-8780-470d-8cd3-82e2437f7a53", "771cf00b-9e4f-4539-b076-4e9a6b75be93" },
                    { "db73c240-5ec6-4ecb-a1cd-03cb4510c881", "d859a21e-0cc9-455b-9d2e-90fa933d07fe" },
                    { "db73c240-5ec6-4ecb-a1cd-03cb4510c881", "771cf00b-9e4f-4539-b076-4e9a6b75be93" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                schema: "Identity",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_ProductId",
                schema: "Identity",
                table: "ProductDetails",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                schema: "Identity",
                table: "Products",
                column: "CategoryId",
                principalSchema: "Identity",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionLines_ProductDetails_ProductDetailId",
                schema: "Identity",
                table: "TransactionLines",
                column: "ProductDetailId",
                principalSchema: "Identity",
                principalTable: "ProductDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                schema: "Identity",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_TransactionLines_ProductDetails_ProductDetailId",
                schema: "Identity",
                table: "TransactionLines");

            migrationBuilder.DropTable(
                name: "ProductDetails",
                schema: "Identity");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                schema: "Identity",
                table: "Products");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0ba1712a-62f1-4b8c-b41a-e6961cec75ef", "771cf00b-9e4f-4539-b076-4e9a6b75be93" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad0a9ab9-8780-470d-8cd3-82e2437f7a53", "771cf00b-9e4f-4539-b076-4e9a6b75be93" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bae68c63-aa86-4eea-bff9-2e7670b95510", "771cf00b-9e4f-4539-b076-4e9a6b75be93" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "db73c240-5ec6-4ecb-a1cd-03cb4510c881", "771cf00b-9e4f-4539-b076-4e9a6b75be93" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "db73c240-5ec6-4ecb-a1cd-03cb4510c881", "d859a21e-0cc9-455b-9d2e-90fa933d07fe" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "0ba1712a-62f1-4b8c-b41a-e6961cec75ef");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "ad0a9ab9-8780-470d-8cd3-82e2437f7a53");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "bae68c63-aa86-4eea-bff9-2e7670b95510");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "db73c240-5ec6-4ecb-a1cd-03cb4510c881");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "771cf00b-9e4f-4539-b076-4e9a6b75be93");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "d859a21e-0cc9-455b-9d2e-90fa933d07fe");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                schema: "Identity",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "ProductDetailId",
                schema: "Identity",
                table: "TransactionLines",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_TransactionLines_ProductDetailId",
                schema: "Identity",
                table: "TransactionLines",
                newName: "IX_TransactionLines_ProductId");

            migrationBuilder.AddColumn<int>(
                name: "BoxNumber",
                schema: "Identity",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "BoxPrice",
                schema: "Identity",
                table: "Products",
                type: "decimal(18,4)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "BuyingPrice",
                schema: "Identity",
                table: "Products",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                schema: "Identity",
                table: "Products",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpiryDate",
                schema: "Identity",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ItemsInBox",
                schema: "Identity",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ProductCategoryId",
                schema: "Identity",
                table: "Products",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "ProductCode",
                schema: "Identity",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "ProductionDate",
                schema: "Identity",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "SellingPrice",
                schema: "Identity",
                table: "Products",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "UnitPrice",
                schema: "Identity",
                table: "Products",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "86a0b243-bb4f-4e62-aa1a-61e4ac399d6f", "51fe19eb-75a0-4f4c-ba5f-04ee43dbcb75", "SuperAdmin", "SuperAdmin" },
                    { "85413410-4d36-44ee-89dd-77109fabd589", "de3e9797-0ad1-4001-b0db-26d120cd1ef3", "Admin", "Admin" },
                    { "916176dd-8099-4b0b-be20-6b27c433ab2f", "0a736b48-699b-4dfa-becf-e153df87b79a", "Moderator", "Moderator" },
                    { "935da6b5-6723-44c6-96c1-b53aca7df8ce", "a3a4438c-1eeb-4b53-8ee0-3234959de6ff", "Basic", "Basic" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "20a38564-83af-46d9-88f6-1c7e4bbf82ff", 0, "e6fb8a8a-5d25-4f36-b26c-cbedde9d4484", "superadmin@gmail.com", true, "Amit", "Naik", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, true, "97149730-00ca-470c-83cf-e863ea20a249", false, "superadmin" },
                    { "09fba445-13e9-46f6-aa30-782d4bd2ff1c", 0, "0939f7d9-07ce-440f-a983-d7be410e899a", "basicuser@gmail.com", true, "Basic", "User", false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, true, "542426c1-ebec-4985-93eb-1d28a9b879ea", false, "basicuser" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "86a0b243-bb4f-4e62-aa1a-61e4ac399d6f", "20a38564-83af-46d9-88f6-1c7e4bbf82ff" },
                    { "85413410-4d36-44ee-89dd-77109fabd589", "20a38564-83af-46d9-88f6-1c7e4bbf82ff" },
                    { "916176dd-8099-4b0b-be20-6b27c433ab2f", "20a38564-83af-46d9-88f6-1c7e4bbf82ff" },
                    { "935da6b5-6723-44c6-96c1-b53aca7df8ce", "09fba445-13e9-46f6-aa30-782d4bd2ff1c" },
                    { "935da6b5-6723-44c6-96c1-b53aca7df8ce", "20a38564-83af-46d9-88f6-1c7e4bbf82ff" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductCategoryId",
                schema: "Identity",
                table: "Products",
                column: "ProductCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_ProductCategoryId",
                schema: "Identity",
                table: "Products",
                column: "ProductCategoryId",
                principalSchema: "Identity",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionLines_Products_ProductId",
                schema: "Identity",
                table: "TransactionLines",
                column: "ProductId",
                principalSchema: "Identity",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
