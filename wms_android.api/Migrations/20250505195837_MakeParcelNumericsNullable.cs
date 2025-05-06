using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace wms_android.api.Migrations
{
    /// <inheritdoc />
    public partial class MakeParcelNumericsNullable : Migration
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
                    { new Guid("3994ceaa-87ad-421b-b4f9-bd9d69241b12"), "John", "JN", "Njuguna", "DL123456" },
                    { new Guid("5c272677-0ed2-4168-a544-131b88e92f34"), "James", "JG", "Gichohi", "DL123456" },
                    { new Guid("62812584-672c-4b09-9959-edee96d1c247"), "David", "DK", "Kibet", "DL123456" },
                    { new Guid("6a227b9b-7352-4b1c-b690-17e85c4301d9"), "John", "JM", "Mwai", "DL123456" },
                    { new Guid("6d994508-7f1c-46c7-83f2-0e670d977b79"), "Charles", "CM", "Maina", "DL123456" },
                    { new Guid("824eec02-5daf-41b2-a8b9-b8348f83594c"), "David", "DM", "Mwangi", "DL123456" },
                    { new Guid("8bd5d189-b600-46ce-9b2d-20553a3cbdd8"), "Stephen", "SK", "Kimuyu", "DL123456" },
                    { new Guid("ce1feecf-e449-42ec-9684-a0b1256b5a8a"), "Erastus", "EK", "Kagwa", "DL123456" },
                    { new Guid("f35871bd-3dfa-4222-abd3-2539bf547ff3"), "Julius", "JK", "Kamula", "DL123456" },
                    { new Guid("f79d46c6-87bc-46a4-a9ba-1a9ee1cf55b8"), "Robert", "RN", "Njuguna", "DL123456" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 252, 113, 1, 132, 185, 3, 119, 182, 175, 109, 202, 4, 97, 212, 32, 203, 175, 181, 221, 61, 227, 74, 118, 220, 228, 126, 122, 121, 211, 76, 199, 111, 88, 183, 120, 83, 198, 41, 17, 18, 194, 240, 106, 131, 142, 186, 7, 16, 58, 44, 115, 150, 29, 78, 37, 160, 96, 73, 13, 195, 63, 225, 22, 68 }, new byte[] { 29, 252, 222, 133, 47, 55, 184, 94, 207, 100, 80, 105, 73, 41, 128, 38, 28, 67, 99, 142, 92, 193, 104, 99, 72, 218, 102, 184, 19, 230, 144, 172, 11, 232, 30, 165, 125, 11, 57, 99, 212, 139, 221, 28, 59, 247, 253, 80, 46, 154, 152, 129, 148, 121, 62, 123, 199, 56, 120, 92, 122, 83, 168, 24, 180, 236, 7, 172, 163, 22, 211, 143, 13, 14, 146, 215, 22, 157, 225, 204, 133, 236, 49, 134, 180, 99, 23, 33, 170, 11, 103, 234, 110, 154, 148, 14, 19, 75, 17, 183, 120, 16, 172, 106, 174, 232, 1, 136, 11, 20, 111, 177, 136, 252, 56, 173, 192, 127, 17, 134, 31, 130, 55, 184, 44, 97, 144, 26 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 252, 113, 1, 132, 185, 3, 119, 182, 175, 109, 202, 4, 97, 212, 32, 203, 175, 181, 221, 61, 227, 74, 118, 220, 228, 126, 122, 121, 211, 76, 199, 111, 88, 183, 120, 83, 198, 41, 17, 18, 194, 240, 106, 131, 142, 186, 7, 16, 58, 44, 115, 150, 29, 78, 37, 160, 96, 73, 13, 195, 63, 225, 22, 68 }, new byte[] { 29, 252, 222, 133, 47, 55, 184, 94, 207, 100, 80, 105, 73, 41, 128, 38, 28, 67, 99, 142, 92, 193, 104, 99, 72, 218, 102, 184, 19, 230, 144, 172, 11, 232, 30, 165, 125, 11, 57, 99, 212, 139, 221, 28, 59, 247, 253, 80, 46, 154, 152, 129, 148, 121, 62, 123, 199, 56, 120, 92, 122, 83, 168, 24, 180, 236, 7, 172, 163, 22, 211, 143, 13, 14, 146, 215, 22, 157, 225, 204, 133, 236, 49, 134, 180, 99, 23, 33, 170, 11, 103, 234, 110, 154, 148, 14, 19, 75, 17, 183, 120, 16, 172, 106, 174, 232, 1, 136, 11, 20, 111, 177, 136, 252, 56, 173, 192, 127, 17, 134, 31, 130, 55, 184, 44, 97, 144, 26 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 252, 113, 1, 132, 185, 3, 119, 182, 175, 109, 202, 4, 97, 212, 32, 203, 175, 181, 221, 61, 227, 74, 118, 220, 228, 126, 122, 121, 211, 76, 199, 111, 88, 183, 120, 83, 198, 41, 17, 18, 194, 240, 106, 131, 142, 186, 7, 16, 58, 44, 115, 150, 29, 78, 37, 160, 96, 73, 13, 195, 63, 225, 22, 68 }, new byte[] { 29, 252, 222, 133, 47, 55, 184, 94, 207, 100, 80, 105, 73, 41, 128, 38, 28, 67, 99, 142, 92, 193, 104, 99, 72, 218, 102, 184, 19, 230, 144, 172, 11, 232, 30, 165, 125, 11, 57, 99, 212, 139, 221, 28, 59, 247, 253, 80, 46, 154, 152, 129, 148, 121, 62, 123, 199, 56, 120, 92, 122, 83, 168, 24, 180, 236, 7, 172, 163, 22, 211, 143, 13, 14, 146, 215, 22, 157, 225, 204, 133, 236, 49, 134, 180, 99, 23, 33, 170, 11, 103, 234, 110, 154, 148, 14, 19, 75, 17, 183, 120, 16, 172, 106, 174, 232, 1, 136, 11, 20, 111, 177, 136, 252, 56, 173, 192, 127, 17, 134, 31, 130, 55, 184, 44, 97, 144, 26 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 252, 113, 1, 132, 185, 3, 119, 182, 175, 109, 202, 4, 97, 212, 32, 203, 175, 181, 221, 61, 227, 74, 118, 220, 228, 126, 122, 121, 211, 76, 199, 111, 88, 183, 120, 83, 198, 41, 17, 18, 194, 240, 106, 131, 142, 186, 7, 16, 58, 44, 115, 150, 29, 78, 37, 160, 96, 73, 13, 195, 63, 225, 22, 68 }, new byte[] { 29, 252, 222, 133, 47, 55, 184, 94, 207, 100, 80, 105, 73, 41, 128, 38, 28, 67, 99, 142, 92, 193, 104, 99, 72, 218, 102, 184, 19, 230, 144, 172, 11, 232, 30, 165, 125, 11, 57, 99, 212, 139, 221, 28, 59, 247, 253, 80, 46, 154, 152, 129, 148, 121, 62, 123, 199, 56, 120, 92, 122, 83, 168, 24, 180, 236, 7, 172, 163, 22, 211, 143, 13, 14, 146, 215, 22, 157, 225, 204, 133, 236, 49, 134, 180, 99, 23, 33, 170, 11, 103, 234, 110, 154, 148, 14, 19, 75, 17, 183, 120, 16, 172, 106, 174, 232, 1, 136, 11, 20, 111, 177, 136, 252, 56, 173, 192, 127, 17, 134, 31, 130, 55, 184, 44, 97, 144, 26 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 252, 113, 1, 132, 185, 3, 119, 182, 175, 109, 202, 4, 97, 212, 32, 203, 175, 181, 221, 61, 227, 74, 118, 220, 228, 126, 122, 121, 211, 76, 199, 111, 88, 183, 120, 83, 198, 41, 17, 18, 194, 240, 106, 131, 142, 186, 7, 16, 58, 44, 115, 150, 29, 78, 37, 160, 96, 73, 13, 195, 63, 225, 22, 68 }, new byte[] { 29, 252, 222, 133, 47, 55, 184, 94, 207, 100, 80, 105, 73, 41, 128, 38, 28, 67, 99, 142, 92, 193, 104, 99, 72, 218, 102, 184, 19, 230, 144, 172, 11, 232, 30, 165, 125, 11, 57, 99, 212, 139, 221, 28, 59, 247, 253, 80, 46, 154, 152, 129, 148, 121, 62, 123, 199, 56, 120, 92, 122, 83, 168, 24, 180, 236, 7, 172, 163, 22, 211, 143, 13, 14, 146, 215, 22, 157, 225, 204, 133, 236, 49, 134, 180, 99, 23, 33, 170, 11, 103, 234, 110, 154, 148, 14, 19, 75, 17, 183, 120, 16, 172, 106, 174, 232, 1, 136, 11, 20, 111, 177, 136, 252, 56, 173, 192, 127, 17, 134, 31, 130, 55, 184, 44, 97, 144, 26 } });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "BodyType", "VehicleRegistrationNumber" },
                values: new object[,]
                {
                    { new Guid("11e1070b-ec60-4675-a735-a932a4396a79"), "Truck", "KCY 067A" },
                    { new Guid("1d0f546a-db9f-4032-9d63-22d3d42d6262"), "Van", "KBF 462A" },
                    { new Guid("244ef9b4-dcef-4802-8c75-a372100fbdaf"), "Truck", "KDL 085M" },
                    { new Guid("38898710-26c3-4e60-8bd6-fff8eb4ca802"), "Truck", "KCZ 595L" },
                    { new Guid("3b51703b-521e-473d-ace4-de0edfe5f93c"), "Van", "KAY 215H" },
                    { new Guid("915a6eb0-a971-4f9c-ade2-d74916fd7b73"), "Truck", "KDB 387Q" },
                    { new Guid("a5ef5b60-7572-46ac-9c6b-2ca8cce220aa"), "Truck", "KDE 228S" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("3994ceaa-87ad-421b-b4f9-bd9d69241b12"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("5c272677-0ed2-4168-a544-131b88e92f34"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("62812584-672c-4b09-9959-edee96d1c247"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("6a227b9b-7352-4b1c-b690-17e85c4301d9"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("6d994508-7f1c-46c7-83f2-0e670d977b79"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("824eec02-5daf-41b2-a8b9-b8348f83594c"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("8bd5d189-b600-46ce-9b2d-20553a3cbdd8"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("ce1feecf-e449-42ec-9684-a0b1256b5a8a"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("f35871bd-3dfa-4222-abd3-2539bf547ff3"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("f79d46c6-87bc-46a4-a9ba-1a9ee1cf55b8"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("11e1070b-ec60-4675-a735-a932a4396a79"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("1d0f546a-db9f-4032-9d63-22d3d42d6262"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("244ef9b4-dcef-4802-8c75-a372100fbdaf"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("38898710-26c3-4e60-8bd6-fff8eb4ca802"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("3b51703b-521e-473d-ace4-de0edfe5f93c"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("915a6eb0-a971-4f9c-ade2-d74916fd7b73"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("a5ef5b60-7572-46ac-9c6b-2ca8cce220aa"));

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
