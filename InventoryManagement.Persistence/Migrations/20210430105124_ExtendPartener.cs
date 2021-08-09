using Microsoft.EntityFrameworkCore.Migrations;

namespace InventoryManagement.Persistence.Migrations
{
    public partial class ExtendPartener : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Email",
                schema: "Identity",
                table: "Partners",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                schema: "Identity",
                table: "Partners",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Email",
                schema: "Identity",
                table: "Partners");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                schema: "Identity",
                table: "Partners");

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
    }
}
