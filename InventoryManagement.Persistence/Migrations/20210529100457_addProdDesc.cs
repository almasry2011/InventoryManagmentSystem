using Microsoft.EntityFrameworkCore.Migrations;

namespace InventoryManagement.Persistence.Migrations
{
    public partial class addProdDesc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6f2fbb78-ada0-44e8-81c5-4db99968fafc", "71304f09-5c5e-4071-90fe-668f31f0f508" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "899ed8aa-3408-4b7f-8266-e4e9fa6cee6b", "71304f09-5c5e-4071-90fe-668f31f0f508" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d1ebd827-73cc-4c7c-b7ec-0a64b888728a", "71304f09-5c5e-4071-90fe-668f31f0f508" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d2aed534-8ea1-470f-91d1-2061c290148c", "71304f09-5c5e-4071-90fe-668f31f0f508" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d2aed534-8ea1-470f-91d1-2061c290148c", "cc242d2f-e02a-4c63-a647-4f33bd2b6962" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "6f2fbb78-ada0-44e8-81c5-4db99968fafc");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "899ed8aa-3408-4b7f-8266-e4e9fa6cee6b");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "d1ebd827-73cc-4c7c-b7ec-0a64b888728a");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "d2aed534-8ea1-470f-91d1-2061c290148c");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "71304f09-5c5e-4071-90fe-668f31f0f508");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "cc242d2f-e02a-4c63-a647-4f33bd2b6962");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                schema: "Identity",
                table: "Products",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Description",
                schema: "Identity",
                table: "Products");

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6f2fbb78-ada0-44e8-81c5-4db99968fafc", "6133c98d-c6d8-4023-ab79-561ee68993a0", "SuperAdmin", "SuperAdmin" },
                    { "899ed8aa-3408-4b7f-8266-e4e9fa6cee6b", "1a21da25-c28f-40a0-b724-30b687a7a510", "Admin", "Admin" },
                    { "d1ebd827-73cc-4c7c-b7ec-0a64b888728a", "2eea4306-a67a-4542-99f6-c9235d66ccac", "Moderator", "Moderator" },
                    { "d2aed534-8ea1-470f-91d1-2061c290148c", "32dade47-b22f-48ab-98bf-795ec0456c66", "Basic", "Basic" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "71304f09-5c5e-4071-90fe-668f31f0f508", 0, "8f85efa0-cbf1-4b85-a6bb-3f2663580b9f", "superadmin@gmail.com", true, "Amit", "Naik", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, true, "dc25de1e-2a1b-489a-ab79-bc9ead938cbf", false, "superadmin" },
                    { "cc242d2f-e02a-4c63-a647-4f33bd2b6962", 0, "ae33f139-bcb4-465a-afed-74b31f192de8", "basicuser@gmail.com", true, "Basic", "User", false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, true, "7949fe48-90ae-4fc4-8d20-cc104b8dbaf4", false, "basicuser" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "6f2fbb78-ada0-44e8-81c5-4db99968fafc", "71304f09-5c5e-4071-90fe-668f31f0f508" },
                    { "899ed8aa-3408-4b7f-8266-e4e9fa6cee6b", "71304f09-5c5e-4071-90fe-668f31f0f508" },
                    { "d1ebd827-73cc-4c7c-b7ec-0a64b888728a", "71304f09-5c5e-4071-90fe-668f31f0f508" },
                    { "d2aed534-8ea1-470f-91d1-2061c290148c", "cc242d2f-e02a-4c63-a647-4f33bd2b6962" },
                    { "d2aed534-8ea1-470f-91d1-2061c290148c", "71304f09-5c5e-4071-90fe-668f31f0f508" }
                });
        }
    }
}
