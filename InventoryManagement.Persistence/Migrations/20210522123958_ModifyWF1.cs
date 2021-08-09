using Microsoft.EntityFrameworkCore.Migrations;

namespace InventoryManagement.Persistence.Migrations
{
    public partial class ModifyWF1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                schema: "Identity",
                table: "Products");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0ba1712a-62f1-4b8c-b41a-e6961cec75ef", "771cf00b-9e4f-4539-b076-4e9a6b75be93" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad0a9ab9-8780-470d-8cd3-82e2437f7a53", "771cf00b-9e4f-4539-b076-4e9a6b75be93" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bae68c63-aa86-4eea-bff9-2e7670b95510", "771cf00b-9e4f-4539-b076-4e9a6b75be93" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "db73c240-5ec6-4ecb-a1cd-03cb4510c881", "771cf00b-9e4f-4539-b076-4e9a6b75be93" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "db73c240-5ec6-4ecb-a1cd-03cb4510c881", "d859a21e-0cc9-455b-9d2e-90fa933d07fe" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "0ba1712a-62f1-4b8c-b41a-e6961cec75ef");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "ad0a9ab9-8780-470d-8cd3-82e2437f7a53");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "bae68c63-aa86-4eea-bff9-2e7670b95510");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "db73c240-5ec6-4ecb-a1cd-03cb4510c881");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "771cf00b-9e4f-4539-b076-4e9a6b75be93");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "d859a21e-0cc9-455b-9d2e-90fa933d07fe");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                schema: "Identity",
                table: "Products",
                newName: "ProductCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CategoryId",
                schema: "Identity",
                table: "Products",
                newName: "IX_Products_ProductCategoryId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_ProductCategoryId",
                schema: "Identity",
                table: "Products",
                column: "ProductCategoryId",
                principalSchema: "Identity",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_ProductCategoryId",
                schema: "Identity",
                table: "Products");

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

            migrationBuilder.RenameColumn(
                name: "ProductCategoryId",
                schema: "Identity",
                table: "Products",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_ProductCategoryId",
                schema: "Identity",
                table: "Products",
                newName: "IX_Products_CategoryId");

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "bae68c63-aa86-4eea-bff9-2e7670b95510", "b499fc35-068f-4025-a35b-6d84673e4f5b", "SuperAdmin", "SuperAdmin" },
                    { "0ba1712a-62f1-4b8c-b41a-e6961cec75ef", "cf0d9575-ac76-49e3-ae0d-4d4698ca5fc3", "Admin", "Admin" },
                    { "ad0a9ab9-8780-470d-8cd3-82e2437f7a53", "98dd286d-1482-4a76-8407-25e93b52a375", "Moderator", "Moderator" },
                    { "db73c240-5ec6-4ecb-a1cd-03cb4510c881", "25b3fec8-6f33-4106-a25e-3b21fb4b0782", "Basic", "Basic" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "771cf00b-9e4f-4539-b076-4e9a6b75be93", 0, "5b039a31-7afc-48e9-af46-1837755f260f", "superadmin@gmail.com", true, "Amit", "Naik", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, true, "8ff23087-4d96-4d70-923c-3a5055b4c339", false, "superadmin" },
                    { "d859a21e-0cc9-455b-9d2e-90fa933d07fe", 0, "4a257f32-0a2a-49cc-921b-2a7c90c1eefd", "basicuser@gmail.com", true, "Basic", "User", false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, true, "901d1982-a91c-4333-b531-5948d178435e", false, "basicuser" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "bae68c63-aa86-4eea-bff9-2e7670b95510", "771cf00b-9e4f-4539-b076-4e9a6b75be93" },
                    { "0ba1712a-62f1-4b8c-b41a-e6961cec75ef", "771cf00b-9e4f-4539-b076-4e9a6b75be93" },
                    { "ad0a9ab9-8780-470d-8cd3-82e2437f7a53", "771cf00b-9e4f-4539-b076-4e9a6b75be93" },
                    { "db73c240-5ec6-4ecb-a1cd-03cb4510c881", "d859a21e-0cc9-455b-9d2e-90fa933d07fe" },
                    { "db73c240-5ec6-4ecb-a1cd-03cb4510c881", "771cf00b-9e4f-4539-b076-4e9a6b75be93" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                schema: "Identity",
                table: "Products",
                column: "CategoryId",
                principalSchema: "Identity",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
