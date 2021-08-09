using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InventoryManagement.Persistence.Migrations
{
    public partial class fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "94df5302-24eb-4629-98ac-a42896c4ebdb", "1133b06e-cb0b-4360-af34-ecc7f4835619" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2278b747-ae1e-49ae-89f9-08448aa45da4", "e0bf71f7-bc43-447f-9289-e9e2bbec4aeb" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "94df5302-24eb-4629-98ac-a42896c4ebdb", "e0bf71f7-bc43-447f-9289-e9e2bbec4aeb" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c66ffd96-1975-41a9-aa66-bded68ede517", "e0bf71f7-bc43-447f-9289-e9e2bbec4aeb" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dd962a42-d02f-4f13-84ef-2b590db5faaf", "e0bf71f7-bc43-447f-9289-e9e2bbec4aeb" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "2278b747-ae1e-49ae-89f9-08448aa45da4");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "94df5302-24eb-4629-98ac-a42896c4ebdb");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "c66ffd96-1975-41a9-aa66-bded68ede517");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "dd962a42-d02f-4f13-84ef-2b590db5faaf");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "1133b06e-cb0b-4360-af34-ecc7f4835619");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "e0bf71f7-bc43-447f-9289-e9e2bbec4aeb");

            migrationBuilder.AddColumn<int>(
                name: "BoxNumbers",
                schema: "Identity",
                table: "TransactionLines",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                schema: "Identity",
                table: "TransactionLines",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpiryDate",
                schema: "Identity",
                table: "TransactionLines",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b1dc2407-3694-493d-ae1a-d6728af9261f", "b6d0ebb4-4111-4729-84e2-3a95d91c1dab", "SuperAdmin", "SuperAdmin" },
                    { "f2a1e479-9990-45c6-ae1e-bccd19a48ace", "82f4540d-1cf5-427d-98db-544e40fe6c0f", "Admin", "Admin" },
                    { "73b868f7-3fcd-47d4-8fbf-ec83109106de", "c2f07ad8-54fd-4085-877d-65874af7a99a", "Moderator", "Moderator" },
                    { "f2195368-f587-419d-aa48-1dbcb857c360", "240a3b00-f40b-4f1c-95d1-d52d86e0ff4d", "Basic", "Basic" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8bb3a2cb-97e6-4acf-9e6a-2ad76fc76936", 0, "3ec85f7a-844e-4996-bc3b-7ed9fc1c460f", "superadmin@gmail.com", true, "Amit", "Naik", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, true, "3b1e31f9-bcff-4219-bd74-af1deb521666", false, "superadmin" },
                    { "cf996c21-df59-4494-9e68-8407446ad6da", 0, "095399b6-d714-416e-b5a7-548bf0f6af51", "basicuser@gmail.com", true, "Basic", "User", false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, true, "cb6751e2-c8f9-448e-9929-0949cdd2882f", false, "basicuser" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "b1dc2407-3694-493d-ae1a-d6728af9261f", "8bb3a2cb-97e6-4acf-9e6a-2ad76fc76936" },
                    { "f2a1e479-9990-45c6-ae1e-bccd19a48ace", "8bb3a2cb-97e6-4acf-9e6a-2ad76fc76936" },
                    { "73b868f7-3fcd-47d4-8fbf-ec83109106de", "8bb3a2cb-97e6-4acf-9e6a-2ad76fc76936" },
                    { "f2195368-f587-419d-aa48-1dbcb857c360", "cf996c21-df59-4494-9e68-8407446ad6da" },
                    { "f2195368-f587-419d-aa48-1dbcb857c360", "8bb3a2cb-97e6-4acf-9e6a-2ad76fc76936" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "73b868f7-3fcd-47d4-8fbf-ec83109106de", "8bb3a2cb-97e6-4acf-9e6a-2ad76fc76936" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b1dc2407-3694-493d-ae1a-d6728af9261f", "8bb3a2cb-97e6-4acf-9e6a-2ad76fc76936" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f2195368-f587-419d-aa48-1dbcb857c360", "8bb3a2cb-97e6-4acf-9e6a-2ad76fc76936" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f2a1e479-9990-45c6-ae1e-bccd19a48ace", "8bb3a2cb-97e6-4acf-9e6a-2ad76fc76936" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f2195368-f587-419d-aa48-1dbcb857c360", "cf996c21-df59-4494-9e68-8407446ad6da" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "73b868f7-3fcd-47d4-8fbf-ec83109106de");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "b1dc2407-3694-493d-ae1a-d6728af9261f");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "f2195368-f587-419d-aa48-1dbcb857c360");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "f2a1e479-9990-45c6-ae1e-bccd19a48ace");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "8bb3a2cb-97e6-4acf-9e6a-2ad76fc76936");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "cf996c21-df59-4494-9e68-8407446ad6da");

            migrationBuilder.DropColumn(
                name: "BoxNumbers",
                schema: "Identity",
                table: "TransactionLines");

            migrationBuilder.DropColumn(
                name: "Description",
                schema: "Identity",
                table: "TransactionLines");

            migrationBuilder.DropColumn(
                name: "ExpiryDate",
                schema: "Identity",
                table: "TransactionLines");

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c66ffd96-1975-41a9-aa66-bded68ede517", "037886db-de4c-4e87-9a58-7390cc0605be", "SuperAdmin", "SuperAdmin" },
                    { "dd962a42-d02f-4f13-84ef-2b590db5faaf", "e1ca74b6-9dbb-4562-9bf2-82bf7bbcb3e5", "Admin", "Admin" },
                    { "2278b747-ae1e-49ae-89f9-08448aa45da4", "0aac444e-b560-4531-b9cd-1148fad51d70", "Moderator", "Moderator" },
                    { "94df5302-24eb-4629-98ac-a42896c4ebdb", "8e727234-1fee-4b3d-86ff-7237680bf291", "Basic", "Basic" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "e0bf71f7-bc43-447f-9289-e9e2bbec4aeb", 0, "9aa353a7-b9dc-49e9-ab42-ed401921c63e", "superadmin@gmail.com", true, "Amit", "Naik", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, true, "80f5c654-bb28-43c2-acd3-91263581d309", false, "superadmin" },
                    { "1133b06e-cb0b-4360-af34-ecc7f4835619", 0, "13b1388a-ffba-4776-8a59-15034ba6ed1d", "basicuser@gmail.com", true, "Basic", "User", false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, true, "e58416cb-78a9-4c95-a4c6-ad4fd946bac3", false, "basicuser" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "c66ffd96-1975-41a9-aa66-bded68ede517", "e0bf71f7-bc43-447f-9289-e9e2bbec4aeb" },
                    { "dd962a42-d02f-4f13-84ef-2b590db5faaf", "e0bf71f7-bc43-447f-9289-e9e2bbec4aeb" },
                    { "2278b747-ae1e-49ae-89f9-08448aa45da4", "e0bf71f7-bc43-447f-9289-e9e2bbec4aeb" },
                    { "94df5302-24eb-4629-98ac-a42896c4ebdb", "1133b06e-cb0b-4360-af34-ecc7f4835619" },
                    { "94df5302-24eb-4629-98ac-a42896c4ebdb", "e0bf71f7-bc43-447f-9289-e9e2bbec4aeb" }
                });
        }
    }
}
