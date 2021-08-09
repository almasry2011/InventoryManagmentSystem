using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InventoryManagement.Persistence.Migrations
{
    public partial class removeWHlocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_warehouses_Locations_LocationId",
                schema: "Identity",
                table: "warehouses");

            migrationBuilder.DropTable(
                name: "Locations",
                schema: "Identity");

            migrationBuilder.DropIndex(
                name: "IX_warehouses_LocationId",
                schema: "Identity",
                table: "warehouses");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9e64d284-3d46-4402-b4ac-58c2778234e1", "8dd6a841-59c7-4d5b-9ec0-c312e4412fba" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "09a43c8d-8905-4091-881c-f0082f2bc4a5", "c4e6fda1-39fe-4d36-a637-ade8a061c982" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9c70af97-0177-4a55-9528-15cb499b9a46", "c4e6fda1-39fe-4d36-a637-ade8a061c982" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9e64d284-3d46-4402-b4ac-58c2778234e1", "c4e6fda1-39fe-4d36-a637-ade8a061c982" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "aea4dc09-3e47-49dd-93a6-84b9c53869b4", "c4e6fda1-39fe-4d36-a637-ade8a061c982" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "09a43c8d-8905-4091-881c-f0082f2bc4a5");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "9c70af97-0177-4a55-9528-15cb499b9a46");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "9e64d284-3d46-4402-b4ac-58c2778234e1");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "aea4dc09-3e47-49dd-93a6-84b9c53869b4");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "8dd6a841-59c7-4d5b-9ec0-c312e4412fba");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "c4e6fda1-39fe-4d36-a637-ade8a061c982");

            migrationBuilder.DropColumn(
                name: "LocationId",
                schema: "Identity",
                table: "warehouses");

            migrationBuilder.AddColumn<string>(
                name: "LocationAddress_City",
                schema: "Identity",
                table: "warehouses",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LocationAddress_Country",
                schema: "Identity",
                table: "warehouses",
                type: "nvarchar(90)",
                maxLength: 90,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LocationAddress_State",
                schema: "Identity",
                table: "warehouses",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LocationAddress_Street",
                schema: "Identity",
                table: "warehouses",
                type: "nvarchar(180)",
                maxLength: 180,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LocationAddress_ZipCode",
                schema: "Identity",
                table: "warehouses",
                type: "nvarchar(18)",
                maxLength: 18,
                nullable: true);

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0b6fa37e-86f4-470b-b92e-38e44b2e4c40", "1afa1248-5b1c-46f8-99ae-204669112488", "SuperAdmin", "SuperAdmin" },
                    { "ab99d197-342a-4631-ac89-4f2c77b51fad", "78a9f75b-7e28-4d46-b931-18af2b8ca59f", "Admin", "Admin" },
                    { "3b95f19a-0ff0-4f1a-ac0c-144073eb1f29", "51783979-e4c9-4c7b-a080-da7bb54c2662", "Moderator", "Moderator" },
                    { "92d32b7b-17e3-4f59-9500-7630e930260d", "2e91e817-b7e1-4b73-b470-1f775de0f17e", "Basic", "Basic" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "07848b16-e2bd-4406-aed3-5ffdf0adeacd", 0, "f4e10c29-d479-432f-a428-530c57197833", "superadmin@gmail.com", true, "Amit", "Naik", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, true, "92d05d58-1c51-488c-97c7-adb388790728", false, "superadmin" },
                    { "ec3d9201-7518-4c94-bc46-bb894d039673", 0, "ed7f45de-d876-421f-9645-0f126b240486", "basicuser@gmail.com", true, "Basic", "User", false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, true, "ad0c4c45-abc8-47b9-85ed-c2dc42ee63e5", false, "basicuser" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "0b6fa37e-86f4-470b-b92e-38e44b2e4c40", "07848b16-e2bd-4406-aed3-5ffdf0adeacd" },
                    { "ab99d197-342a-4631-ac89-4f2c77b51fad", "07848b16-e2bd-4406-aed3-5ffdf0adeacd" },
                    { "3b95f19a-0ff0-4f1a-ac0c-144073eb1f29", "07848b16-e2bd-4406-aed3-5ffdf0adeacd" },
                    { "92d32b7b-17e3-4f59-9500-7630e930260d", "ec3d9201-7518-4c94-bc46-bb894d039673" },
                    { "92d32b7b-17e3-4f59-9500-7630e930260d", "07848b16-e2bd-4406-aed3-5ffdf0adeacd" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0b6fa37e-86f4-470b-b92e-38e44b2e4c40", "07848b16-e2bd-4406-aed3-5ffdf0adeacd" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3b95f19a-0ff0-4f1a-ac0c-144073eb1f29", "07848b16-e2bd-4406-aed3-5ffdf0adeacd" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "92d32b7b-17e3-4f59-9500-7630e930260d", "07848b16-e2bd-4406-aed3-5ffdf0adeacd" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ab99d197-342a-4631-ac89-4f2c77b51fad", "07848b16-e2bd-4406-aed3-5ffdf0adeacd" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "92d32b7b-17e3-4f59-9500-7630e930260d", "ec3d9201-7518-4c94-bc46-bb894d039673" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "0b6fa37e-86f4-470b-b92e-38e44b2e4c40");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "3b95f19a-0ff0-4f1a-ac0c-144073eb1f29");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "92d32b7b-17e3-4f59-9500-7630e930260d");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "ab99d197-342a-4631-ac89-4f2c77b51fad");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "07848b16-e2bd-4406-aed3-5ffdf0adeacd");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "ec3d9201-7518-4c94-bc46-bb894d039673");

            migrationBuilder.DropColumn(
                name: "LocationAddress_City",
                schema: "Identity",
                table: "warehouses");

            migrationBuilder.DropColumn(
                name: "LocationAddress_Country",
                schema: "Identity",
                table: "warehouses");

            migrationBuilder.DropColumn(
                name: "LocationAddress_State",
                schema: "Identity",
                table: "warehouses");

            migrationBuilder.DropColumn(
                name: "LocationAddress_Street",
                schema: "Identity",
                table: "warehouses");

            migrationBuilder.DropColumn(
                name: "LocationAddress_ZipCode",
                schema: "Identity",
                table: "warehouses");

            migrationBuilder.AddColumn<long>(
                name: "LocationId",
                schema: "Identity",
                table: "warehouses",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "Locations",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationAddress_City = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LocationAddress_Country = table.Column<string>(type: "nvarchar(90)", maxLength: 90, nullable: true),
                    LocationAddress_State = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    LocationAddress_Street = table.Column<string>(type: "nvarchar(180)", maxLength: 180, nullable: true),
                    LocationAddress_ZipCode = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9c70af97-0177-4a55-9528-15cb499b9a46", "a7c9e25a-0db5-4a79-ae49-4b8eceae979e", "SuperAdmin", "SuperAdmin" },
                    { "09a43c8d-8905-4091-881c-f0082f2bc4a5", "58f33116-fc8b-46c2-b017-0112c6c8c11a", "Admin", "Admin" },
                    { "aea4dc09-3e47-49dd-93a6-84b9c53869b4", "0d8f54f2-9e0a-4de6-a5a2-74bb07094172", "Moderator", "Moderator" },
                    { "9e64d284-3d46-4402-b4ac-58c2778234e1", "7b5aeb8a-8f27-46a7-b1b8-92ef4cd8bccd", "Basic", "Basic" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "c4e6fda1-39fe-4d36-a637-ade8a061c982", 0, "38eb1e04-1490-445f-b4cb-e6b74addbfbf", "superadmin@gmail.com", true, "Amit", "Naik", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, true, "b5a5e717-706f-4fd6-a55c-43b4383950aa", false, "superadmin" },
                    { "8dd6a841-59c7-4d5b-9ec0-c312e4412fba", 0, "2f2f83cc-f6a5-46b9-8f6c-af099986bdb1", "basicuser@gmail.com", true, "Basic", "User", false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, true, "7e452379-054b-4c26-895d-b9ec3eb3048f", false, "basicuser" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "9c70af97-0177-4a55-9528-15cb499b9a46", "c4e6fda1-39fe-4d36-a637-ade8a061c982" },
                    { "09a43c8d-8905-4091-881c-f0082f2bc4a5", "c4e6fda1-39fe-4d36-a637-ade8a061c982" },
                    { "aea4dc09-3e47-49dd-93a6-84b9c53869b4", "c4e6fda1-39fe-4d36-a637-ade8a061c982" },
                    { "9e64d284-3d46-4402-b4ac-58c2778234e1", "8dd6a841-59c7-4d5b-9ec0-c312e4412fba" },
                    { "9e64d284-3d46-4402-b4ac-58c2778234e1", "c4e6fda1-39fe-4d36-a637-ade8a061c982" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_warehouses_LocationId",
                schema: "Identity",
                table: "warehouses",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_warehouses_Locations_LocationId",
                schema: "Identity",
                table: "warehouses",
                column: "LocationId",
                principalSchema: "Identity",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
