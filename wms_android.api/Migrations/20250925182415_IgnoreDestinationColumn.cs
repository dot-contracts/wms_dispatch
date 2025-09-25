using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace wms_android.api.Migrations
{
    /// <inheritdoc />
    public partial class IgnoreDestinationColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("163eac85-2666-4a23-b201-049c5baba385"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("2275eaec-7783-489e-a23c-292ee95c5025"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("373c8c86-0df1-4009-a68d-921afef3cd78"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("4f506c2a-b1cb-40cf-807a-466c283878af"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("6add5c43-b9b1-4519-90f7-e1c020a966f1"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("973a7126-0b41-4055-b10b-93b39de35247"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("abf57ca0-6c59-4d92-a83f-ecb1ebed9e9b"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("ad12a36c-aac8-4739-b299-fe203ba3f189"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("c748251a-65f1-4014-b917-a9d7e76143ec"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("dda13c42-d7c0-4cc4-bdfb-c6dd955bd608"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("1acfb8bd-792d-40fd-8fc6-20bc9ec127ce"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("2c67897b-9eeb-4878-9b79-e5caf61973a2"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("83578eec-4d4e-43bf-aeea-eda0634faf7f"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("acabb659-b973-49b4-b2d6-566c06a20035"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("c79614be-b1bb-4069-89d6-4b7a6cac18c5"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("e419da28-0ee7-45af-a78f-6d7d6daa0536"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("f592c1f6-07f7-41ab-a69d-a48455370d77"));

            migrationBuilder.DropColumn(
                name: "Destination",
                table: "Dispatches");

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "FirstName", "Initials", "LastName", "LicenseNumber" },
                values: new object[,]
                {
                    { new Guid("06a60ac6-ad16-4f32-9689-9757b8b917f2"), "Robert", "RN", "Njuguna", "DL123456" },
                    { new Guid("0bda8973-407d-4505-b922-ce27b136409a"), "David", "DK", "Kibet", "DL123456" },
                    { new Guid("1aaaf0b6-22fe-4e54-9210-a4e47c08345b"), "Charles", "CM", "Maina", "DL123456" },
                    { new Guid("3cc65188-1fe3-42c4-8edc-7543ca43c69c"), "David", "DM", "Mwangi", "DL123456" },
                    { new Guid("60d68c5f-2e48-4fed-9f41-771fbea625fc"), "James", "JG", "Gichohi", "DL123456" },
                    { new Guid("64b02103-e30d-4044-8ff0-be9fb1d869c9"), "Julius", "JK", "Kamula", "DL123456" },
                    { new Guid("a4e7cdef-c602-499f-b6d8-ac6b00f8c2ea"), "Erastus", "EK", "Kagwa", "DL123456" },
                    { new Guid("b3ab115c-9157-438d-bf44-45e5546de244"), "John", "JM", "Mwai", "DL123456" },
                    { new Guid("c2d98fea-83bc-43d3-aeeb-4473e4936c30"), "John", "JN", "Njuguna", "DL123456" },
                    { new Guid("d6931e85-b30e-4759-89b6-e3051bbf159a"), "Stephen", "SK", "Kimuyu", "DL123456" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 140, 147, 29, 161, 78, 185, 169, 203, 157, 133, 18, 216, 58, 16, 220, 177, 56, 115, 114, 38, 45, 159, 183, 60, 69, 159, 228, 112, 39, 71, 244, 203, 119, 74, 154, 100, 32, 171, 31, 245, 56, 254, 186, 181, 54, 94, 246, 5, 206, 10, 152, 96, 12, 252, 145, 151, 162, 240, 125, 159, 226, 161, 75 }, new byte[] { 227, 107, 74, 84, 56, 205, 252, 78, 255, 84, 156, 107, 80, 90, 193, 150, 191, 124, 246, 3, 10, 133, 249, 104, 15, 79, 44, 231, 245, 42, 51, 53, 242, 191, 237, 193, 244, 183, 173, 180, 41, 232, 50, 99, 83, 67, 253, 37, 200, 58, 63, 141, 140, 224, 248, 127, 0, 49, 202, 224, 13, 49, 22, 5, 15, 81, 105, 228, 249, 63, 150, 136, 246, 99, 8, 0, 170, 30, 128, 164, 83, 80, 62, 176, 142, 34, 86, 160, 59, 1, 50, 8, 98, 6, 83, 99, 172, 40, 227, 97, 61, 173, 167, 150, 224, 33, 193, 167, 108, 53, 128, 75, 75, 133, 248, 184, 24, 249, 98, 173, 23, 233, 205, 75, 227, 140, 222, 233 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 140, 147, 29, 161, 78, 185, 169, 203, 157, 133, 18, 216, 58, 16, 220, 177, 56, 115, 114, 38, 45, 159, 183, 60, 69, 159, 228, 112, 39, 71, 244, 203, 119, 74, 154, 100, 32, 171, 31, 245, 56, 254, 186, 181, 54, 94, 246, 5, 206, 10, 152, 96, 12, 252, 145, 151, 162, 240, 125, 159, 226, 161, 75 }, new byte[] { 227, 107, 74, 84, 56, 205, 252, 78, 255, 84, 156, 107, 80, 90, 193, 150, 191, 124, 246, 3, 10, 133, 249, 104, 15, 79, 44, 231, 245, 42, 51, 53, 242, 191, 237, 193, 244, 183, 173, 180, 41, 232, 50, 99, 83, 67, 253, 37, 200, 58, 63, 141, 140, 224, 248, 127, 0, 49, 202, 224, 13, 49, 22, 5, 15, 81, 105, 228, 249, 63, 150, 136, 246, 99, 8, 0, 170, 30, 128, 164, 83, 80, 62, 176, 142, 34, 86, 160, 59, 1, 50, 8, 98, 6, 83, 99, 172, 40, 227, 97, 61, 173, 167, 150, 224, 33, 193, 167, 108, 53, 128, 75, 75, 133, 248, 184, 24, 249, 98, 173, 23, 233, 205, 75, 227, 140, 222, 233 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 140, 147, 29, 161, 78, 185, 169, 203, 157, 133, 18, 216, 58, 16, 220, 177, 56, 115, 114, 38, 45, 159, 183, 60, 69, 159, 228, 112, 39, 71, 244, 203, 119, 74, 154, 100, 32, 171, 31, 245, 56, 254, 186, 181, 54, 94, 246, 5, 206, 10, 152, 96, 12, 252, 145, 151, 162, 240, 125, 159, 226, 161, 75 }, new byte[] { 227, 107, 74, 84, 56, 205, 252, 78, 255, 84, 156, 107, 80, 90, 193, 150, 191, 124, 246, 3, 10, 133, 249, 104, 15, 79, 44, 231, 245, 42, 51, 53, 242, 191, 237, 193, 244, 183, 173, 180, 41, 232, 50, 99, 83, 67, 253, 37, 200, 58, 63, 141, 140, 224, 248, 127, 0, 49, 202, 224, 13, 49, 22, 5, 15, 81, 105, 228, 249, 63, 150, 136, 246, 99, 8, 0, 170, 30, 128, 164, 83, 80, 62, 176, 142, 34, 86, 160, 59, 1, 50, 8, 98, 6, 83, 99, 172, 40, 227, 97, 61, 173, 167, 150, 224, 33, 193, 167, 108, 53, 128, 75, 75, 133, 248, 184, 24, 249, 98, 173, 23, 233, 205, 75, 227, 140, 222, 233 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 140, 147, 29, 161, 78, 185, 169, 203, 157, 133, 18, 216, 58, 16, 220, 177, 56, 115, 114, 38, 45, 159, 183, 60, 69, 159, 228, 112, 39, 71, 244, 203, 119, 74, 154, 100, 32, 171, 31, 245, 56, 254, 186, 181, 54, 94, 246, 5, 206, 10, 152, 96, 12, 252, 145, 151, 162, 240, 125, 159, 226, 161, 75 }, new byte[] { 227, 107, 74, 84, 56, 205, 252, 78, 255, 84, 156, 107, 80, 90, 193, 150, 191, 124, 246, 3, 10, 133, 249, 104, 15, 79, 44, 231, 245, 42, 51, 53, 242, 191, 237, 193, 244, 183, 173, 180, 41, 232, 50, 99, 83, 67, 253, 37, 200, 58, 63, 141, 140, 224, 248, 127, 0, 49, 202, 224, 13, 49, 22, 5, 15, 81, 105, 228, 249, 63, 150, 136, 246, 99, 8, 0, 170, 30, 128, 164, 83, 80, 62, 176, 142, 34, 86, 160, 59, 1, 50, 8, 98, 6, 83, 99, 172, 40, 227, 97, 61, 173, 167, 150, 224, 33, 193, 167, 108, 53, 128, 75, 75, 133, 248, 184, 24, 249, 98, 173, 23, 233, 205, 75, 227, 140, 222, 233 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 140, 147, 29, 161, 78, 185, 169, 203, 157, 133, 18, 216, 58, 16, 220, 177, 56, 115, 114, 38, 45, 159, 183, 60, 69, 159, 228, 112, 39, 71, 244, 203, 119, 74, 154, 100, 32, 171, 31, 245, 56, 254, 186, 181, 54, 94, 246, 5, 206, 10, 152, 96, 12, 252, 145, 151, 162, 240, 125, 159, 226, 161, 75 }, new byte[] { 227, 107, 74, 84, 56, 205, 252, 78, 255, 84, 156, 107, 80, 90, 193, 150, 191, 124, 246, 3, 10, 133, 249, 104, 15, 79, 44, 231, 245, 42, 51, 53, 242, 191, 237, 193, 244, 183, 173, 180, 41, 232, 50, 99, 83, 67, 253, 37, 200, 58, 63, 141, 140, 224, 248, 127, 0, 49, 202, 224, 13, 49, 22, 5, 15, 81, 105, 228, 249, 63, 150, 136, 246, 99, 8, 0, 170, 30, 128, 164, 83, 80, 62, 176, 142, 34, 86, 160, 59, 1, 50, 8, 98, 6, 83, 99, 172, 40, 227, 97, 61, 173, 167, 150, 224, 33, 193, 167, 108, 53, 128, 75, 75, 133, 248, 184, 24, 249, 98, 173, 23, 233, 205, 75, 227, 140, 222, 233 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 140, 147, 29, 161, 78, 185, 169, 203, 157, 133, 18, 216, 58, 16, 220, 177, 56, 115, 114, 38, 45, 159, 183, 60, 69, 159, 228, 112, 39, 71, 244, 203, 119, 74, 154, 100, 32, 171, 31, 245, 56, 254, 186, 181, 54, 94, 246, 5, 206, 10, 152, 96, 12, 252, 145, 151, 162, 240, 125, 159, 226, 161, 75 }, new byte[] { 227, 107, 74, 84, 56, 205, 252, 78, 255, 84, 156, 107, 80, 90, 193, 150, 191, 124, 246, 3, 10, 133, 249, 104, 15, 79, 44, 231, 245, 42, 51, 53, 242, 191, 237, 193, 244, 183, 173, 180, 41, 232, 50, 99, 83, 67, 253, 37, 200, 58, 63, 141, 140, 224, 248, 127, 0, 49, 202, 224, 13, 49, 22, 5, 15, 81, 105, 228, 249, 63, 150, 136, 246, 99, 8, 0, 170, 30, 128, 164, 83, 80, 62, 176, 142, 34, 86, 160, 59, 1, 50, 8, 98, 6, 83, 99, 172, 40, 227, 97, 61, 173, 167, 150, 224, 33, 193, 167, 108, 53, 128, 75, 75, 133, 248, 184, 24, 249, 98, 173, 23, 233, 205, 75, 227, 140, 222, 233 } });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "BodyType", "VehicleRegistrationNumber" },
                values: new object[,]
                {
                    { new Guid("325b4f35-a298-43b1-853e-816230ccca0a"), "Truck", "KCZ 595L" },
                    { new Guid("3c208f95-3fe2-43f2-a672-aa6809e51d04"), "Van", "KBF 462A" },
                    { new Guid("81c7681b-2800-4197-9314-eee5de080201"), "Truck", "KDB 387Q" },
                    { new Guid("8d7451fe-9d32-44b3-ba36-3c5c407bfb89"), "Truck", "KDE 228S" },
                    { new Guid("b4810684-932a-452f-bb94-61b04775a861"), "Truck", "KCY 067A" },
                    { new Guid("b64ff640-5bad-4f04-802e-9b3fa49abcfd"), "Truck", "KDL 085M" },
                    { new Guid("c79129b3-8e23-4e97-8ce4-21f03d0f245e"), "Van", "KAY 215H" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("06a60ac6-ad16-4f32-9689-9757b8b917f2"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("0bda8973-407d-4505-b922-ce27b136409a"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("1aaaf0b6-22fe-4e54-9210-a4e47c08345b"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("3cc65188-1fe3-42c4-8edc-7543ca43c69c"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("60d68c5f-2e48-4fed-9f41-771fbea625fc"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("64b02103-e30d-4044-8ff0-be9fb1d869c9"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("a4e7cdef-c602-499f-b6d8-ac6b00f8c2ea"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("b3ab115c-9157-438d-bf44-45e5546de244"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("c2d98fea-83bc-43d3-aeeb-4473e4936c30"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("d6931e85-b30e-4759-89b6-e3051bbf159a"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("325b4f35-a298-43b1-853e-816230ccca0a"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("3c208f95-3fe2-43f2-a672-aa6809e51d04"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("81c7681b-2800-4197-9314-eee5de080201"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("8d7451fe-9d32-44b3-ba36-3c5c407bfb89"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("b4810684-932a-452f-bb94-61b04775a861"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("b64ff640-5bad-4f04-802e-9b3fa49abcfd"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("c79129b3-8e23-4e97-8ce4-21f03d0f245e"));

            migrationBuilder.AddColumn<string>(
                name: "Destination",
                table: "Dispatches",
                type: "text",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "FirstName", "Initials", "LastName", "LicenseNumber" },
                values: new object[,]
                {
                    { new Guid("163eac85-2666-4a23-b201-049c5baba385"), "Julius", "JK", "Kamula", "DL123456" },
                    { new Guid("2275eaec-7783-489e-a23c-292ee95c5025"), "Robert", "RN", "Njuguna", "DL123456" },
                    { new Guid("373c8c86-0df1-4009-a68d-921afef3cd78"), "David", "DM", "Mwangi", "DL123456" },
                    { new Guid("4f506c2a-b1cb-40cf-807a-466c283878af"), "Charles", "CM", "Maina", "DL123456" },
                    { new Guid("6add5c43-b9b1-4519-90f7-e1c020a966f1"), "Stephen", "SK", "Kimuyu", "DL123456" },
                    { new Guid("973a7126-0b41-4055-b10b-93b39de35247"), "John", "JM", "Mwai", "DL123456" },
                    { new Guid("abf57ca0-6c59-4d92-a83f-ecb1ebed9e9b"), "Erastus", "EK", "Kagwa", "DL123456" },
                    { new Guid("ad12a36c-aac8-4739-b299-fe203ba3f189"), "James", "JG", "Gichohi", "DL123456" },
                    { new Guid("c748251a-65f1-4014-b917-a9d7e76143ec"), "David", "DK", "Kibet", "DL123456" },
                    { new Guid("dda13c42-d7c0-4cc4-bdfb-c6dd955bd608"), "John", "JN", "Njuguna", "DL123456" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 163, 32, 130, 65, 64, 167, 185, 112, 162, 55, 148, 90, 30, 72, 40, 22, 150, 216, 242, 67, 203, 18, 25, 247, 230, 143, 103, 248, 89, 22, 56, 249, 98, 49, 45, 57, 40, 149, 147, 42, 46, 221, 9, 135, 222, 159, 44, 191, 176, 228, 195, 47, 7, 51, 89, 60, 27, 174, 142, 163, 86, 18, 140, 168 }, new byte[] { 51, 97, 223, 153, 210, 75, 110, 239, 110, 208, 187, 39, 23, 7, 80, 69, 211, 190, 130, 187, 186, 67, 76, 40, 39, 189, 177, 180, 30, 239, 118, 67, 171, 140, 27, 103, 237, 251, 68, 0, 50, 117, 248, 150, 35, 145, 161, 90, 177, 252, 170, 55, 138, 224, 1, 203, 8, 179, 234, 81, 64, 16, 2, 87, 140, 136, 240, 0, 12, 250, 116, 193, 222, 159, 87, 201, 18, 177, 212, 209, 130, 139, 68, 16, 218, 77, 27, 251, 98, 162, 225, 61, 78, 227, 204, 235, 59, 57, 132, 149, 212, 118, 6, 244, 62, 90, 237, 66, 107, 207, 113, 77, 146, 69, 147, 123, 41, 161, 86, 94, 35, 225, 116, 65, 143, 221, 248, 126 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 163, 32, 130, 65, 64, 167, 185, 112, 162, 55, 148, 90, 30, 72, 40, 22, 150, 216, 242, 67, 203, 18, 25, 247, 230, 143, 103, 248, 89, 22, 56, 249, 98, 49, 45, 57, 40, 149, 147, 42, 46, 221, 9, 135, 222, 159, 44, 191, 176, 228, 195, 47, 7, 51, 89, 60, 27, 174, 142, 163, 86, 18, 140, 168 }, new byte[] { 51, 97, 223, 153, 210, 75, 110, 239, 110, 208, 187, 39, 23, 7, 80, 69, 211, 190, 130, 187, 186, 67, 76, 40, 39, 189, 177, 180, 30, 239, 118, 67, 171, 140, 27, 103, 237, 251, 68, 0, 50, 117, 248, 150, 35, 145, 161, 90, 177, 252, 170, 55, 138, 224, 1, 203, 8, 179, 234, 81, 64, 16, 2, 87, 140, 136, 240, 0, 12, 250, 116, 193, 222, 159, 87, 201, 18, 177, 212, 209, 130, 139, 68, 16, 218, 77, 27, 251, 98, 162, 225, 61, 78, 227, 204, 235, 59, 57, 132, 149, 212, 118, 6, 244, 62, 90, 237, 66, 107, 207, 113, 77, 146, 69, 147, 123, 41, 161, 86, 94, 35, 225, 116, 65, 143, 221, 248, 126 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 163, 32, 130, 65, 64, 167, 185, 112, 162, 55, 148, 90, 30, 72, 40, 22, 150, 216, 242, 67, 203, 18, 25, 247, 230, 143, 103, 248, 89, 22, 56, 249, 98, 49, 45, 57, 40, 149, 147, 42, 46, 221, 9, 135, 222, 159, 44, 191, 176, 228, 195, 47, 7, 51, 89, 60, 27, 174, 142, 163, 86, 18, 140, 168 }, new byte[] { 51, 97, 223, 153, 210, 75, 110, 239, 110, 208, 187, 39, 23, 7, 80, 69, 211, 190, 130, 187, 186, 67, 76, 40, 39, 189, 177, 180, 30, 239, 118, 67, 171, 140, 27, 103, 237, 251, 68, 0, 50, 117, 248, 150, 35, 145, 161, 90, 177, 252, 170, 55, 138, 224, 1, 203, 8, 179, 234, 81, 64, 16, 2, 87, 140, 136, 240, 0, 12, 250, 116, 193, 222, 159, 87, 201, 18, 177, 212, 209, 130, 139, 68, 16, 218, 77, 27, 251, 98, 162, 225, 61, 78, 227, 204, 235, 59, 57, 132, 149, 212, 118, 6, 244, 62, 90, 237, 66, 107, 207, 113, 77, 146, 69, 147, 123, 41, 161, 86, 94, 35, 225, 116, 65, 143, 221, 248, 126 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 163, 32, 130, 65, 64, 167, 185, 112, 162, 55, 148, 90, 30, 72, 40, 22, 150, 216, 242, 67, 203, 18, 25, 247, 230, 143, 103, 248, 89, 22, 56, 249, 98, 49, 45, 57, 40, 149, 147, 42, 46, 221, 9, 135, 222, 159, 44, 191, 176, 228, 195, 47, 7, 51, 89, 60, 27, 174, 142, 163, 86, 18, 140, 168 }, new byte[] { 51, 97, 223, 153, 210, 75, 110, 239, 110, 208, 187, 39, 23, 7, 80, 69, 211, 190, 130, 187, 186, 67, 76, 40, 39, 189, 177, 180, 30, 239, 118, 67, 171, 140, 27, 103, 237, 251, 68, 0, 50, 117, 248, 150, 35, 145, 161, 90, 177, 252, 170, 55, 138, 224, 1, 203, 8, 179, 234, 81, 64, 16, 2, 87, 140, 136, 240, 0, 12, 250, 116, 193, 222, 159, 87, 201, 18, 177, 212, 209, 130, 139, 68, 16, 218, 77, 27, 251, 98, 162, 225, 61, 78, 227, 204, 235, 59, 57, 132, 149, 212, 118, 6, 244, 62, 90, 237, 66, 107, 207, 113, 77, 146, 69, 147, 123, 41, 161, 86, 94, 35, 225, 116, 65, 143, 221, 248, 126 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 163, 32, 130, 65, 64, 167, 185, 112, 162, 55, 148, 90, 30, 72, 40, 22, 150, 216, 242, 67, 203, 18, 25, 247, 230, 143, 103, 248, 89, 22, 56, 249, 98, 49, 45, 57, 40, 149, 147, 42, 46, 221, 9, 135, 222, 159, 44, 191, 176, 228, 195, 47, 7, 51, 89, 60, 27, 174, 142, 163, 86, 18, 140, 168 }, new byte[] { 51, 97, 223, 153, 210, 75, 110, 239, 110, 208, 187, 39, 23, 7, 80, 69, 211, 190, 130, 187, 186, 67, 76, 40, 39, 189, 177, 180, 30, 239, 118, 67, 171, 140, 27, 103, 237, 251, 68, 0, 50, 117, 248, 150, 35, 145, 161, 90, 177, 252, 170, 55, 138, 224, 1, 203, 8, 179, 234, 81, 64, 16, 2, 87, 140, 136, 240, 0, 12, 250, 116, 193, 222, 159, 87, 201, 18, 177, 212, 209, 130, 139, 68, 16, 218, 77, 27, 251, 98, 162, 225, 61, 78, 227, 204, 235, 59, 57, 132, 149, 212, 118, 6, 244, 62, 90, 237, 66, 107, 207, 113, 77, 146, 69, 147, 123, 41, 161, 86, 94, 35, 225, 116, 65, 143, 221, 248, 126 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 163, 32, 130, 65, 64, 167, 185, 112, 162, 55, 148, 90, 30, 72, 40, 22, 150, 216, 242, 67, 203, 18, 25, 247, 230, 143, 103, 248, 89, 22, 56, 249, 98, 49, 45, 57, 40, 149, 147, 42, 46, 221, 9, 135, 222, 159, 44, 191, 176, 228, 195, 47, 7, 51, 89, 60, 27, 174, 142, 163, 86, 18, 140, 168 }, new byte[] { 51, 97, 223, 153, 210, 75, 110, 239, 110, 208, 187, 39, 23, 7, 80, 69, 211, 190, 130, 187, 186, 67, 76, 40, 39, 189, 177, 180, 30, 239, 118, 67, 171, 140, 27, 103, 237, 251, 68, 0, 50, 117, 248, 150, 35, 145, 161, 90, 177, 252, 170, 55, 138, 224, 1, 203, 8, 179, 234, 81, 64, 16, 2, 87, 140, 136, 240, 0, 12, 250, 116, 193, 222, 159, 87, 201, 18, 177, 212, 209, 130, 139, 68, 16, 218, 77, 27, 251, 98, 162, 225, 61, 78, 227, 204, 235, 59, 57, 132, 149, 212, 118, 6, 244, 62, 90, 237, 66, 107, 207, 113, 77, 146, 69, 147, 123, 41, 161, 86, 94, 35, 225, 116, 65, 143, 221, 248, 126 } });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "BodyType", "VehicleRegistrationNumber" },
                values: new object[,]
                {
                    { new Guid("1acfb8bd-792d-40fd-8fc6-20bc9ec127ce"), "Truck", "KCY 067A" },
                    { new Guid("2c67897b-9eeb-4878-9b79-e5caf61973a2"), "Van", "KAY 215H" },
                    { new Guid("83578eec-4d4e-43bf-aeea-eda0634faf7f"), "Truck", "KDB 387Q" },
                    { new Guid("acabb659-b973-49b4-b2d6-566c06a20035"), "Truck", "KDL 085M" },
                    { new Guid("c79614be-b1bb-4069-89d6-4b7a6cac18c5"), "Truck", "KDE 228S" },
                    { new Guid("e419da28-0ee7-45af-a78f-6d7d6daa0536"), "Truck", "KCZ 595L" },
                    { new Guid("f592c1f6-07f7-41ab-a69d-a48455370d77"), "Van", "KBF 462A" }
                });
        }
    }
}
