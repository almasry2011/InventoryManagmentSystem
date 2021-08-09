using Microsoft.EntityFrameworkCore.Migrations;

namespace InventoryManagement.Persistence.Migrations
{
    public partial class modifyProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_ProductCategoryId",
                schema: "Identity",
                table: "Products");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f8bf2b32-4c07-4bfe-92b5-bf70145fe6d7", "76533dce-d287-4dc6-a630-40cc44c6a142" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4bb35e85-f15f-4c85-9bca-e53a6d28e7fb", "df6228d6-99d0-43ad-9971-6835e94f8332" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "592ed5f6-c174-496a-aa40-9d55714950c9", "df6228d6-99d0-43ad-9971-6835e94f8332" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "abccc46b-2d6f-4824-b1f6-67794006b8dc", "df6228d6-99d0-43ad-9971-6835e94f8332" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f8bf2b32-4c07-4bfe-92b5-bf70145fe6d7", "df6228d6-99d0-43ad-9971-6835e94f8332" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "4bb35e85-f15f-4c85-9bca-e53a6d28e7fb");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "592ed5f6-c174-496a-aa40-9d55714950c9");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "abccc46b-2d6f-4824-b1f6-67794006b8dc");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "f8bf2b32-4c07-4bfe-92b5-bf70145fe6d7");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "76533dce-d287-4dc6-a630-40cc44c6a142");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "df6228d6-99d0-43ad-9971-6835e94f8332");

            migrationBuilder.AlterColumn<long>(
                name: "ProductCategoryId",
                schema: "Identity",
                table: "Products",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NumberInStock",
                schema: "Identity",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "ItemsInBox",
                schema: "Identity",
                table: "Products",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "SellingBoxPrice",
                schema: "Identity",
                table: "Products",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "SellingUnitPrice",
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
                    { "e6f5fe7a-c05f-4724-a33c-e28cb5bdd4f9", "f4fc336e-556a-464c-98ff-e7cbdd328649", "SuperAdmin", "SuperAdmin" },
                    { "450f26d9-3245-42ac-b1c2-7ee6973872b7", "243163fa-cad2-454c-8ca2-c86a27bdbb71", "Admin", "Admin" },
                    { "4cdce58f-58f3-4da6-aa7b-359cba3d87c0", "9c9953e9-7a3c-4931-b496-de369ecc3b33", "Moderator", "Moderator" },
                    { "6069a218-e61e-4645-a9ef-04e516bfd351", "bde76989-8e4f-478a-92f2-5635899f4830", "Basic", "Basic" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "a3f94852-7952-41ed-9ee6-36628472589e", 0, "452534f1-442f-4d0c-8526-718c7efb8149", "superadmin@gmail.com", true, "Amit", "Naik", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, true, "04989091-30a5-4049-b0be-5b6645a13c13", false, "superadmin" },
                    { "208a4d75-df2a-4c47-a694-3754f7843c5b", 0, "4da4027a-aa49-4aec-b0bf-a421f8e9f637", "basicuser@gmail.com", true, "Basic", "User", false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, true, "2da09ed6-3bf6-4554-aaf1-c9a9734a3810", false, "basicuser" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "e6f5fe7a-c05f-4724-a33c-e28cb5bdd4f9", "a3f94852-7952-41ed-9ee6-36628472589e" },
                    { "450f26d9-3245-42ac-b1c2-7ee6973872b7", "a3f94852-7952-41ed-9ee6-36628472589e" },
                    { "4cdce58f-58f3-4da6-aa7b-359cba3d87c0", "a3f94852-7952-41ed-9ee6-36628472589e" },
                    { "6069a218-e61e-4645-a9ef-04e516bfd351", "208a4d75-df2a-4c47-a694-3754f7843c5b" },
                    { "6069a218-e61e-4645-a9ef-04e516bfd351", "a3f94852-7952-41ed-9ee6-36628472589e" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_ProductCategoryId",
                schema: "Identity",
                table: "Products",
                column: "ProductCategoryId",
                principalSchema: "Identity",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_ProductCategoryId",
                schema: "Identity",
                table: "Products");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6069a218-e61e-4645-a9ef-04e516bfd351", "208a4d75-df2a-4c47-a694-3754f7843c5b" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "450f26d9-3245-42ac-b1c2-7ee6973872b7", "a3f94852-7952-41ed-9ee6-36628472589e" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4cdce58f-58f3-4da6-aa7b-359cba3d87c0", "a3f94852-7952-41ed-9ee6-36628472589e" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6069a218-e61e-4645-a9ef-04e516bfd351", "a3f94852-7952-41ed-9ee6-36628472589e" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e6f5fe7a-c05f-4724-a33c-e28cb5bdd4f9", "a3f94852-7952-41ed-9ee6-36628472589e" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "450f26d9-3245-42ac-b1c2-7ee6973872b7");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "4cdce58f-58f3-4da6-aa7b-359cba3d87c0");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "6069a218-e61e-4645-a9ef-04e516bfd351");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "e6f5fe7a-c05f-4724-a33c-e28cb5bdd4f9");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "208a4d75-df2a-4c47-a694-3754f7843c5b");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "a3f94852-7952-41ed-9ee6-36628472589e");

            migrationBuilder.DropColumn(
                name: "SellingBoxPrice",
                schema: "Identity",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SellingUnitPrice",
                schema: "Identity",
                table: "Products");

            migrationBuilder.AlterColumn<long>(
                name: "ProductCategoryId",
                schema: "Identity",
                table: "Products",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "NumberInStock",
                schema: "Identity",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ItemsInBox",
                schema: "Identity",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4bb35e85-f15f-4c85-9bca-e53a6d28e7fb", "692f534c-7302-44b0-9e69-a6eb9d967a4f", "SuperAdmin", "SuperAdmin" },
                    { "592ed5f6-c174-496a-aa40-9d55714950c9", "782cbc85-b13d-49c9-920b-59006b5a843b", "Admin", "Admin" },
                    { "abccc46b-2d6f-4824-b1f6-67794006b8dc", "0a8dd039-1670-4b9c-a21f-e258772b1e28", "Moderator", "Moderator" },
                    { "f8bf2b32-4c07-4bfe-92b5-bf70145fe6d7", "a5b905b1-f9e5-4881-8716-8fe20d981d01", "Basic", "Basic" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "df6228d6-99d0-43ad-9971-6835e94f8332", 0, "9c246cf8-6333-4dc0-94e2-0977f6e464a9", "superadmin@gmail.com", true, "Amit", "Naik", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, true, "7c6bd7e1-27ae-4784-99e6-faaabdf0ab1f", false, "superadmin" },
                    { "76533dce-d287-4dc6-a630-40cc44c6a142", 0, "da08c96f-4093-4648-8868-008bd38b9c70", "basicuser@gmail.com", true, "Basic", "User", false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, true, "895bc5e5-1ad9-45f2-b858-8e66e9d57b96", false, "basicuser" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "4bb35e85-f15f-4c85-9bca-e53a6d28e7fb", "df6228d6-99d0-43ad-9971-6835e94f8332" },
                    { "592ed5f6-c174-496a-aa40-9d55714950c9", "df6228d6-99d0-43ad-9971-6835e94f8332" },
                    { "abccc46b-2d6f-4824-b1f6-67794006b8dc", "df6228d6-99d0-43ad-9971-6835e94f8332" },
                    { "f8bf2b32-4c07-4bfe-92b5-bf70145fe6d7", "76533dce-d287-4dc6-a630-40cc44c6a142" },
                    { "f8bf2b32-4c07-4bfe-92b5-bf70145fe6d7", "df6228d6-99d0-43ad-9971-6835e94f8332" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_ProductCategoryId",
                schema: "Identity",
                table: "Products",
                column: "ProductCategoryId",
                principalSchema: "Identity",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
