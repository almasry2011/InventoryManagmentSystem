using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InventoryManagement.Persistence.Migrations
{
    public partial class fixmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<DateTime>(
                name: "TransactionDate",
                schema: "Identity",
                table: "Transactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<int>(
                name: "ItemsInStock",
                schema: "Identity",
                table: "ProductDetails",
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
                    { "3c1bca07-3432-410e-a13d-f2623c68c1d7", "b3c1213d-9781-4542-9a11-1d83991ec625", "SuperAdmin", "SuperAdmin" },
                    { "e1445e36-bbb2-427d-b953-34ab8e227bd0", "2c9b1387-c361-466f-8ab0-60815912fc57", "Admin", "Admin" },
                    { "95e09c92-82b9-4c2d-ae59-73b0f3bf1810", "3cf4e015-3d7b-4614-95d9-3ecf824e9ac2", "Moderator", "Moderator" },
                    { "bebfa8db-fb19-49b6-9bde-aeedbbb17129", "8be31b3f-086c-4f38-9eaa-f917fbd833da", "Basic", "Basic" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "371dd0a1-7f60-470e-be5c-8236889af3fe", 0, "cfffdef3-0123-4408-963c-f79f87dc18eb", "superadmin@gmail.com", true, "Amit", "Naik", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, true, "6debf6a2-7ee8-49f4-854e-963492b51a3b", false, "superadmin" },
                    { "e29f3dc6-dda1-4698-96d2-b389f8e80881", 0, "6346b48d-4b4f-48ce-b93c-34b63f7d7857", "basicuser@gmail.com", true, "Basic", "User", false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, true, "0eeec294-e2fd-4a72-a505-131861050d5a", false, "basicuser" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "3c1bca07-3432-410e-a13d-f2623c68c1d7", "371dd0a1-7f60-470e-be5c-8236889af3fe" },
                    { "e1445e36-bbb2-427d-b953-34ab8e227bd0", "371dd0a1-7f60-470e-be5c-8236889af3fe" },
                    { "95e09c92-82b9-4c2d-ae59-73b0f3bf1810", "371dd0a1-7f60-470e-be5c-8236889af3fe" },
                    { "bebfa8db-fb19-49b6-9bde-aeedbbb17129", "e29f3dc6-dda1-4698-96d2-b389f8e80881" },
                    { "bebfa8db-fb19-49b6-9bde-aeedbbb17129", "371dd0a1-7f60-470e-be5c-8236889af3fe" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3c1bca07-3432-410e-a13d-f2623c68c1d7", "371dd0a1-7f60-470e-be5c-8236889af3fe" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "95e09c92-82b9-4c2d-ae59-73b0f3bf1810", "371dd0a1-7f60-470e-be5c-8236889af3fe" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bebfa8db-fb19-49b6-9bde-aeedbbb17129", "371dd0a1-7f60-470e-be5c-8236889af3fe" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e1445e36-bbb2-427d-b953-34ab8e227bd0", "371dd0a1-7f60-470e-be5c-8236889af3fe" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bebfa8db-fb19-49b6-9bde-aeedbbb17129", "e29f3dc6-dda1-4698-96d2-b389f8e80881" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "3c1bca07-3432-410e-a13d-f2623c68c1d7");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "95e09c92-82b9-4c2d-ae59-73b0f3bf1810");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "bebfa8db-fb19-49b6-9bde-aeedbbb17129");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "e1445e36-bbb2-427d-b953-34ab8e227bd0");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "371dd0a1-7f60-470e-be5c-8236889af3fe");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "e29f3dc6-dda1-4698-96d2-b389f8e80881");

            migrationBuilder.DropColumn(
                name: "TransactionDate",
                schema: "Identity",
                table: "Transactions");

            migrationBuilder.AlterColumn<decimal>(
                name: "ItemsInStock",
                schema: "Identity",
                table: "ProductDetails",
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
    }
}
