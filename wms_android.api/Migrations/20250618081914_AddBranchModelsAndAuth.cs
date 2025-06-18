using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace wms_android.api.Migrations
{
    /// <inheritdoc />
    public partial class AddBranchModelsAndAuth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("30d51f0f-54de-4454-8c3c-dbc99806fab6"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("44bf5f67-3f52-4dae-8654-0c709fce02c0"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("560208a4-dd4f-466e-882b-de9baed6da97"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("5a4d2134-4a43-45c7-8bd3-a3a1950142cf"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("5ee43824-0baf-476a-aa4c-1da4809a6445"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("85745d39-c20e-409b-8a8e-16ab7e28de79"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("868e7357-716e-4fbb-a3b2-804648b0b8d9"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("8db9bab8-c49d-403e-8205-ed9d392e0e88"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("b326712b-3441-471f-a543-277f33e86178"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("e3e8e9d9-2b67-4666-92a8-632fcddfb158"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("329631bc-2d5e-47f6-a28e-f6a047408df8"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("4a5739a9-bf13-4dea-be4c-a6324220d180"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("9d826d6d-e932-4d96-b5a2-c9815805968a"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("b25db492-d121-41a5-8983-eaec1aa4a426"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("b7e533da-e584-4984-8339-6691aae4279a"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("b8f9520b-47c2-4dff-88df-50ab68feae63"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("bc36f9c1-0005-4bb0-a790-a340f96ab8b0"));

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "FirstName", "Initials", "LastName", "LicenseNumber" },
                values: new object[,]
                {
                    { new Guid("1e1e22f0-c6a6-4e56-8245-e79674b7f56f"), "John", "JN", "Njuguna", "DL123456" },
                    { new Guid("66bb18ba-245c-449b-950b-159c7563003e"), "David", "DM", "Mwangi", "DL123456" },
                    { new Guid("785f04a9-23f1-4320-9589-40a3a2f284ad"), "Erastus", "EK", "Kagwa", "DL123456" },
                    { new Guid("86b89e7a-2598-450e-8f16-7137402f676e"), "Julius", "JK", "Kamula", "DL123456" },
                    { new Guid("a31fde51-28e1-44f7-918a-8850a3a3f8c4"), "Robert", "RN", "Njuguna", "DL123456" },
                    { new Guid("a455b44e-1b06-4b3a-abe7-36969cfedd84"), "Charles", "CM", "Maina", "DL123456" },
                    { new Guid("b485e2ce-4475-4232-9ff8-feba450c2dbf"), "James", "JG", "Gichohi", "DL123456" },
                    { new Guid("cfbc5460-bb79-4ced-a1bd-8d92e54215a0"), "Stephen", "SK", "Kimuyu", "DL123456" },
                    { new Guid("d43a1b47-8390-40c6-b85c-f020f1581a83"), "David", "DK", "Kibet", "DL123456" },
                    { new Guid("df60f1ca-8ec9-4135-ba7b-417d5405e143"), "John", "JM", "Mwai", "DL123456" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 204, 184, 167, 112, 26, 169, 162, 245, 0, 179, 14, 107, 251, 42, 112, 189, 13, 198, 152, 53, 1, 255, 5, 53, 151, 76, 119, 141, 69, 45, 112, 59, 246, 77, 104, 48, 133, 155, 155, 11, 139, 178, 233, 187, 176, 119, 95, 82, 86, 153, 208, 1, 170, 153, 1, 239, 80, 3, 68, 146, 234, 121, 72, 230 }, new byte[] { 158, 132, 159, 95, 154, 88, 234, 251, 11, 79, 80, 119, 191, 187, 38, 195, 83, 129, 199, 46, 59, 51, 224, 17, 137, 51, 94, 236, 66, 129, 66, 132, 232, 142, 247, 10, 108, 242, 210, 35, 224, 154, 154, 86, 44, 119, 228, 70, 125, 23, 118, 199, 88, 131, 37, 76, 97, 185, 107, 162, 195, 30, 105, 187, 202, 217, 30, 200, 150, 221, 101, 184, 213, 75, 115, 43, 62, 100, 187, 184, 84, 159, 132, 16, 239, 14, 44, 56, 221, 199, 45, 113, 243, 181, 184, 110, 103, 98, 80, 54, 137, 109, 249, 74, 43, 139, 98, 202, 57, 130, 135, 115, 96, 184, 205, 25, 57, 46, 215, 192, 203, 245, 152, 51, 246, 17, 74, 73 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 204, 184, 167, 112, 26, 169, 162, 245, 0, 179, 14, 107, 251, 42, 112, 189, 13, 198, 152, 53, 1, 255, 5, 53, 151, 76, 119, 141, 69, 45, 112, 59, 246, 77, 104, 48, 133, 155, 155, 11, 139, 178, 233, 187, 176, 119, 95, 82, 86, 153, 208, 1, 170, 153, 1, 239, 80, 3, 68, 146, 234, 121, 72, 230 }, new byte[] { 158, 132, 159, 95, 154, 88, 234, 251, 11, 79, 80, 119, 191, 187, 38, 195, 83, 129, 199, 46, 59, 51, 224, 17, 137, 51, 94, 236, 66, 129, 66, 132, 232, 142, 247, 10, 108, 242, 210, 35, 224, 154, 154, 86, 44, 119, 228, 70, 125, 23, 118, 199, 88, 131, 37, 76, 97, 185, 107, 162, 195, 30, 105, 187, 202, 217, 30, 200, 150, 221, 101, 184, 213, 75, 115, 43, 62, 100, 187, 184, 84, 159, 132, 16, 239, 14, 44, 56, 221, 199, 45, 113, 243, 181, 184, 110, 103, 98, 80, 54, 137, 109, 249, 74, 43, 139, 98, 202, 57, 130, 135, 115, 96, 184, 205, 25, 57, 46, 215, 192, 203, 245, 152, 51, 246, 17, 74, 73 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 204, 184, 167, 112, 26, 169, 162, 245, 0, 179, 14, 107, 251, 42, 112, 189, 13, 198, 152, 53, 1, 255, 5, 53, 151, 76, 119, 141, 69, 45, 112, 59, 246, 77, 104, 48, 133, 155, 155, 11, 139, 178, 233, 187, 176, 119, 95, 82, 86, 153, 208, 1, 170, 153, 1, 239, 80, 3, 68, 146, 234, 121, 72, 230 }, new byte[] { 158, 132, 159, 95, 154, 88, 234, 251, 11, 79, 80, 119, 191, 187, 38, 195, 83, 129, 199, 46, 59, 51, 224, 17, 137, 51, 94, 236, 66, 129, 66, 132, 232, 142, 247, 10, 108, 242, 210, 35, 224, 154, 154, 86, 44, 119, 228, 70, 125, 23, 118, 199, 88, 131, 37, 76, 97, 185, 107, 162, 195, 30, 105, 187, 202, 217, 30, 200, 150, 221, 101, 184, 213, 75, 115, 43, 62, 100, 187, 184, 84, 159, 132, 16, 239, 14, 44, 56, 221, 199, 45, 113, 243, 181, 184, 110, 103, 98, 80, 54, 137, 109, 249, 74, 43, 139, 98, 202, 57, 130, 135, 115, 96, 184, 205, 25, 57, 46, 215, 192, 203, 245, 152, 51, 246, 17, 74, 73 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 204, 184, 167, 112, 26, 169, 162, 245, 0, 179, 14, 107, 251, 42, 112, 189, 13, 198, 152, 53, 1, 255, 5, 53, 151, 76, 119, 141, 69, 45, 112, 59, 246, 77, 104, 48, 133, 155, 155, 11, 139, 178, 233, 187, 176, 119, 95, 82, 86, 153, 208, 1, 170, 153, 1, 239, 80, 3, 68, 146, 234, 121, 72, 230 }, new byte[] { 158, 132, 159, 95, 154, 88, 234, 251, 11, 79, 80, 119, 191, 187, 38, 195, 83, 129, 199, 46, 59, 51, 224, 17, 137, 51, 94, 236, 66, 129, 66, 132, 232, 142, 247, 10, 108, 242, 210, 35, 224, 154, 154, 86, 44, 119, 228, 70, 125, 23, 118, 199, 88, 131, 37, 76, 97, 185, 107, 162, 195, 30, 105, 187, 202, 217, 30, 200, 150, 221, 101, 184, 213, 75, 115, 43, 62, 100, 187, 184, 84, 159, 132, 16, 239, 14, 44, 56, 221, 199, 45, 113, 243, 181, 184, 110, 103, 98, 80, 54, 137, 109, 249, 74, 43, 139, 98, 202, 57, 130, 135, 115, 96, 184, 205, 25, 57, 46, 215, 192, 203, 245, 152, 51, 246, 17, 74, 73 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 204, 184, 167, 112, 26, 169, 162, 245, 0, 179, 14, 107, 251, 42, 112, 189, 13, 198, 152, 53, 1, 255, 5, 53, 151, 76, 119, 141, 69, 45, 112, 59, 246, 77, 104, 48, 133, 155, 155, 11, 139, 178, 233, 187, 176, 119, 95, 82, 86, 153, 208, 1, 170, 153, 1, 239, 80, 3, 68, 146, 234, 121, 72, 230 }, new byte[] { 158, 132, 159, 95, 154, 88, 234, 251, 11, 79, 80, 119, 191, 187, 38, 195, 83, 129, 199, 46, 59, 51, 224, 17, 137, 51, 94, 236, 66, 129, 66, 132, 232, 142, 247, 10, 108, 242, 210, 35, 224, 154, 154, 86, 44, 119, 228, 70, 125, 23, 118, 199, 88, 131, 37, 76, 97, 185, 107, 162, 195, 30, 105, 187, 202, 217, 30, 200, 150, 221, 101, 184, 213, 75, 115, 43, 62, 100, 187, 184, 84, 159, 132, 16, 239, 14, 44, 56, 221, 199, 45, 113, 243, 181, 184, 110, 103, 98, 80, 54, 137, 109, 249, 74, 43, 139, 98, 202, 57, 130, 135, 115, 96, 184, 205, 25, 57, 46, 215, 192, 203, 245, 152, 51, 246, 17, 74, 73 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 204, 184, 167, 112, 26, 169, 162, 245, 0, 179, 14, 107, 251, 42, 112, 189, 13, 198, 152, 53, 1, 255, 5, 53, 151, 76, 119, 141, 69, 45, 112, 59, 246, 77, 104, 48, 133, 155, 155, 11, 139, 178, 233, 187, 176, 119, 95, 82, 86, 153, 208, 1, 170, 153, 1, 239, 80, 3, 68, 146, 234, 121, 72, 230 }, new byte[] { 158, 132, 159, 95, 154, 88, 234, 251, 11, 79, 80, 119, 191, 187, 38, 195, 83, 129, 199, 46, 59, 51, 224, 17, 137, 51, 94, 236, 66, 129, 66, 132, 232, 142, 247, 10, 108, 242, 210, 35, 224, 154, 154, 86, 44, 119, 228, 70, 125, 23, 118, 199, 88, 131, 37, 76, 97, 185, 107, 162, 195, 30, 105, 187, 202, 217, 30, 200, 150, 221, 101, 184, 213, 75, 115, 43, 62, 100, 187, 184, 84, 159, 132, 16, 239, 14, 44, 56, 221, 199, 45, 113, 243, 181, 184, 110, 103, 98, 80, 54, 137, 109, 249, 74, 43, 139, 98, 202, 57, 130, 135, 115, 96, 184, 205, 25, 57, 46, 215, 192, 203, 245, 152, 51, 246, 17, 74, 73 } });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "BodyType", "VehicleRegistrationNumber" },
                values: new object[,]
                {
                    { new Guid("3308121f-385f-4417-9fde-de18627fea29"), "Van", "KAY 215H" },
                    { new Guid("43ea91e8-93cd-44e9-b102-571a02ebf2a7"), "Truck", "KDB 387Q" },
                    { new Guid("96ad9256-0722-4a47-be50-e864f178be16"), "Truck", "KCZ 595L" },
                    { new Guid("9ced0e48-f867-4dd1-8ad9-19830e71318f"), "Truck", "KDL 085M" },
                    { new Guid("a8e056bc-c492-4c56-8c0f-235ce2a29706"), "Truck", "KDE 228S" },
                    { new Guid("b708e180-1273-4964-896f-228655c78d24"), "Van", "KBF 462A" },
                    { new Guid("e8e7f6c5-2940-4afd-8723-fad13de282b9"), "Truck", "KCY 067A" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("1e1e22f0-c6a6-4e56-8245-e79674b7f56f"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("66bb18ba-245c-449b-950b-159c7563003e"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("785f04a9-23f1-4320-9589-40a3a2f284ad"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("86b89e7a-2598-450e-8f16-7137402f676e"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("a31fde51-28e1-44f7-918a-8850a3a3f8c4"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("a455b44e-1b06-4b3a-abe7-36969cfedd84"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("b485e2ce-4475-4232-9ff8-feba450c2dbf"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("cfbc5460-bb79-4ced-a1bd-8d92e54215a0"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("d43a1b47-8390-40c6-b85c-f020f1581a83"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("df60f1ca-8ec9-4135-ba7b-417d5405e143"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("3308121f-385f-4417-9fde-de18627fea29"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("43ea91e8-93cd-44e9-b102-571a02ebf2a7"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("96ad9256-0722-4a47-be50-e864f178be16"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("9ced0e48-f867-4dd1-8ad9-19830e71318f"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("a8e056bc-c492-4c56-8c0f-235ce2a29706"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("b708e180-1273-4964-896f-228655c78d24"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("e8e7f6c5-2940-4afd-8723-fad13de282b9"));

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "FirstName", "Initials", "LastName", "LicenseNumber" },
                values: new object[,]
                {
                    { new Guid("30d51f0f-54de-4454-8c3c-dbc99806fab6"), "Robert", "RN", "Njuguna", "DL123456" },
                    { new Guid("44bf5f67-3f52-4dae-8654-0c709fce02c0"), "Stephen", "SK", "Kimuyu", "DL123456" },
                    { new Guid("560208a4-dd4f-466e-882b-de9baed6da97"), "James", "JG", "Gichohi", "DL123456" },
                    { new Guid("5a4d2134-4a43-45c7-8bd3-a3a1950142cf"), "David", "DK", "Kibet", "DL123456" },
                    { new Guid("5ee43824-0baf-476a-aa4c-1da4809a6445"), "John", "JM", "Mwai", "DL123456" },
                    { new Guid("85745d39-c20e-409b-8a8e-16ab7e28de79"), "Charles", "CM", "Maina", "DL123456" },
                    { new Guid("868e7357-716e-4fbb-a3b2-804648b0b8d9"), "Julius", "JK", "Kamula", "DL123456" },
                    { new Guid("8db9bab8-c49d-403e-8205-ed9d392e0e88"), "Erastus", "EK", "Kagwa", "DL123456" },
                    { new Guid("b326712b-3441-471f-a543-277f33e86178"), "John", "JN", "Njuguna", "DL123456" },
                    { new Guid("e3e8e9d9-2b67-4666-92a8-632fcddfb158"), "David", "DM", "Mwangi", "DL123456" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 152, 188, 5, 135, 85, 137, 91, 2, 182, 239, 133, 18, 174, 200, 95, 163, 10, 22, 99, 65, 140, 254, 218, 160, 49, 196, 67, 235, 129, 16, 179, 191, 154, 188, 75, 100, 251, 222, 189, 40, 146, 244, 85, 61, 171, 110, 60, 251, 68, 111, 163, 98, 17, 3, 84, 99, 187, 222, 79, 209, 104, 97, 32, 129 }, new byte[] { 209, 152, 30, 185, 239, 33, 78, 228, 44, 89, 57, 13, 8, 54, 75, 120, 235, 236, 214, 219, 221, 40, 226, 143, 97, 194, 37, 90, 204, 63, 45, 43, 238, 93, 163, 81, 250, 134, 37, 97, 156, 69, 40, 7, 173, 253, 241, 196, 205, 64, 100, 245, 220, 152, 38, 220, 114, 144, 169, 194, 105, 246, 211, 14, 199, 65, 9, 206, 177, 125, 218, 30, 30, 42, 172, 62, 93, 170, 82, 125, 229, 95, 45, 126, 229, 239, 150, 253, 126, 87, 64, 51, 42, 63, 38, 143, 117, 137, 77, 128, 214, 203, 202, 149, 30, 70, 243, 66, 252, 77, 132, 29, 143, 137, 67, 0, 148, 147, 248, 37, 64, 149, 231, 135, 254, 181, 182, 180 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 152, 188, 5, 135, 85, 137, 91, 2, 182, 239, 133, 18, 174, 200, 95, 163, 10, 22, 99, 65, 140, 254, 218, 160, 49, 196, 67, 235, 129, 16, 179, 191, 154, 188, 75, 100, 251, 222, 189, 40, 146, 244, 85, 61, 171, 110, 60, 251, 68, 111, 163, 98, 17, 3, 84, 99, 187, 222, 79, 209, 104, 97, 32, 129 }, new byte[] { 209, 152, 30, 185, 239, 33, 78, 228, 44, 89, 57, 13, 8, 54, 75, 120, 235, 236, 214, 219, 221, 40, 226, 143, 97, 194, 37, 90, 204, 63, 45, 43, 238, 93, 163, 81, 250, 134, 37, 97, 156, 69, 40, 7, 173, 253, 241, 196, 205, 64, 100, 245, 220, 152, 38, 220, 114, 144, 169, 194, 105, 246, 211, 14, 199, 65, 9, 206, 177, 125, 218, 30, 30, 42, 172, 62, 93, 170, 82, 125, 229, 95, 45, 126, 229, 239, 150, 253, 126, 87, 64, 51, 42, 63, 38, 143, 117, 137, 77, 128, 214, 203, 202, 149, 30, 70, 243, 66, 252, 77, 132, 29, 143, 137, 67, 0, 148, 147, 248, 37, 64, 149, 231, 135, 254, 181, 182, 180 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 152, 188, 5, 135, 85, 137, 91, 2, 182, 239, 133, 18, 174, 200, 95, 163, 10, 22, 99, 65, 140, 254, 218, 160, 49, 196, 67, 235, 129, 16, 179, 191, 154, 188, 75, 100, 251, 222, 189, 40, 146, 244, 85, 61, 171, 110, 60, 251, 68, 111, 163, 98, 17, 3, 84, 99, 187, 222, 79, 209, 104, 97, 32, 129 }, new byte[] { 209, 152, 30, 185, 239, 33, 78, 228, 44, 89, 57, 13, 8, 54, 75, 120, 235, 236, 214, 219, 221, 40, 226, 143, 97, 194, 37, 90, 204, 63, 45, 43, 238, 93, 163, 81, 250, 134, 37, 97, 156, 69, 40, 7, 173, 253, 241, 196, 205, 64, 100, 245, 220, 152, 38, 220, 114, 144, 169, 194, 105, 246, 211, 14, 199, 65, 9, 206, 177, 125, 218, 30, 30, 42, 172, 62, 93, 170, 82, 125, 229, 95, 45, 126, 229, 239, 150, 253, 126, 87, 64, 51, 42, 63, 38, 143, 117, 137, 77, 128, 214, 203, 202, 149, 30, 70, 243, 66, 252, 77, 132, 29, 143, 137, 67, 0, 148, 147, 248, 37, 64, 149, 231, 135, 254, 181, 182, 180 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 152, 188, 5, 135, 85, 137, 91, 2, 182, 239, 133, 18, 174, 200, 95, 163, 10, 22, 99, 65, 140, 254, 218, 160, 49, 196, 67, 235, 129, 16, 179, 191, 154, 188, 75, 100, 251, 222, 189, 40, 146, 244, 85, 61, 171, 110, 60, 251, 68, 111, 163, 98, 17, 3, 84, 99, 187, 222, 79, 209, 104, 97, 32, 129 }, new byte[] { 209, 152, 30, 185, 239, 33, 78, 228, 44, 89, 57, 13, 8, 54, 75, 120, 235, 236, 214, 219, 221, 40, 226, 143, 97, 194, 37, 90, 204, 63, 45, 43, 238, 93, 163, 81, 250, 134, 37, 97, 156, 69, 40, 7, 173, 253, 241, 196, 205, 64, 100, 245, 220, 152, 38, 220, 114, 144, 169, 194, 105, 246, 211, 14, 199, 65, 9, 206, 177, 125, 218, 30, 30, 42, 172, 62, 93, 170, 82, 125, 229, 95, 45, 126, 229, 239, 150, 253, 126, 87, 64, 51, 42, 63, 38, 143, 117, 137, 77, 128, 214, 203, 202, 149, 30, 70, 243, 66, 252, 77, 132, 29, 143, 137, 67, 0, 148, 147, 248, 37, 64, 149, 231, 135, 254, 181, 182, 180 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 152, 188, 5, 135, 85, 137, 91, 2, 182, 239, 133, 18, 174, 200, 95, 163, 10, 22, 99, 65, 140, 254, 218, 160, 49, 196, 67, 235, 129, 16, 179, 191, 154, 188, 75, 100, 251, 222, 189, 40, 146, 244, 85, 61, 171, 110, 60, 251, 68, 111, 163, 98, 17, 3, 84, 99, 187, 222, 79, 209, 104, 97, 32, 129 }, new byte[] { 209, 152, 30, 185, 239, 33, 78, 228, 44, 89, 57, 13, 8, 54, 75, 120, 235, 236, 214, 219, 221, 40, 226, 143, 97, 194, 37, 90, 204, 63, 45, 43, 238, 93, 163, 81, 250, 134, 37, 97, 156, 69, 40, 7, 173, 253, 241, 196, 205, 64, 100, 245, 220, 152, 38, 220, 114, 144, 169, 194, 105, 246, 211, 14, 199, 65, 9, 206, 177, 125, 218, 30, 30, 42, 172, 62, 93, 170, 82, 125, 229, 95, 45, 126, 229, 239, 150, 253, 126, 87, 64, 51, 42, 63, 38, 143, 117, 137, 77, 128, 214, 203, 202, 149, 30, 70, 243, 66, 252, 77, 132, 29, 143, 137, 67, 0, 148, 147, 248, 37, 64, 149, 231, 135, 254, 181, 182, 180 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 152, 188, 5, 135, 85, 137, 91, 2, 182, 239, 133, 18, 174, 200, 95, 163, 10, 22, 99, 65, 140, 254, 218, 160, 49, 196, 67, 235, 129, 16, 179, 191, 154, 188, 75, 100, 251, 222, 189, 40, 146, 244, 85, 61, 171, 110, 60, 251, 68, 111, 163, 98, 17, 3, 84, 99, 187, 222, 79, 209, 104, 97, 32, 129 }, new byte[] { 209, 152, 30, 185, 239, 33, 78, 228, 44, 89, 57, 13, 8, 54, 75, 120, 235, 236, 214, 219, 221, 40, 226, 143, 97, 194, 37, 90, 204, 63, 45, 43, 238, 93, 163, 81, 250, 134, 37, 97, 156, 69, 40, 7, 173, 253, 241, 196, 205, 64, 100, 245, 220, 152, 38, 220, 114, 144, 169, 194, 105, 246, 211, 14, 199, 65, 9, 206, 177, 125, 218, 30, 30, 42, 172, 62, 93, 170, 82, 125, 229, 95, 45, 126, 229, 239, 150, 253, 126, 87, 64, 51, 42, 63, 38, 143, 117, 137, 77, 128, 214, 203, 202, 149, 30, 70, 243, 66, 252, 77, 132, 29, 143, 137, 67, 0, 148, 147, 248, 37, 64, 149, 231, 135, 254, 181, 182, 180 } });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "BodyType", "VehicleRegistrationNumber" },
                values: new object[,]
                {
                    { new Guid("329631bc-2d5e-47f6-a28e-f6a047408df8"), "Truck", "KDE 228S" },
                    { new Guid("4a5739a9-bf13-4dea-be4c-a6324220d180"), "Truck", "KCY 067A" },
                    { new Guid("9d826d6d-e932-4d96-b5a2-c9815805968a"), "Van", "KAY 215H" },
                    { new Guid("b25db492-d121-41a5-8983-eaec1aa4a426"), "Truck", "KCZ 595L" },
                    { new Guid("b7e533da-e584-4984-8339-6691aae4279a"), "Van", "KBF 462A" },
                    { new Guid("b8f9520b-47c2-4dff-88df-50ab68feae63"), "Truck", "KDL 085M" },
                    { new Guid("bc36f9c1-0005-4bb0-a790-a340f96ab8b0"), "Truck", "KDB 387Q" }
                });
        }
    }
}
