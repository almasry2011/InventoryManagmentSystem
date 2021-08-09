using Microsoft.EntityFrameworkCore.Migrations;

namespace InventoryManagement.Persistence.Migrations
{
    public partial class fixmodel1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3c1bca07-3432-410e-a13d-f2623c68c1d7", "371dd0a1-7f60-470e-be5c-8236889af3fe" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "95e09c92-82b9-4c2d-ae59-73b0f3bf1810", "371dd0a1-7f60-470e-be5c-8236889af3fe" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bebfa8db-fb19-49b6-9bde-aeedbbb17129", "371dd0a1-7f60-470e-be5c-8236889af3fe" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e1445e36-bbb2-427d-b953-34ab8e227bd0", "371dd0a1-7f60-470e-be5c-8236889af3fe" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bebfa8db-fb19-49b6-9bde-aeedbbb17129", "e29f3dc6-dda1-4698-96d2-b389f8e80881" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "3c1bca07-3432-410e-a13d-f2623c68c1d7");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "95e09c92-82b9-4c2d-ae59-73b0f3bf1810");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "bebfa8db-fb19-49b6-9bde-aeedbbb17129");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "e1445e36-bbb2-427d-b953-34ab8e227bd0");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "371dd0a1-7f60-470e-be5c-8236889af3fe");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "e29f3dc6-dda1-4698-96d2-b389f8e80881");

            migrationBuilder.DropColumn(
                name: "BoxPrice",
                schema: "Identity",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "ItemsInBox",
                schema: "Identity",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "ItemsInStock",
                schema: "Identity",
                table: "ProductDetails");

            migrationBuilder.RenameColumn(
                name: "UnitPrice",
                schema: "Identity",
                table: "TransactionLines",
                newName: "SellingUnitPrice");

            migrationBuilder.RenameColumn(
                name: "UnitPrice",
                schema: "Identity",
                table: "ProductDetails",
                newName: "UnitPriceWholeSale");

            migrationBuilder.RenameColumn(
                name: "SellingPrice",
                schema: "Identity",
                table: "ProductDetails",
                newName: "BoxPriceWholeSale");

            migrationBuilder.AddColumn<bool>(
                name: "Box",
                schema: "Identity",
                table: "TransactionLines",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "BuyingBoxPrice",
                schema: "Identity",
                table: "TransactionLines",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "BuyingUnitPrice",
                schema: "Identity",
                table: "TransactionLines",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "SellingBoxPrice",
                schema: "Identity",
                table: "TransactionLines",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<int>(
                name: "BoxNumber",
                schema: "Identity",
                table: "ProductDetails",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Box",
                schema: "Identity",
                table: "TransactionLines");

            migrationBuilder.DropColumn(
                name: "BuyingBoxPrice",
                schema: "Identity",
                table: "TransactionLines");

            migrationBuilder.DropColumn(
                name: "BuyingUnitPrice",
                schema: "Identity",
                table: "TransactionLines");

            migrationBuilder.DropColumn(
                name: "SellingBoxPrice",
                schema: "Identity",
                table: "TransactionLines");

            migrationBuilder.RenameColumn(
                name: "SellingUnitPrice",
                schema: "Identity",
                table: "TransactionLines",
                newName: "UnitPrice");

            migrationBuilder.RenameColumn(
                name: "UnitPriceWholeSale",
                schema: "Identity",
                table: "ProductDetails",
                newName: "UnitPrice");

            migrationBuilder.RenameColumn(
                name: "BoxPriceWholeSale",
                schema: "Identity",
                table: "ProductDetails",
                newName: "SellingPrice");

            migrationBuilder.AlterColumn<int>(
                name: "BoxNumber",
                schema: "Identity",
                table: "ProductDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<decimal>(
                name: "BoxPrice",
                schema: "Identity",
                table: "ProductDetails",
                type: "decimal(18,4)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemsInBox",
                schema: "Identity",
                table: "ProductDetails",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemsInStock",
                schema: "Identity",
                table: "ProductDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3c1bca07-3432-410e-a13d-f2623c68c1d7", "b3c1213d-9781-4542-9a11-1d83991ec625", "SuperAdmin", "SuperAdmin" },
                    { "e1445e36-bbb2-427d-b953-34ab8e227bd0", "2c9b1387-c361-466f-8ab0-60815912fc57", "Admin", "Admin" },
                    { "95e09c92-82b9-4c2d-ae59-73b0f3bf1810", "3cf4e015-3d7b-4614-95d9-3ecf824e9ac2", "Moderator", "Moderator" },
                    { "bebfa8db-fb19-49b6-9bde-aeedbbb17129", "8be31b3f-086c-4f38-9eaa-f917fbd833da", "Basic", "Basic" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "371dd0a1-7f60-470e-be5c-8236889af3fe", 0, "cfffdef3-0123-4408-963c-f79f87dc18eb", "superadmin@gmail.com", true, "Amit", "Naik", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, true, "6debf6a2-7ee8-49f4-854e-963492b51a3b", false, "superadmin" },
                    { "e29f3dc6-dda1-4698-96d2-b389f8e80881", 0, "6346b48d-4b4f-48ce-b93c-34b63f7d7857", "basicuser@gmail.com", true, "Basic", "User", false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, true, "0eeec294-e2fd-4a72-a505-131861050d5a", false, "basicuser" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "3c1bca07-3432-410e-a13d-f2623c68c1d7", "371dd0a1-7f60-470e-be5c-8236889af3fe" },
                    { "e1445e36-bbb2-427d-b953-34ab8e227bd0", "371dd0a1-7f60-470e-be5c-8236889af3fe" },
                    { "95e09c92-82b9-4c2d-ae59-73b0f3bf1810", "371dd0a1-7f60-470e-be5c-8236889af3fe" },
                    { "bebfa8db-fb19-49b6-9bde-aeedbbb17129", "e29f3dc6-dda1-4698-96d2-b389f8e80881" },
                    { "bebfa8db-fb19-49b6-9bde-aeedbbb17129", "371dd0a1-7f60-470e-be5c-8236889af3fe" }
                });
        }
    }
}
