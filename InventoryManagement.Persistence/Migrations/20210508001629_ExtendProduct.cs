using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InventoryManagement.Persistence.Migrations
{
    public partial class ExtendProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "07a15415-7973-499a-8992-3a11042d4225", "38bfcbd5-c239-4601-9757-e01ba8e3c37a" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "07a15415-7973-499a-8992-3a11042d4225", "555ff619-cbe2-45f3-aae5-c5feb4bf63ea" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "795ff55b-3683-4eef-8651-cec57ae9d668", "555ff619-cbe2-45f3-aae5-c5feb4bf63ea" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7d7048a8-4404-4faf-9c4d-a03c00c315e5", "555ff619-cbe2-45f3-aae5-c5feb4bf63ea" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b9ffd119-9fb0-4a7b-9715-137d755b6369", "555ff619-cbe2-45f3-aae5-c5feb4bf63ea" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "07a15415-7973-499a-8992-3a11042d4225");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "795ff55b-3683-4eef-8651-cec57ae9d668");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "7d7048a8-4404-4faf-9c4d-a03c00c315e5");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "b9ffd119-9fb0-4a7b-9715-137d755b6369");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "38bfcbd5-c239-4601-9757-e01ba8e3c37a");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "555ff619-cbe2-45f3-aae5-c5feb4bf63ea");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "ExpiryDate",
                schema: "Identity",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ItemsInBox",
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

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b9ffd119-9fb0-4a7b-9715-137d755b6369", "934a9d78-b3ff-48b6-b1bb-be9d990cb0d0", "SuperAdmin", "SuperAdmin" },
                    { "7d7048a8-4404-4faf-9c4d-a03c00c315e5", "3a586dcb-8b0b-4d3c-ae5a-ab8c3ec4ba23", "Admin", "Admin" },
                    { "795ff55b-3683-4eef-8651-cec57ae9d668", "e8e4193d-cd25-45c2-99a1-52fc59b705a4", "Moderator", "Moderator" },
                    { "07a15415-7973-499a-8992-3a11042d4225", "d0657099-8cb5-4c67-9549-5491174aa2a6", "Basic", "Basic" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "555ff619-cbe2-45f3-aae5-c5feb4bf63ea", 0, "959eeeba-60c3-471f-8579-41d4bf2de2bc", "superadmin@gmail.com", true, "Amit", "Naik", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, true, "3747bca2-1a92-4a08-8e46-c35c981a7e40", false, "superadmin" },
                    { "38bfcbd5-c239-4601-9757-e01ba8e3c37a", 0, "bc60ab7f-891b-4c33-9b0b-e04a7e3eb96a", "basicuser@gmail.com", true, "Basic", "User", false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, true, "8387178c-39c1-45d3-9f09-c241cae25443", false, "basicuser" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "b9ffd119-9fb0-4a7b-9715-137d755b6369", "555ff619-cbe2-45f3-aae5-c5feb4bf63ea" },
                    { "7d7048a8-4404-4faf-9c4d-a03c00c315e5", "555ff619-cbe2-45f3-aae5-c5feb4bf63ea" },
                    { "795ff55b-3683-4eef-8651-cec57ae9d668", "555ff619-cbe2-45f3-aae5-c5feb4bf63ea" },
                    { "07a15415-7973-499a-8992-3a11042d4225", "38bfcbd5-c239-4601-9757-e01ba8e3c37a" },
                    { "07a15415-7973-499a-8992-3a11042d4225", "555ff619-cbe2-45f3-aae5-c5feb4bf63ea" }
                });
        }
    }
}
