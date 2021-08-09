using Microsoft.EntityFrameworkCore.Migrations;

namespace InventoryManagement.Persistence.Migrations
{
    public partial class fixmodel12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransactionLines_ProductDetails_ProductDetailId",
                schema: "Identity",
                table: "TransactionLines");

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

            migrationBuilder.RenameColumn(
                name: "ProductDetailId",
                schema: "Identity",
                table: "TransactionLines",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_TransactionLines_ProductDetailId",
                schema: "Identity",
                table: "TransactionLines",
                newName: "IX_TransactionLines_ProductId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionLines_Products_ProductId",
                schema: "Identity",
                table: "TransactionLines",
                column: "ProductId",
                principalSchema: "Identity",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransactionLines_Products_ProductId",
                schema: "Identity",
                table: "TransactionLines");

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

            migrationBuilder.RenameColumn(
                name: "ProductId",
                schema: "Identity",
                table: "TransactionLines",
                newName: "ProductDetailId");

            migrationBuilder.RenameIndex(
                name: "IX_TransactionLines_ProductId",
                schema: "Identity",
                table: "TransactionLines",
                newName: "IX_TransactionLines_ProductDetailId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionLines_ProductDetails_ProductDetailId",
                schema: "Identity",
                table: "TransactionLines",
                column: "ProductDetailId",
                principalSchema: "Identity",
                principalTable: "ProductDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
