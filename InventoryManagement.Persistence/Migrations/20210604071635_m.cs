using Microsoft.EntityFrameworkCore.Migrations;

namespace InventoryManagement.Persistence.Migrations
{
    public partial class m : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1668b105-162e-4b6f-bb47-60c2c4d3d78a", "64bf6b41-cf1a-4b58-bcff-f7d00f57bdca" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7888cfd7-5e71-4fea-94dc-6bd8eb8c3df4", "64bf6b41-cf1a-4b58-bcff-f7d00f57bdca" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8b4ee445-60ec-4eee-939b-0c174cc607b7", "64bf6b41-cf1a-4b58-bcff-f7d00f57bdca" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a7edf2f2-bf75-4b9f-b2a0-ce5ffe30eb44", "64bf6b41-cf1a-4b58-bcff-f7d00f57bdca" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7888cfd7-5e71-4fea-94dc-6bd8eb8c3df4", "e74a8c70-b56f-49e3-9589-0dfc8beb3d10" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "1668b105-162e-4b6f-bb47-60c2c4d3d78a");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "7888cfd7-5e71-4fea-94dc-6bd8eb8c3df4");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "8b4ee445-60ec-4eee-939b-0c174cc607b7");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "a7edf2f2-bf75-4b9f-b2a0-ce5ffe30eb44");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "64bf6b41-cf1a-4b58-bcff-f7d00f57bdca");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "e74a8c70-b56f-49e3-9589-0dfc8beb3d10");

            migrationBuilder.AddColumn<decimal>(
                name: "ItemsInStock",
                schema: "Identity",
                table: "ProductDetails",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "ItemsInStock",
                schema: "Identity",
                table: "ProductDetails");

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a7edf2f2-bf75-4b9f-b2a0-ce5ffe30eb44", "0eacb8f1-e2ad-45e1-9418-9ec3679eb5b8", "SuperAdmin", "SuperAdmin" },
                    { "8b4ee445-60ec-4eee-939b-0c174cc607b7", "d179a39b-8849-417b-964a-66e0da74d8a0", "Admin", "Admin" },
                    { "1668b105-162e-4b6f-bb47-60c2c4d3d78a", "161aa507-39f3-434d-a97c-1db42b9d8723", "Moderator", "Moderator" },
                    { "7888cfd7-5e71-4fea-94dc-6bd8eb8c3df4", "2ada6030-7f3d-41e9-b18c-c965af556210", "Basic", "Basic" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "64bf6b41-cf1a-4b58-bcff-f7d00f57bdca", 0, "3eb3e74e-8751-44c3-956b-848713358523", "superadmin@gmail.com", true, "Amit", "Naik", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, true, "101d5442-e98b-49db-8754-31a0a8319fa8", false, "superadmin" },
                    { "e74a8c70-b56f-49e3-9589-0dfc8beb3d10", 0, "ab395946-3fee-4dbd-aa89-f4170e2f7e45", "basicuser@gmail.com", true, "Basic", "User", false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, true, "a12e8eb5-b539-4306-afe2-78c026881593", false, "basicuser" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "a7edf2f2-bf75-4b9f-b2a0-ce5ffe30eb44", "64bf6b41-cf1a-4b58-bcff-f7d00f57bdca" },
                    { "8b4ee445-60ec-4eee-939b-0c174cc607b7", "64bf6b41-cf1a-4b58-bcff-f7d00f57bdca" },
                    { "1668b105-162e-4b6f-bb47-60c2c4d3d78a", "64bf6b41-cf1a-4b58-bcff-f7d00f57bdca" },
                    { "7888cfd7-5e71-4fea-94dc-6bd8eb8c3df4", "e74a8c70-b56f-49e3-9589-0dfc8beb3d10" },
                    { "7888cfd7-5e71-4fea-94dc-6bd8eb8c3df4", "64bf6b41-cf1a-4b58-bcff-f7d00f57bdca" }
                });
        }
    }
}
