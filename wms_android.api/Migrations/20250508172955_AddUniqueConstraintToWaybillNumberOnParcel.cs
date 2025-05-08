using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace wms_android.api.Migrations
{
    /// <inheritdoc />
    public partial class AddUniqueConstraintToWaybillNumberOnParcel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("1f79a484-ecd5-40fc-becd-d0190aac0371"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("31cf2ffc-bfb7-4159-b49e-14144b60a8c3"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("63b3bc50-0c2f-427a-bd92-2ee71bbb8c80"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("6d2560e2-9a3d-44e2-ad62-fc11a726d622"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("7bc4637a-9aef-4900-8fed-0c5a1ac64e8c"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("8a3947c8-0ba9-4f9c-ab58-bc18458d1d1e"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("a90874f4-dda9-4456-a16d-2e668795443f"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("a9577d0b-78ed-42a0-9827-fc33e429ea7b"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("d9a073e9-13aa-4dad-b5e4-50a0324badea"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("ff7b4ea2-d6c9-4487-82f6-dde1f74ab013"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("25fd0e09-1386-4645-8d37-0a36b1460ccb"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("32351ee0-df50-4258-b2ee-6016e94978bc"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("401602aa-c11d-4a45-8c63-beb2c2f4e40e"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("6ebdf843-852c-4500-a5d7-2da30c5c25f3"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("b5b08316-57e4-410b-a3b4-6014aefffe1d"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("bf0423ca-b501-4b90-8828-9d485be0b51b"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("d427c237-51a4-48b4-baea-ab96485edeee"));

            migrationBuilder.AlterColumn<decimal>(
                name: "Rate",
                table: "Parcels",
                type: "numeric",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "Parcels",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Parcels",
                type: "numeric",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "FirstName", "Initials", "LastName", "LicenseNumber" },
                values: new object[,]
                {
                    { new Guid("38d55623-9cfd-47dc-a3c5-5a8201d4dc74"), "Charles", "CM", "Maina", "DL123456" },
                    { new Guid("3deee9fc-df26-4a88-b057-1b481fb3b2b6"), "James", "JG", "Gichohi", "DL123456" },
                    { new Guid("5711642f-839f-40f2-a503-a47237a68723"), "Erastus", "EK", "Kagwa", "DL123456" },
                    { new Guid("7e7b6721-7707-422e-bfc9-5ed326ae5df8"), "John", "JN", "Njuguna", "DL123456" },
                    { new Guid("7feac365-2621-4628-9abe-927d082a1ffd"), "David", "DM", "Mwangi", "DL123456" },
                    { new Guid("853a7091-8ce6-44da-8c86-6e4aebf5431a"), "Stephen", "SK", "Kimuyu", "DL123456" },
                    { new Guid("ad5217fb-bbfd-4a78-b5fd-41b730c179c0"), "David", "DK", "Kibet", "DL123456" },
                    { new Guid("b5e02260-931d-429c-ac76-e296dc4f8173"), "Julius", "JK", "Kamula", "DL123456" },
                    { new Guid("b968efbd-9902-43cc-8d22-f7310928919e"), "Robert", "RN", "Njuguna", "DL123456" },
                    { new Guid("d8aa286a-d1b2-42ec-888f-c6128dcbc1f8"), "John", "JM", "Mwai", "DL123456" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 69, 230, 100, 239, 55, 150, 58, 102, 159, 201, 20, 20, 242, 15, 16, 93, 169, 24, 34, 254, 254, 140, 98, 212, 213, 107, 12, 76, 138, 30, 232, 165, 209, 104, 181, 218, 157, 78, 167, 22, 221, 109, 73, 4, 198, 124, 208, 68, 53, 70, 93, 38, 34, 25, 169, 90, 81, 93, 19, 66, 6, 181, 34, 100 }, new byte[] { 30, 190, 111, 218, 166, 160, 114, 170, 152, 237, 22, 48, 14, 110, 190, 221, 194, 188, 96, 158, 249, 255, 117, 222, 12, 86, 182, 169, 151, 224, 101, 28, 247, 172, 16, 152, 141, 240, 105, 112, 228, 129, 229, 116, 207, 50, 123, 233, 128, 51, 88, 235, 228, 218, 91, 37, 182, 189, 82, 2, 73, 186, 60, 11, 35, 187, 128, 79, 228, 211, 63, 71, 106, 123, 61, 151, 5, 139, 18, 10, 139, 20, 67, 32, 57, 164, 70, 82, 83, 36, 35, 39, 93, 154, 2, 100, 253, 179, 187, 222, 151, 212, 105, 68, 237, 93, 58, 189, 142, 132, 59, 106, 154, 228, 30, 255, 250, 199, 249, 75, 251, 241, 217, 49, 55, 205, 187, 231 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 69, 230, 100, 239, 55, 150, 58, 102, 159, 201, 20, 20, 242, 15, 16, 93, 169, 24, 34, 254, 254, 140, 98, 212, 213, 107, 12, 76, 138, 30, 232, 165, 209, 104, 181, 218, 157, 78, 167, 22, 221, 109, 73, 4, 198, 124, 208, 68, 53, 70, 93, 38, 34, 25, 169, 90, 81, 93, 19, 66, 6, 181, 34, 100 }, new byte[] { 30, 190, 111, 218, 166, 160, 114, 170, 152, 237, 22, 48, 14, 110, 190, 221, 194, 188, 96, 158, 249, 255, 117, 222, 12, 86, 182, 169, 151, 224, 101, 28, 247, 172, 16, 152, 141, 240, 105, 112, 228, 129, 229, 116, 207, 50, 123, 233, 128, 51, 88, 235, 228, 218, 91, 37, 182, 189, 82, 2, 73, 186, 60, 11, 35, 187, 128, 79, 228, 211, 63, 71, 106, 123, 61, 151, 5, 139, 18, 10, 139, 20, 67, 32, 57, 164, 70, 82, 83, 36, 35, 39, 93, 154, 2, 100, 253, 179, 187, 222, 151, 212, 105, 68, 237, 93, 58, 189, 142, 132, 59, 106, 154, 228, 30, 255, 250, 199, 249, 75, 251, 241, 217, 49, 55, 205, 187, 231 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 69, 230, 100, 239, 55, 150, 58, 102, 159, 201, 20, 20, 242, 15, 16, 93, 169, 24, 34, 254, 254, 140, 98, 212, 213, 107, 12, 76, 138, 30, 232, 165, 209, 104, 181, 218, 157, 78, 167, 22, 221, 109, 73, 4, 198, 124, 208, 68, 53, 70, 93, 38, 34, 25, 169, 90, 81, 93, 19, 66, 6, 181, 34, 100 }, new byte[] { 30, 190, 111, 218, 166, 160, 114, 170, 152, 237, 22, 48, 14, 110, 190, 221, 194, 188, 96, 158, 249, 255, 117, 222, 12, 86, 182, 169, 151, 224, 101, 28, 247, 172, 16, 152, 141, 240, 105, 112, 228, 129, 229, 116, 207, 50, 123, 233, 128, 51, 88, 235, 228, 218, 91, 37, 182, 189, 82, 2, 73, 186, 60, 11, 35, 187, 128, 79, 228, 211, 63, 71, 106, 123, 61, 151, 5, 139, 18, 10, 139, 20, 67, 32, 57, 164, 70, 82, 83, 36, 35, 39, 93, 154, 2, 100, 253, 179, 187, 222, 151, 212, 105, 68, 237, 93, 58, 189, 142, 132, 59, 106, 154, 228, 30, 255, 250, 199, 249, 75, 251, 241, 217, 49, 55, 205, 187, 231 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 69, 230, 100, 239, 55, 150, 58, 102, 159, 201, 20, 20, 242, 15, 16, 93, 169, 24, 34, 254, 254, 140, 98, 212, 213, 107, 12, 76, 138, 30, 232, 165, 209, 104, 181, 218, 157, 78, 167, 22, 221, 109, 73, 4, 198, 124, 208, 68, 53, 70, 93, 38, 34, 25, 169, 90, 81, 93, 19, 66, 6, 181, 34, 100 }, new byte[] { 30, 190, 111, 218, 166, 160, 114, 170, 152, 237, 22, 48, 14, 110, 190, 221, 194, 188, 96, 158, 249, 255, 117, 222, 12, 86, 182, 169, 151, 224, 101, 28, 247, 172, 16, 152, 141, 240, 105, 112, 228, 129, 229, 116, 207, 50, 123, 233, 128, 51, 88, 235, 228, 218, 91, 37, 182, 189, 82, 2, 73, 186, 60, 11, 35, 187, 128, 79, 228, 211, 63, 71, 106, 123, 61, 151, 5, 139, 18, 10, 139, 20, 67, 32, 57, 164, 70, 82, 83, 36, 35, 39, 93, 154, 2, 100, 253, 179, 187, 222, 151, 212, 105, 68, 237, 93, 58, 189, 142, 132, 59, 106, 154, 228, 30, 255, 250, 199, 249, 75, 251, 241, 217, 49, 55, 205, 187, 231 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 69, 230, 100, 239, 55, 150, 58, 102, 159, 201, 20, 20, 242, 15, 16, 93, 169, 24, 34, 254, 254, 140, 98, 212, 213, 107, 12, 76, 138, 30, 232, 165, 209, 104, 181, 218, 157, 78, 167, 22, 221, 109, 73, 4, 198, 124, 208, 68, 53, 70, 93, 38, 34, 25, 169, 90, 81, 93, 19, 66, 6, 181, 34, 100 }, new byte[] { 30, 190, 111, 218, 166, 160, 114, 170, 152, 237, 22, 48, 14, 110, 190, 221, 194, 188, 96, 158, 249, 255, 117, 222, 12, 86, 182, 169, 151, 224, 101, 28, 247, 172, 16, 152, 141, 240, 105, 112, 228, 129, 229, 116, 207, 50, 123, 233, 128, 51, 88, 235, 228, 218, 91, 37, 182, 189, 82, 2, 73, 186, 60, 11, 35, 187, 128, 79, 228, 211, 63, 71, 106, 123, 61, 151, 5, 139, 18, 10, 139, 20, 67, 32, 57, 164, 70, 82, 83, 36, 35, 39, 93, 154, 2, 100, 253, 179, 187, 222, 151, 212, 105, 68, 237, 93, 58, 189, 142, 132, 59, 106, 154, 228, 30, 255, 250, 199, 249, 75, 251, 241, 217, 49, 55, 205, 187, 231 } });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "BodyType", "VehicleRegistrationNumber" },
                values: new object[,]
                {
                    { new Guid("1329677b-2da9-4447-80ef-b3f690a0f104"), "Truck", "KDE 228S" },
                    { new Guid("298f6d68-f82a-4c75-a633-ddda65544101"), "Truck", "KDL 085M" },
                    { new Guid("3a0d96cd-9d48-46f8-afd9-64dcf7d55696"), "Truck", "KCY 067A" },
                    { new Guid("91c167f1-0d1c-44e9-8ee0-c043668b69f0"), "Van", "KBF 462A" },
                    { new Guid("a815f695-023b-4255-8fe6-be3c404b2f5f"), "Van", "KAY 215H" },
                    { new Guid("c314bca0-212d-4ad7-a03a-fda881255b98"), "Truck", "KDB 387Q" },
                    { new Guid("f04e7d37-2a2c-4549-a575-f794053489c9"), "Truck", "KCZ 595L" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Parcels_WaybillNumber",
                table: "Parcels",
                column: "WaybillNumber",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Parcels_WaybillNumber",
                table: "Parcels");

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("38d55623-9cfd-47dc-a3c5-5a8201d4dc74"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("3deee9fc-df26-4a88-b057-1b481fb3b2b6"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("5711642f-839f-40f2-a503-a47237a68723"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("7e7b6721-7707-422e-bfc9-5ed326ae5df8"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("7feac365-2621-4628-9abe-927d082a1ffd"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("853a7091-8ce6-44da-8c86-6e4aebf5431a"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("ad5217fb-bbfd-4a78-b5fd-41b730c179c0"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("b5e02260-931d-429c-ac76-e296dc4f8173"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("b968efbd-9902-43cc-8d22-f7310928919e"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("d8aa286a-d1b2-42ec-888f-c6128dcbc1f8"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("1329677b-2da9-4447-80ef-b3f690a0f104"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("298f6d68-f82a-4c75-a633-ddda65544101"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("3a0d96cd-9d48-46f8-afd9-64dcf7d55696"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("91c167f1-0d1c-44e9-8ee0-c043668b69f0"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("a815f695-023b-4255-8fe6-be3c404b2f5f"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("c314bca0-212d-4ad7-a03a-fda881255b98"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("f04e7d37-2a2c-4549-a575-f794053489c9"));

            migrationBuilder.AlterColumn<decimal>(
                name: "Rate",
                table: "Parcels",
                type: "numeric",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "numeric",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "Parcels",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Parcels",
                type: "numeric",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "numeric",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "FirstName", "Initials", "LastName", "LicenseNumber" },
                values: new object[,]
                {
                    { new Guid("1f79a484-ecd5-40fc-becd-d0190aac0371"), "Stephen", "SK", "Kimuyu", "DL123456" },
                    { new Guid("31cf2ffc-bfb7-4159-b49e-14144b60a8c3"), "John", "JN", "Njuguna", "DL123456" },
                    { new Guid("63b3bc50-0c2f-427a-bd92-2ee71bbb8c80"), "Julius", "JK", "Kamula", "DL123456" },
                    { new Guid("6d2560e2-9a3d-44e2-ad62-fc11a726d622"), "John", "JM", "Mwai", "DL123456" },
                    { new Guid("7bc4637a-9aef-4900-8fed-0c5a1ac64e8c"), "David", "DK", "Kibet", "DL123456" },
                    { new Guid("8a3947c8-0ba9-4f9c-ab58-bc18458d1d1e"), "Charles", "CM", "Maina", "DL123456" },
                    { new Guid("a90874f4-dda9-4456-a16d-2e668795443f"), "David", "DM", "Mwangi", "DL123456" },
                    { new Guid("a9577d0b-78ed-42a0-9827-fc33e429ea7b"), "Robert", "RN", "Njuguna", "DL123456" },
                    { new Guid("d9a073e9-13aa-4dad-b5e4-50a0324badea"), "James", "JG", "Gichohi", "DL123456" },
                    { new Guid("ff7b4ea2-d6c9-4487-82f6-dde1f74ab013"), "Erastus", "EK", "Kagwa", "DL123456" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 212, 11, 140, 206, 165, 108, 65, 20, 204, 234, 1, 199, 97, 223, 223, 10, 189, 116, 39, 119, 28, 51, 26, 199, 116, 35, 233, 135, 230, 56, 27, 106, 105, 8, 18, 175, 2, 28, 184, 238, 94, 69, 85, 202, 135, 45, 149, 195, 5, 164, 164, 177, 86, 34, 5, 188, 173, 115, 173, 30, 89, 230, 162, 2 }, new byte[] { 237, 90, 47, 184, 253, 46, 147, 129, 82, 196, 27, 209, 148, 101, 188, 223, 213, 133, 217, 193, 138, 215, 84, 60, 133, 171, 167, 123, 237, 80, 221, 250, 251, 28, 239, 146, 60, 17, 87, 21, 125, 5, 42, 88, 117, 61, 240, 60, 116, 96, 118, 62, 76, 186, 129, 76, 247, 129, 9, 179, 63, 72, 127, 2, 131, 147, 101, 98, 50, 56, 150, 241, 110, 224, 64, 53, 132, 227, 83, 36, 38, 188, 182, 2, 162, 145, 206, 52, 144, 50, 80, 118, 229, 99, 65, 98, 248, 131, 4, 252, 79, 249, 244, 247, 149, 204, 173, 180, 192, 242, 34, 46, 174, 159, 174, 174, 186, 205, 67, 191, 77, 250, 33, 41, 170, 218, 106, 199 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 212, 11, 140, 206, 165, 108, 65, 20, 204, 234, 1, 199, 97, 223, 223, 10, 189, 116, 39, 119, 28, 51, 26, 199, 116, 35, 233, 135, 230, 56, 27, 106, 105, 8, 18, 175, 2, 28, 184, 238, 94, 69, 85, 202, 135, 45, 149, 195, 5, 164, 164, 177, 86, 34, 5, 188, 173, 115, 173, 30, 89, 230, 162, 2 }, new byte[] { 237, 90, 47, 184, 253, 46, 147, 129, 82, 196, 27, 209, 148, 101, 188, 223, 213, 133, 217, 193, 138, 215, 84, 60, 133, 171, 167, 123, 237, 80, 221, 250, 251, 28, 239, 146, 60, 17, 87, 21, 125, 5, 42, 88, 117, 61, 240, 60, 116, 96, 118, 62, 76, 186, 129, 76, 247, 129, 9, 179, 63, 72, 127, 2, 131, 147, 101, 98, 50, 56, 150, 241, 110, 224, 64, 53, 132, 227, 83, 36, 38, 188, 182, 2, 162, 145, 206, 52, 144, 50, 80, 118, 229, 99, 65, 98, 248, 131, 4, 252, 79, 249, 244, 247, 149, 204, 173, 180, 192, 242, 34, 46, 174, 159, 174, 174, 186, 205, 67, 191, 77, 250, 33, 41, 170, 218, 106, 199 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 212, 11, 140, 206, 165, 108, 65, 20, 204, 234, 1, 199, 97, 223, 223, 10, 189, 116, 39, 119, 28, 51, 26, 199, 116, 35, 233, 135, 230, 56, 27, 106, 105, 8, 18, 175, 2, 28, 184, 238, 94, 69, 85, 202, 135, 45, 149, 195, 5, 164, 164, 177, 86, 34, 5, 188, 173, 115, 173, 30, 89, 230, 162, 2 }, new byte[] { 237, 90, 47, 184, 253, 46, 147, 129, 82, 196, 27, 209, 148, 101, 188, 223, 213, 133, 217, 193, 138, 215, 84, 60, 133, 171, 167, 123, 237, 80, 221, 250, 251, 28, 239, 146, 60, 17, 87, 21, 125, 5, 42, 88, 117, 61, 240, 60, 116, 96, 118, 62, 76, 186, 129, 76, 247, 129, 9, 179, 63, 72, 127, 2, 131, 147, 101, 98, 50, 56, 150, 241, 110, 224, 64, 53, 132, 227, 83, 36, 38, 188, 182, 2, 162, 145, 206, 52, 144, 50, 80, 118, 229, 99, 65, 98, 248, 131, 4, 252, 79, 249, 244, 247, 149, 204, 173, 180, 192, 242, 34, 46, 174, 159, 174, 174, 186, 205, 67, 191, 77, 250, 33, 41, 170, 218, 106, 199 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 212, 11, 140, 206, 165, 108, 65, 20, 204, 234, 1, 199, 97, 223, 223, 10, 189, 116, 39, 119, 28, 51, 26, 199, 116, 35, 233, 135, 230, 56, 27, 106, 105, 8, 18, 175, 2, 28, 184, 238, 94, 69, 85, 202, 135, 45, 149, 195, 5, 164, 164, 177, 86, 34, 5, 188, 173, 115, 173, 30, 89, 230, 162, 2 }, new byte[] { 237, 90, 47, 184, 253, 46, 147, 129, 82, 196, 27, 209, 148, 101, 188, 223, 213, 133, 217, 193, 138, 215, 84, 60, 133, 171, 167, 123, 237, 80, 221, 250, 251, 28, 239, 146, 60, 17, 87, 21, 125, 5, 42, 88, 117, 61, 240, 60, 116, 96, 118, 62, 76, 186, 129, 76, 247, 129, 9, 179, 63, 72, 127, 2, 131, 147, 101, 98, 50, 56, 150, 241, 110, 224, 64, 53, 132, 227, 83, 36, 38, 188, 182, 2, 162, 145, 206, 52, 144, 50, 80, 118, 229, 99, 65, 98, 248, 131, 4, 252, 79, 249, 244, 247, 149, 204, 173, 180, 192, 242, 34, 46, 174, 159, 174, 174, 186, 205, 67, 191, 77, 250, 33, 41, 170, 218, 106, 199 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 212, 11, 140, 206, 165, 108, 65, 20, 204, 234, 1, 199, 97, 223, 223, 10, 189, 116, 39, 119, 28, 51, 26, 199, 116, 35, 233, 135, 230, 56, 27, 106, 105, 8, 18, 175, 2, 28, 184, 238, 94, 69, 85, 202, 135, 45, 149, 195, 5, 164, 164, 177, 86, 34, 5, 188, 173, 115, 173, 30, 89, 230, 162, 2 }, new byte[] { 237, 90, 47, 184, 253, 46, 147, 129, 82, 196, 27, 209, 148, 101, 188, 223, 213, 133, 217, 193, 138, 215, 84, 60, 133, 171, 167, 123, 237, 80, 221, 250, 251, 28, 239, 146, 60, 17, 87, 21, 125, 5, 42, 88, 117, 61, 240, 60, 116, 96, 118, 62, 76, 186, 129, 76, 247, 129, 9, 179, 63, 72, 127, 2, 131, 147, 101, 98, 50, 56, 150, 241, 110, 224, 64, 53, 132, 227, 83, 36, 38, 188, 182, 2, 162, 145, 206, 52, 144, 50, 80, 118, 229, 99, 65, 98, 248, 131, 4, 252, 79, 249, 244, 247, 149, 204, 173, 180, 192, 242, 34, 46, 174, 159, 174, 174, 186, 205, 67, 191, 77, 250, 33, 41, 170, 218, 106, 199 } });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "BodyType", "VehicleRegistrationNumber" },
                values: new object[,]
                {
                    { new Guid("25fd0e09-1386-4645-8d37-0a36b1460ccb"), "Truck", "KCZ 595L" },
                    { new Guid("32351ee0-df50-4258-b2ee-6016e94978bc"), "Truck", "KDE 228S" },
                    { new Guid("401602aa-c11d-4a45-8c63-beb2c2f4e40e"), "Truck", "KDB 387Q" },
                    { new Guid("6ebdf843-852c-4500-a5d7-2da30c5c25f3"), "Truck", "KDL 085M" },
                    { new Guid("b5b08316-57e4-410b-a3b4-6014aefffe1d"), "Van", "KAY 215H" },
                    { new Guid("bf0423ca-b501-4b90-8828-9d485be0b51b"), "Truck", "KCY 067A" },
                    { new Guid("d427c237-51a4-48b4-baea-ab96485edeee"), "Van", "KBF 462A" }
                });
        }
    }
}
