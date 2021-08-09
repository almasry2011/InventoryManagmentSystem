using Microsoft.EntityFrameworkCore.Migrations;

namespace InventoryManagement.Persistence.Migrations
{
    public partial class addBuyingPrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<decimal>(
                name: "BuyingPrice",
                schema: "Identity",
                table: "TransactionLines",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "fc91abe9-cb59-4dad-a099-1f052484f59c", "c835f4b8-ccf0-4538-807f-d4374046ff3a", "SuperAdmin", "SuperAdmin" },
                    { "1af616d4-9a46-4f17-8db0-c67bbff1c593", "722359e3-97af-49d3-84c2-be7ae9839b28", "Admin", "Admin" },
                    { "678f3380-5250-4fda-a8f9-f8d45a902fd6", "228566b4-71c9-4d0a-964b-2cd015318397", "Moderator", "Moderator" },
                    { "ccc68c2c-3b39-44c0-a7aa-9e73230b7128", "4661440d-2562-4318-9fca-b6ba2cec8610", "Basic", "Basic" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "f75bc2a5-7ef5-4cd8-9fb4-237c9f6b6125", 0, "af81b6bc-f784-444a-974e-663699e55c71", "superadmin@gmail.com", true, "Amit", "Naik", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, true, "92a64f4b-6f25-4d1d-b229-35f078cd282b", false, "superadmin" },
                    { "061cfcbc-aeb0-4af8-a9b8-c1f037e54785", 0, "97479d59-df4a-49c7-aa2b-c78763868e05", "basicuser@gmail.com", true, "Basic", "User", false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, true, "14776e89-98e1-4259-99ab-60d55d611675", false, "basicuser" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "fc91abe9-cb59-4dad-a099-1f052484f59c", "f75bc2a5-7ef5-4cd8-9fb4-237c9f6b6125" },
                    { "1af616d4-9a46-4f17-8db0-c67bbff1c593", "f75bc2a5-7ef5-4cd8-9fb4-237c9f6b6125" },
                    { "678f3380-5250-4fda-a8f9-f8d45a902fd6", "f75bc2a5-7ef5-4cd8-9fb4-237c9f6b6125" },
                    { "ccc68c2c-3b39-44c0-a7aa-9e73230b7128", "061cfcbc-aeb0-4af8-a9b8-c1f037e54785" },
                    { "ccc68c2c-3b39-44c0-a7aa-9e73230b7128", "f75bc2a5-7ef5-4cd8-9fb4-237c9f6b6125" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ccc68c2c-3b39-44c0-a7aa-9e73230b7128", "061cfcbc-aeb0-4af8-a9b8-c1f037e54785" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1af616d4-9a46-4f17-8db0-c67bbff1c593", "f75bc2a5-7ef5-4cd8-9fb4-237c9f6b6125" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "678f3380-5250-4fda-a8f9-f8d45a902fd6", "f75bc2a5-7ef5-4cd8-9fb4-237c9f6b6125" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ccc68c2c-3b39-44c0-a7aa-9e73230b7128", "f75bc2a5-7ef5-4cd8-9fb4-237c9f6b6125" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fc91abe9-cb59-4dad-a099-1f052484f59c", "f75bc2a5-7ef5-4cd8-9fb4-237c9f6b6125" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "1af616d4-9a46-4f17-8db0-c67bbff1c593");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "678f3380-5250-4fda-a8f9-f8d45a902fd6");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "ccc68c2c-3b39-44c0-a7aa-9e73230b7128");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "fc91abe9-cb59-4dad-a099-1f052484f59c");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "061cfcbc-aeb0-4af8-a9b8-c1f037e54785");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "f75bc2a5-7ef5-4cd8-9fb4-237c9f6b6125");

            migrationBuilder.DropColumn(
                name: "BuyingPrice",
                schema: "Identity",
                table: "TransactionLines");

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
    }
}
