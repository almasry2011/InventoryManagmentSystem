using Microsoft.EntityFrameworkCore.Migrations;

namespace InventoryManagement.Persistence.Migrations
{
    public partial class modifyProduct1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<decimal>(
                name: "SellingUnitPrice",
                schema: "Identity",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "SellingBoxPrice",
                schema: "Identity",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AlterColumn<int>(
                name: "ItemsInBox",
                schema: "Identity",
                table: "Products",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ec28b12c-bf83-4642-99e2-d0a3082fe244", "0e27e11e-f269-4907-bfe7-5709344ccf8c", "SuperAdmin", "SuperAdmin" },
                    { "576c3037-4bf5-488e-9b4f-15127ce676a7", "2e87bf44-644a-497f-b6df-75580655dd27", "Admin", "Admin" },
                    { "63a6d57a-4381-48e8-b502-ab3133a48b72", "336ba7ff-6792-4883-a626-f3f117dacd9b", "Moderator", "Moderator" },
                    { "f5e08c26-e362-4f7a-8626-663fc6473c53", "aed7782c-069c-4971-ab2d-31db8a3990dd", "Basic", "Basic" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2273f3ca-c79e-4867-a666-b611233d9790", 0, "f70dd28c-3386-47db-8d25-1c449ff92773", "superadmin@gmail.com", true, "Amit", "Naik", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, true, "d7efa324-1f03-49d5-96f9-278cbe12d738", false, "superadmin" },
                    { "6cdd6cb9-59ed-4e2f-8a9b-38a451612bad", 0, "85c11d88-a38a-4801-8a31-6fbb882de0ee", "basicuser@gmail.com", true, "Basic", "User", false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, true, "ba87ab38-fd4e-4a3f-9c3d-4208d50cb2ba", false, "basicuser" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ec28b12c-bf83-4642-99e2-d0a3082fe244", "2273f3ca-c79e-4867-a666-b611233d9790" },
                    { "576c3037-4bf5-488e-9b4f-15127ce676a7", "2273f3ca-c79e-4867-a666-b611233d9790" },
                    { "63a6d57a-4381-48e8-b502-ab3133a48b72", "2273f3ca-c79e-4867-a666-b611233d9790" },
                    { "f5e08c26-e362-4f7a-8626-663fc6473c53", "6cdd6cb9-59ed-4e2f-8a9b-38a451612bad" },
                    { "f5e08c26-e362-4f7a-8626-663fc6473c53", "2273f3ca-c79e-4867-a666-b611233d9790" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "576c3037-4bf5-488e-9b4f-15127ce676a7", "2273f3ca-c79e-4867-a666-b611233d9790" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "63a6d57a-4381-48e8-b502-ab3133a48b72", "2273f3ca-c79e-4867-a666-b611233d9790" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ec28b12c-bf83-4642-99e2-d0a3082fe244", "2273f3ca-c79e-4867-a666-b611233d9790" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f5e08c26-e362-4f7a-8626-663fc6473c53", "2273f3ca-c79e-4867-a666-b611233d9790" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f5e08c26-e362-4f7a-8626-663fc6473c53", "6cdd6cb9-59ed-4e2f-8a9b-38a451612bad" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "576c3037-4bf5-488e-9b4f-15127ce676a7");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "63a6d57a-4381-48e8-b502-ab3133a48b72");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "ec28b12c-bf83-4642-99e2-d0a3082fe244");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "f5e08c26-e362-4f7a-8626-663fc6473c53");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "2273f3ca-c79e-4867-a666-b611233d9790");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "6cdd6cb9-59ed-4e2f-8a9b-38a451612bad");

            migrationBuilder.AlterColumn<decimal>(
                name: "SellingUnitPrice",
                schema: "Identity",
                table: "Products",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "SellingBoxPrice",
                schema: "Identity",
                table: "Products",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ItemsInBox",
                schema: "Identity",
                table: "Products",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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
        }
    }
}
