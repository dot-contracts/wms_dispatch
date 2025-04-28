using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace wms_android.api.Migrations
{
    /// <inheritdoc />
    public partial class ConsolidateToSharedDbContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("3681fac5-feae-4288-b106-17d4b88ed48e"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("463ab1c6-0e0f-43ee-9ab5-7e2d232c868f"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("591b9024-b83f-4304-870f-b6e40a3ba818"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("a6cfc2c8-8a04-43e4-9a39-2c22c329ed5e"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("a79edbac-b264-4eb3-baf1-b5ab8cc80c1a"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("b7d298c9-6af7-45d1-9555-704abd25279b"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("bf0df757-905d-431d-a145-531182e963a6"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("bfe0eb56-f4f6-4451-8490-1aca0d0a3eea"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("e1a154d3-e0c2-4094-b8e8-e3d5ce519f97"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("f6947c7f-b5ed-4a32-ab66-9e7fe34f9514"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("23b0d6eb-150a-42c4-9f38-b47e4ce04282"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("4a6de2d8-7a9c-4385-a0c7-4ca35704abf0"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("59c5589b-2cc6-4741-ad21-78cc6a0f7592"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("5f95bcf7-dbab-4b35-ba61-c6bceaef9ded"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("9db37f6b-98eb-42e1-b0ef-462c6f700b4b"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("b7e4fe3d-261c-4a6d-a13a-42c8024d4ffa"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("c6e7633f-18aa-4345-9805-8aefeb51d898"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "FirstName", "Initials", "LastName", "LicenseNumber" },
                values: new object[,]
                {
                    { new Guid("3681fac5-feae-4288-b106-17d4b88ed48e"), "Julius", "JK", "Kamula", "DL123456" },
                    { new Guid("463ab1c6-0e0f-43ee-9ab5-7e2d232c868f"), "James", "JG", "Gichohi", "DL123456" },
                    { new Guid("591b9024-b83f-4304-870f-b6e40a3ba818"), "Charles", "CM", "Maina", "DL123456" },
                    { new Guid("a6cfc2c8-8a04-43e4-9a39-2c22c329ed5e"), "David", "DK", "Kibet", "DL123456" },
                    { new Guid("a79edbac-b264-4eb3-baf1-b5ab8cc80c1a"), "John", "JM", "Mwai", "DL123456" },
                    { new Guid("b7d298c9-6af7-45d1-9555-704abd25279b"), "Erastus", "EK", "Kagwa", "DL123456" },
                    { new Guid("bf0df757-905d-431d-a145-531182e963a6"), "John", "JN", "Njuguna", "DL123456" },
                    { new Guid("bfe0eb56-f4f6-4451-8490-1aca0d0a3eea"), "Stephen", "SK", "Kimuyu", "DL123456" },
                    { new Guid("e1a154d3-e0c2-4094-b8e8-e3d5ce519f97"), "David", "DM", "Mwangi", "DL123456" },
                    { new Guid("f6947c7f-b5ed-4a32-ab66-9e7fe34f9514"), "Robert", "RN", "Njuguna", "DL123456" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 221, 120, 35, 203, 52, 162, 84, 230, 67, 39, 69, 70, 4, 14, 89, 121, 61, 51, 133, 107, 155, 122, 81, 61, 64, 105, 0, 119, 29, 119, 5, 58, 107, 130, 207, 198, 224, 178, 17, 190, 217, 72, 92, 43, 241, 41, 238, 200, 210, 69, 238, 177, 48, 189, 167, 181, 253, 2, 248, 171, 4, 142, 84, 116 }, new byte[] { 175, 238, 174, 14, 106, 68, 78, 71, 237, 54, 30, 173, 153, 236, 254, 48, 225, 34, 24, 86, 107, 3, 175, 18, 105, 38, 84, 208, 94, 122, 176, 160, 41, 155, 150, 120, 82, 233, 223, 79, 144, 222, 232, 112, 39, 44, 98, 16, 178, 223, 53, 238, 120, 95, 209, 70, 50, 198, 10, 249, 34, 74, 141, 179, 132, 56, 105, 125, 106, 243, 151, 39, 225, 242, 142, 225, 47, 147, 35, 146, 150, 132, 186, 134, 117, 189, 50, 142, 146, 228, 79, 123, 152, 46, 99, 123, 75, 23, 155, 140, 189, 241, 8, 196, 96, 55, 47, 214, 110, 67, 184, 14, 124, 115, 213, 190, 169, 116, 171, 177, 231, 234, 188, 241, 10, 79, 54, 226 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 221, 120, 35, 203, 52, 162, 84, 230, 67, 39, 69, 70, 4, 14, 89, 121, 61, 51, 133, 107, 155, 122, 81, 61, 64, 105, 0, 119, 29, 119, 5, 58, 107, 130, 207, 198, 224, 178, 17, 190, 217, 72, 92, 43, 241, 41, 238, 200, 210, 69, 238, 177, 48, 189, 167, 181, 253, 2, 248, 171, 4, 142, 84, 116 }, new byte[] { 175, 238, 174, 14, 106, 68, 78, 71, 237, 54, 30, 173, 153, 236, 254, 48, 225, 34, 24, 86, 107, 3, 175, 18, 105, 38, 84, 208, 94, 122, 176, 160, 41, 155, 150, 120, 82, 233, 223, 79, 144, 222, 232, 112, 39, 44, 98, 16, 178, 223, 53, 238, 120, 95, 209, 70, 50, 198, 10, 249, 34, 74, 141, 179, 132, 56, 105, 125, 106, 243, 151, 39, 225, 242, 142, 225, 47, 147, 35, 146, 150, 132, 186, 134, 117, 189, 50, 142, 146, 228, 79, 123, 152, 46, 99, 123, 75, 23, 155, 140, 189, 241, 8, 196, 96, 55, 47, 214, 110, 67, 184, 14, 124, 115, 213, 190, 169, 116, 171, 177, 231, 234, 188, 241, 10, 79, 54, 226 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 221, 120, 35, 203, 52, 162, 84, 230, 67, 39, 69, 70, 4, 14, 89, 121, 61, 51, 133, 107, 155, 122, 81, 61, 64, 105, 0, 119, 29, 119, 5, 58, 107, 130, 207, 198, 224, 178, 17, 190, 217, 72, 92, 43, 241, 41, 238, 200, 210, 69, 238, 177, 48, 189, 167, 181, 253, 2, 248, 171, 4, 142, 84, 116 }, new byte[] { 175, 238, 174, 14, 106, 68, 78, 71, 237, 54, 30, 173, 153, 236, 254, 48, 225, 34, 24, 86, 107, 3, 175, 18, 105, 38, 84, 208, 94, 122, 176, 160, 41, 155, 150, 120, 82, 233, 223, 79, 144, 222, 232, 112, 39, 44, 98, 16, 178, 223, 53, 238, 120, 95, 209, 70, 50, 198, 10, 249, 34, 74, 141, 179, 132, 56, 105, 125, 106, 243, 151, 39, 225, 242, 142, 225, 47, 147, 35, 146, 150, 132, 186, 134, 117, 189, 50, 142, 146, 228, 79, 123, 152, 46, 99, 123, 75, 23, 155, 140, 189, 241, 8, 196, 96, 55, 47, 214, 110, 67, 184, 14, 124, 115, 213, 190, 169, 116, 171, 177, 231, 234, 188, 241, 10, 79, 54, 226 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 221, 120, 35, 203, 52, 162, 84, 230, 67, 39, 69, 70, 4, 14, 89, 121, 61, 51, 133, 107, 155, 122, 81, 61, 64, 105, 0, 119, 29, 119, 5, 58, 107, 130, 207, 198, 224, 178, 17, 190, 217, 72, 92, 43, 241, 41, 238, 200, 210, 69, 238, 177, 48, 189, 167, 181, 253, 2, 248, 171, 4, 142, 84, 116 }, new byte[] { 175, 238, 174, 14, 106, 68, 78, 71, 237, 54, 30, 173, 153, 236, 254, 48, 225, 34, 24, 86, 107, 3, 175, 18, 105, 38, 84, 208, 94, 122, 176, 160, 41, 155, 150, 120, 82, 233, 223, 79, 144, 222, 232, 112, 39, 44, 98, 16, 178, 223, 53, 238, 120, 95, 209, 70, 50, 198, 10, 249, 34, 74, 141, 179, 132, 56, 105, 125, 106, 243, 151, 39, 225, 242, 142, 225, 47, 147, 35, 146, 150, 132, 186, 134, 117, 189, 50, 142, 146, 228, 79, 123, 152, 46, 99, 123, 75, 23, 155, 140, 189, 241, 8, 196, 96, 55, 47, 214, 110, 67, 184, 14, 124, 115, 213, 190, 169, 116, 171, 177, 231, 234, 188, 241, 10, 79, 54, 226 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 221, 120, 35, 203, 52, 162, 84, 230, 67, 39, 69, 70, 4, 14, 89, 121, 61, 51, 133, 107, 155, 122, 81, 61, 64, 105, 0, 119, 29, 119, 5, 58, 107, 130, 207, 198, 224, 178, 17, 190, 217, 72, 92, 43, 241, 41, 238, 200, 210, 69, 238, 177, 48, 189, 167, 181, 253, 2, 248, 171, 4, 142, 84, 116 }, new byte[] { 175, 238, 174, 14, 106, 68, 78, 71, 237, 54, 30, 173, 153, 236, 254, 48, 225, 34, 24, 86, 107, 3, 175, 18, 105, 38, 84, 208, 94, 122, 176, 160, 41, 155, 150, 120, 82, 233, 223, 79, 144, 222, 232, 112, 39, 44, 98, 16, 178, 223, 53, 238, 120, 95, 209, 70, 50, 198, 10, 249, 34, 74, 141, 179, 132, 56, 105, 125, 106, 243, 151, 39, 225, 242, 142, 225, 47, 147, 35, 146, 150, 132, 186, 134, 117, 189, 50, 142, 146, 228, 79, 123, 152, 46, 99, 123, 75, 23, 155, 140, 189, 241, 8, 196, 96, 55, 47, 214, 110, 67, 184, 14, 124, 115, 213, 190, 169, 116, 171, 177, 231, 234, 188, 241, 10, 79, 54, 226 } });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "BodyType", "VehicleRegistrationNumber" },
                values: new object[,]
                {
                    { new Guid("23b0d6eb-150a-42c4-9f38-b47e4ce04282"), "Truck", "KDL 085M" },
                    { new Guid("4a6de2d8-7a9c-4385-a0c7-4ca35704abf0"), "Truck", "KCY 067A" },
                    { new Guid("59c5589b-2cc6-4741-ad21-78cc6a0f7592"), "Van", "KAY 215H" },
                    { new Guid("5f95bcf7-dbab-4b35-ba61-c6bceaef9ded"), "Truck", "KDE 228S" },
                    { new Guid("9db37f6b-98eb-42e1-b0ef-462c6f700b4b"), "Van", "KBF 462A" },
                    { new Guid("b7e4fe3d-261c-4a6d-a13a-42c8024d4ffa"), "Truck", "KCZ 595L" },
                    { new Guid("c6e7633f-18aa-4345-9805-8aefeb51d898"), "Truck", "KDB 387Q" }
                });
        }
    }
}
