using Microsoft.EntityFrameworkCore.Migrations;

namespace InventoryManagement.Persistence.Migrations
{
    public partial class addItemsInBox : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "afa0bf30-debb-4dc4-9fea-99035fc0477e", "2961c5f6-563a-4a1c-8d79-ceb6b9be5b6e" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5ff9cae4-5067-4219-99d5-1998aada98fa", "ffe076e2-ca09-4bb4-8697-0350b851960d" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8823e6ba-ba5e-4332-b11c-72a9b895bdce", "ffe076e2-ca09-4bb4-8697-0350b851960d" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "afa0bf30-debb-4dc4-9fea-99035fc0477e", "ffe076e2-ca09-4bb4-8697-0350b851960d" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f9a93517-825b-4bfd-86d6-f5fe7a216a01", "ffe076e2-ca09-4bb4-8697-0350b851960d" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "5ff9cae4-5067-4219-99d5-1998aada98fa");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "8823e6ba-ba5e-4332-b11c-72a9b895bdce");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "afa0bf30-debb-4dc4-9fea-99035fc0477e");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "f9a93517-825b-4bfd-86d6-f5fe7a216a01");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "2961c5f6-563a-4a1c-8d79-ceb6b9be5b6e");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "ffe076e2-ca09-4bb4-8697-0350b851960d");

            migrationBuilder.AddColumn<int>(
                name: "ItemsInBox",
                schema: "Identity",
                table: "Products",
                type: "int",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "ItemsInBox",
                schema: "Identity",
                table: "Products");

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8823e6ba-ba5e-4332-b11c-72a9b895bdce", "3215c232-7b87-4e38-a36f-221ca67010c0", "SuperAdmin", "SuperAdmin" },
                    { "f9a93517-825b-4bfd-86d6-f5fe7a216a01", "c30ea6ab-527f-4abc-a3e4-870273593f3e", "Admin", "Admin" },
                    { "5ff9cae4-5067-4219-99d5-1998aada98fa", "c8e90475-8af6-4351-bee6-94f98d63e668", "Moderator", "Moderator" },
                    { "afa0bf30-debb-4dc4-9fea-99035fc0477e", "73162af0-74b7-45a7-bf4e-ad3c826eeb9c", "Basic", "Basic" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "ffe076e2-ca09-4bb4-8697-0350b851960d", 0, "ae619e1b-9e2a-4d77-874f-d3b69653625e", "superadmin@gmail.com", true, "Amit", "Naik", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, true, "1952b038-dc3e-4890-bf24-cf5ce0a7003d", false, "superadmin" },
                    { "2961c5f6-563a-4a1c-8d79-ceb6b9be5b6e", 0, "1b401c74-263f-4291-9341-388fede164c3", "basicuser@gmail.com", true, "Basic", "User", false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, true, "3be651b5-1ff4-4ade-a738-f430049c0038", false, "basicuser" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8823e6ba-ba5e-4332-b11c-72a9b895bdce", "ffe076e2-ca09-4bb4-8697-0350b851960d" },
                    { "f9a93517-825b-4bfd-86d6-f5fe7a216a01", "ffe076e2-ca09-4bb4-8697-0350b851960d" },
                    { "5ff9cae4-5067-4219-99d5-1998aada98fa", "ffe076e2-ca09-4bb4-8697-0350b851960d" },
                    { "afa0bf30-debb-4dc4-9fea-99035fc0477e", "2961c5f6-563a-4a1c-8d79-ceb6b9be5b6e" },
                    { "afa0bf30-debb-4dc4-9fea-99035fc0477e", "ffe076e2-ca09-4bb4-8697-0350b851960d" }
                });
        }
    }
}
