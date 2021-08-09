using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InventoryManagement.Persistence.Migrations
{
    public partial class fixmodel2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4298f36d-3b89-418b-9f0b-8058747df8c7", "5fef8706-0f8e-4bf9-969f-b0f3ba2e627f" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2e222a0a-a920-4f80-9a34-b365c11f2d44", "c67a449b-102c-42c8-a715-c573d8713816" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "34fceea3-e862-4d39-b984-437f6608adb3", "c67a449b-102c-42c8-a715-c573d8713816" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4298f36d-3b89-418b-9f0b-8058747df8c7", "c67a449b-102c-42c8-a715-c573d8713816" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e97f64d9-b2ca-40d8-a758-53e02ff2a425", "c67a449b-102c-42c8-a715-c573d8713816" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "2e222a0a-a920-4f80-9a34-b365c11f2d44");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "34fceea3-e862-4d39-b984-437f6608adb3");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "4298f36d-3b89-418b-9f0b-8058747df8c7");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "e97f64d9-b2ca-40d8-a758-53e02ff2a425");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "5fef8706-0f8e-4bf9-969f-b0f3ba2e627f");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "c67a449b-102c-42c8-a715-c573d8713816");

            migrationBuilder.AddColumn<decimal>(
                name: "BoxPriceWholeSale",
                schema: "Identity",
                table: "Products",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpiryDate",
                schema: "Identity",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "UnitPriceWholeSale",
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
                    { "3d68099a-4b0c-48d7-aa47-c5794a3c39c2", "cfd29e60-ee6e-47b4-a6bf-101877f3ac9b", "SuperAdmin", "SuperAdmin" },
                    { "9e09d759-c97a-4244-b46c-04981a7b744f", "827a4f4d-1c4e-4cf7-b919-f59f6730ca69", "Admin", "Admin" },
                    { "52849f3f-fa24-4e3a-a0a7-c3812f933079", "f5d409ec-2def-4954-89eb-66ba5c8c4ce2", "Moderator", "Moderator" },
                    { "22abaa2b-ee5e-4bff-b19e-dfd046b7eed8", "9fb827c3-5fef-4d27-88ed-52083930e54f", "Basic", "Basic" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5090e1a5-7ff7-4216-8b81-b922df018ca3", 0, "959af0a2-85ef-4a5e-9e85-2c7fc2054669", "superadmin@gmail.com", true, "Amit", "Naik", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, true, "bb33b3bc-decb-43cb-8f26-9ae3c8637f3f", false, "superadmin" },
                    { "491bb14b-b53d-41e1-9925-5f3479e76559", 0, "9d882619-eb2b-4c97-8e46-a0eca7dc3261", "basicuser@gmail.com", true, "Basic", "User", false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, true, "571f7dbe-ca6a-4511-99d6-80375da3e90c", false, "basicuser" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "3d68099a-4b0c-48d7-aa47-c5794a3c39c2", "5090e1a5-7ff7-4216-8b81-b922df018ca3" },
                    { "9e09d759-c97a-4244-b46c-04981a7b744f", "5090e1a5-7ff7-4216-8b81-b922df018ca3" },
                    { "52849f3f-fa24-4e3a-a0a7-c3812f933079", "5090e1a5-7ff7-4216-8b81-b922df018ca3" },
                    { "22abaa2b-ee5e-4bff-b19e-dfd046b7eed8", "491bb14b-b53d-41e1-9925-5f3479e76559" },
                    { "22abaa2b-ee5e-4bff-b19e-dfd046b7eed8", "5090e1a5-7ff7-4216-8b81-b922df018ca3" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "22abaa2b-ee5e-4bff-b19e-dfd046b7eed8", "491bb14b-b53d-41e1-9925-5f3479e76559" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "22abaa2b-ee5e-4bff-b19e-dfd046b7eed8", "5090e1a5-7ff7-4216-8b81-b922df018ca3" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3d68099a-4b0c-48d7-aa47-c5794a3c39c2", "5090e1a5-7ff7-4216-8b81-b922df018ca3" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "52849f3f-fa24-4e3a-a0a7-c3812f933079", "5090e1a5-7ff7-4216-8b81-b922df018ca3" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9e09d759-c97a-4244-b46c-04981a7b744f", "5090e1a5-7ff7-4216-8b81-b922df018ca3" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "22abaa2b-ee5e-4bff-b19e-dfd046b7eed8");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "3d68099a-4b0c-48d7-aa47-c5794a3c39c2");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "52849f3f-fa24-4e3a-a0a7-c3812f933079");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "9e09d759-c97a-4244-b46c-04981a7b744f");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "491bb14b-b53d-41e1-9925-5f3479e76559");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "5090e1a5-7ff7-4216-8b81-b922df018ca3");

            migrationBuilder.DropColumn(
                name: "BoxPriceWholeSale",
                schema: "Identity",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ExpiryDate",
                schema: "Identity",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "UnitPriceWholeSale",
                schema: "Identity",
                table: "Products");

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "34fceea3-e862-4d39-b984-437f6608adb3", "28192978-f37c-41a7-bc69-92d7ea0dc0ee", "SuperAdmin", "SuperAdmin" },
                    { "2e222a0a-a920-4f80-9a34-b365c11f2d44", "9e3ae7f0-ed4c-4b98-ba77-2621289380f2", "Admin", "Admin" },
                    { "e97f64d9-b2ca-40d8-a758-53e02ff2a425", "87a8d38d-ccf4-4a30-b5aa-027678e418a2", "Moderator", "Moderator" },
                    { "4298f36d-3b89-418b-9f0b-8058747df8c7", "bea8228c-14fa-4aee-8de8-9089f3d02235", "Basic", "Basic" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "c67a449b-102c-42c8-a715-c573d8713816", 0, "776b911d-2ac8-4d43-9053-36e9e503d933", "superadmin@gmail.com", true, "Amit", "Naik", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, true, "4a1f03d7-9868-4b60-84ea-b9eccbb88f53", false, "superadmin" },
                    { "5fef8706-0f8e-4bf9-969f-b0f3ba2e627f", 0, "19d2c7c0-306f-4e81-900d-4c08530ed970", "basicuser@gmail.com", true, "Basic", "User", false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, true, "b994f31d-ff39-4940-b1cd-f2150181a464", false, "basicuser" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "34fceea3-e862-4d39-b984-437f6608adb3", "c67a449b-102c-42c8-a715-c573d8713816" },
                    { "2e222a0a-a920-4f80-9a34-b365c11f2d44", "c67a449b-102c-42c8-a715-c573d8713816" },
                    { "e97f64d9-b2ca-40d8-a758-53e02ff2a425", "c67a449b-102c-42c8-a715-c573d8713816" },
                    { "4298f36d-3b89-418b-9f0b-8058747df8c7", "5fef8706-0f8e-4bf9-969f-b0f3ba2e627f" },
                    { "4298f36d-3b89-418b-9f0b-8058747df8c7", "c67a449b-102c-42c8-a715-c573d8713816" }
                });
        }
    }
}
