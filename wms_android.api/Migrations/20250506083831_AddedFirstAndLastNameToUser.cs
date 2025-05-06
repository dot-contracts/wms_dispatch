using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace wms_android.api.Migrations
{
    /// <inheritdoc />
    public partial class AddedFirstAndLastNameToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "FirstName", "Initials", "LastName", "LicenseNumber" },
                values: new object[,]
                {
                    { new Guid("2e8af441-cc17-4b1a-92fe-f45d636740d9"), "James", "JG", "Gichohi", "DL123456" },
                    { new Guid("2ff84868-ca38-40c6-8ef1-c4d215d5616e"), "Robert", "RN", "Njuguna", "DL123456" },
                    { new Guid("39a1c3a5-db9e-4b9a-aa3a-3ce3c2527b8d"), "Charles", "CM", "Maina", "DL123456" },
                    { new Guid("4be69771-c497-44eb-ab44-80ff2e09ce0d"), "David", "DK", "Kibet", "DL123456" },
                    { new Guid("68bb68e0-1a10-46c2-87f8-890c3c1bb812"), "Erastus", "EK", "Kagwa", "DL123456" },
                    { new Guid("c43b5c89-3345-4b90-8ac4-8500398343b4"), "Julius", "JK", "Kamula", "DL123456" },
                    { new Guid("d323cdf3-d31c-45a2-b413-07cb612e0594"), "John", "JN", "Njuguna", "DL123456" },
                    { new Guid("df7c29b0-d93a-458c-a623-81e463f8591b"), "Stephen", "SK", "Kimuyu", "DL123456" },
                    { new Guid("e00fec38-79cc-42ff-aef4-ba0482da1e4b"), "John", "JM", "Mwai", "DL123456" },
                    { new Guid("fc3f5f6a-27f7-49d8-bacd-efbeac8afbf9"), "David", "DM", "Mwangi", "DL123456" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FirstName", "LastName", "Password", "PasswordHash", "PasswordSalt" },
                values: new object[] { "Admin", "User", "hashed_password_placeholder", new byte[] { 199, 82, 119, 238, 139, 201, 57, 181, 15, 247, 139, 189, 102, 141, 112, 189, 214, 205, 240, 83, 239, 61, 56, 102, 85, 195, 122, 89, 253, 184, 177, 199, 169, 97, 210, 178, 36, 19, 20, 59, 37, 27, 212, 110, 148, 45, 213, 175, 187, 12, 240, 250, 244, 181, 230, 71, 150, 235, 25, 197, 124, 168, 140, 144 }, new byte[] { 161, 209, 38, 21, 33, 120, 41, 10, 101, 88, 11, 141, 91, 225, 72, 254, 36, 96, 89, 204, 163, 213, 221, 206, 228, 62, 169, 12, 59, 232, 192, 238, 7, 158, 65, 246, 35, 102, 121, 254, 82, 111, 127, 129, 118, 54, 82, 108, 88, 150, 32, 25, 71, 44, 216, 116, 222, 39, 44, 77, 207, 85, 30, 62, 10, 12, 26, 94, 220, 14, 49, 220, 176, 179, 144, 164, 13, 95, 110, 226, 34, 169, 186, 201, 136, 64, 230, 129, 106, 216, 9, 138, 194, 18, 156, 189, 174, 220, 35, 53, 80, 198, 65, 98, 62, 250, 56, 213, 146, 96, 123, 237, 107, 236, 186, 248, 89, 65, 147, 20, 117, 57, 246, 195, 192, 6, 129, 53 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FirstName", "LastName", "PasswordHash", "PasswordSalt" },
                values: new object[] { "Manager", "User", new byte[] { 199, 82, 119, 238, 139, 201, 57, 181, 15, 247, 139, 189, 102, 141, 112, 189, 214, 205, 240, 83, 239, 61, 56, 102, 85, 195, 122, 89, 253, 184, 177, 199, 169, 97, 210, 178, 36, 19, 20, 59, 37, 27, 212, 110, 148, 45, 213, 175, 187, 12, 240, 250, 244, 181, 230, 71, 150, 235, 25, 197, 124, 168, 140, 144 }, new byte[] { 161, 209, 38, 21, 33, 120, 41, 10, 101, 88, 11, 141, 91, 225, 72, 254, 36, 96, 89, 204, 163, 213, 221, 206, 228, 62, 169, 12, 59, 232, 192, 238, 7, 158, 65, 246, 35, 102, 121, 254, 82, 111, 127, 129, 118, 54, 82, 108, 88, 150, 32, 25, 71, 44, 216, 116, 222, 39, 44, 77, 207, 85, 30, 62, 10, 12, 26, 94, 220, 14, 49, 220, 176, 179, 144, 164, 13, 95, 110, 226, 34, 169, 186, 201, 136, 64, 230, 129, 106, 216, 9, 138, 194, 18, 156, 189, 174, 220, 35, 53, 80, 198, 65, 98, 62, 250, 56, 213, 146, 96, 123, 237, 107, 236, 186, 248, 89, 65, 147, 20, 117, 57, 246, 195, 192, 6, 129, 53 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FirstName", "LastName", "PasswordHash", "PasswordSalt" },
                values: new object[] { "Clerk", "One", new byte[] { 199, 82, 119, 238, 139, 201, 57, 181, 15, 247, 139, 189, 102, 141, 112, 189, 214, 205, 240, 83, 239, 61, 56, 102, 85, 195, 122, 89, 253, 184, 177, 199, 169, 97, 210, 178, 36, 19, 20, 59, 37, 27, 212, 110, 148, 45, 213, 175, 187, 12, 240, 250, 244, 181, 230, 71, 150, 235, 25, 197, 124, 168, 140, 144 }, new byte[] { 161, 209, 38, 21, 33, 120, 41, 10, 101, 88, 11, 141, 91, 225, 72, 254, 36, 96, 89, 204, 163, 213, 221, 206, 228, 62, 169, 12, 59, 232, 192, 238, 7, 158, 65, 246, 35, 102, 121, 254, 82, 111, 127, 129, 118, 54, 82, 108, 88, 150, 32, 25, 71, 44, 216, 116, 222, 39, 44, 77, 207, 85, 30, 62, 10, 12, 26, 94, 220, 14, 49, 220, 176, 179, 144, 164, 13, 95, 110, 226, 34, 169, 186, 201, 136, 64, 230, 129, 106, 216, 9, 138, 194, 18, 156, 189, 174, 220, 35, 53, 80, 198, 65, 98, 62, 250, 56, 213, 146, 96, 123, 237, 107, 236, 186, 248, 89, 65, 147, 20, 117, 57, 246, 195, 192, 6, 129, 53 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FirstName", "LastName", "PasswordHash", "PasswordSalt" },
                values: new object[] { "Clerk", "Two", new byte[] { 199, 82, 119, 238, 139, 201, 57, 181, 15, 247, 139, 189, 102, 141, 112, 189, 214, 205, 240, 83, 239, 61, 56, 102, 85, 195, 122, 89, 253, 184, 177, 199, 169, 97, 210, 178, 36, 19, 20, 59, 37, 27, 212, 110, 148, 45, 213, 175, 187, 12, 240, 250, 244, 181, 230, 71, 150, 235, 25, 197, 124, 168, 140, 144 }, new byte[] { 161, 209, 38, 21, 33, 120, 41, 10, 101, 88, 11, 141, 91, 225, 72, 254, 36, 96, 89, 204, 163, 213, 221, 206, 228, 62, 169, 12, 59, 232, 192, 238, 7, 158, 65, 246, 35, 102, 121, 254, 82, 111, 127, 129, 118, 54, 82, 108, 88, 150, 32, 25, 71, 44, 216, 116, 222, 39, 44, 77, 207, 85, 30, 62, 10, 12, 26, 94, 220, 14, 49, 220, 176, 179, 144, 164, 13, 95, 110, 226, 34, 169, 186, 201, 136, 64, 230, 129, 106, 216, 9, 138, 194, 18, 156, 189, 174, 220, 35, 53, 80, 198, 65, 98, 62, 250, 56, 213, 146, 96, 123, 237, 107, 236, 186, 248, 89, 65, 147, 20, 117, 57, 246, 195, 192, 6, 129, 53 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FirstName", "LastName", "PasswordHash", "PasswordSalt" },
                values: new object[] { "Client", "One", new byte[] { 199, 82, 119, 238, 139, 201, 57, 181, 15, 247, 139, 189, 102, 141, 112, 189, 214, 205, 240, 83, 239, 61, 56, 102, 85, 195, 122, 89, 253, 184, 177, 199, 169, 97, 210, 178, 36, 19, 20, 59, 37, 27, 212, 110, 148, 45, 213, 175, 187, 12, 240, 250, 244, 181, 230, 71, 150, 235, 25, 197, 124, 168, 140, 144 }, new byte[] { 161, 209, 38, 21, 33, 120, 41, 10, 101, 88, 11, 141, 91, 225, 72, 254, 36, 96, 89, 204, 163, 213, 221, 206, 228, 62, 169, 12, 59, 232, 192, 238, 7, 158, 65, 246, 35, 102, 121, 254, 82, 111, 127, 129, 118, 54, 82, 108, 88, 150, 32, 25, 71, 44, 216, 116, 222, 39, 44, 77, 207, 85, 30, 62, 10, 12, 26, 94, 220, 14, 49, 220, 176, 179, 144, 164, 13, 95, 110, 226, 34, 169, 186, 201, 136, 64, 230, 129, 106, 216, 9, 138, 194, 18, 156, 189, 174, 220, 35, 53, 80, 198, 65, 98, 62, 250, 56, 213, 146, 96, 123, 237, 107, 236, 186, 248, 89, 65, 147, 20, 117, 57, 246, 195, 192, 6, 129, 53 } });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "BodyType", "VehicleRegistrationNumber" },
                values: new object[,]
                {
                    { new Guid("0dba1fae-4e43-4a4f-8d1f-ad80129e9722"), "Van", "KBF 462A" },
                    { new Guid("714be203-bbb0-44ca-9b74-9ecc007410b5"), "Truck", "KDE 228S" },
                    { new Guid("8afd1129-1441-46ad-b6a7-3c927c91c229"), "Truck", "KDB 387Q" },
                    { new Guid("b9f12a2c-bf3b-456a-83e5-5f554c3f3b88"), "Truck", "KCZ 595L" },
                    { new Guid("c1780767-8c85-4bbb-80c2-9fb36739e903"), "Truck", "KCY 067A" },
                    { new Guid("ee55b714-646a-443b-afd4-661bc6fcf70a"), "Van", "KAY 215H" },
                    { new Guid("fc1b667b-20db-494d-a504-7c160c73558c"), "Truck", "KDL 085M" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("2e8af441-cc17-4b1a-92fe-f45d636740d9"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("2ff84868-ca38-40c6-8ef1-c4d215d5616e"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("39a1c3a5-db9e-4b9a-aa3a-3ce3c2527b8d"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("4be69771-c497-44eb-ab44-80ff2e09ce0d"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("68bb68e0-1a10-46c2-87f8-890c3c1bb812"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("c43b5c89-3345-4b90-8ac4-8500398343b4"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("d323cdf3-d31c-45a2-b413-07cb612e0594"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("df7c29b0-d93a-458c-a623-81e463f8591b"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("e00fec38-79cc-42ff-aef4-ba0482da1e4b"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("fc3f5f6a-27f7-49d8-bacd-efbeac8afbf9"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("0dba1fae-4e43-4a4f-8d1f-ad80129e9722"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("714be203-bbb0-44ca-9b74-9ecc007410b5"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("8afd1129-1441-46ad-b6a7-3c927c91c229"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("b9f12a2c-bf3b-456a-83e5-5f554c3f3b88"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("c1780767-8c85-4bbb-80c2-9fb36739e903"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("ee55b714-646a-443b-afd4-661bc6fcf70a"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("fc1b667b-20db-494d-a504-7c160c73558c"));

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Users");

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
                columns: new[] { "Password", "PasswordHash", "PasswordSalt" },
                values: new object[] { "admin123", new byte[] { 252, 113, 1, 132, 185, 3, 119, 182, 175, 109, 202, 4, 97, 212, 32, 203, 175, 181, 221, 61, 227, 74, 118, 220, 228, 126, 122, 121, 211, 76, 199, 111, 88, 183, 120, 83, 198, 41, 17, 18, 194, 240, 106, 131, 142, 186, 7, 16, 58, 44, 115, 150, 29, 78, 37, 160, 96, 73, 13, 195, 63, 225, 22, 68 }, new byte[] { 29, 252, 222, 133, 47, 55, 184, 94, 207, 100, 80, 105, 73, 41, 128, 38, 28, 67, 99, 142, 92, 193, 104, 99, 72, 218, 102, 184, 19, 230, 144, 172, 11, 232, 30, 165, 125, 11, 57, 99, 212, 139, 221, 28, 59, 247, 253, 80, 46, 154, 152, 129, 148, 121, 62, 123, 199, 56, 120, 92, 122, 83, 168, 24, 180, 236, 7, 172, 163, 22, 211, 143, 13, 14, 146, 215, 22, 157, 225, 204, 133, 236, 49, 134, 180, 99, 23, 33, 170, 11, 103, 234, 110, 154, 148, 14, 19, 75, 17, 183, 120, 16, 172, 106, 174, 232, 1, 136, 11, 20, 111, 177, 136, 252, 56, 173, 192, 127, 17, 134, 31, 130, 55, 184, 44, 97, 144, 26 } });

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
    }
}
