using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace wms_android.api.Migrations
{
    /// <inheritdoc />
    public partial class UpdateParcelRequiredFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("052db9ea-242d-4dd9-b7ec-fe50ae95ab28"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("243f885d-8b0b-4f19-a7dc-3b6c90c566c4"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("2a173a02-5d97-4434-ae6f-55f1ab08fd91"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("31f05f8d-01be-4aa7-9920-968a1c5751ec"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("45570e31-c40c-4440-9061-43f417239415"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("4655e2d0-f391-4006-9622-272648b0785e"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("72b04a78-6f14-45a4-8c6a-22b669f5c001"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("95759590-9076-40a8-b445-a84e461863c6"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("bc56bb37-37b7-43ce-b82f-a6feff6d28e7"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("d66c50fd-082b-460a-8098-66ebc31560c9"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("50be9366-8704-4845-ae27-4c4d3775798d"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("5abe04c1-c2fa-4676-a5bd-ab29afa27f34"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("89b6eca1-61d4-41b2-afb1-c5c25383eb79"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("b8da3965-4987-46e6-97ce-2f8089208f85"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("d041d9e1-f895-4caa-8303-6c7d93d62613"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("d1e999f3-035d-4313-817a-71eac1dd8ca4"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("d951006a-2587-479d-b6fa-a0af140832eb"));

            migrationBuilder.AlterColumn<string>(
                name: "WaybillNumber",
                table: "Parcels",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "QRCode",
                table: "Parcels",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "FirstName", "Initials", "LastName", "LicenseNumber" },
                values: new object[,]
                {
                    { new Guid("16f3495e-e38a-4237-bf94-35b5fe1985e5"), "John", "JN", "Njuguna", "DL123456" },
                    { new Guid("6929d93b-4b2c-45c0-8f81-9dc7f515fd10"), "Julius", "JK", "Kamula", "DL123456" },
                    { new Guid("9774bbc5-e173-4427-a969-cb72ef667051"), "David", "DM", "Mwangi", "DL123456" },
                    { new Guid("9c6d8dd6-197c-4133-bd70-e9fb0ca7e5df"), "Robert", "RN", "Njuguna", "DL123456" },
                    { new Guid("c193ba8f-2b26-40fb-8b8b-d2aeac9b834c"), "Stephen", "SK", "Kimuyu", "DL123456" },
                    { new Guid("c7b0cb6b-d545-4935-ae4e-36896dcff509"), "John", "JM", "Mwai", "DL123456" },
                    { new Guid("d25fd8aa-425a-436a-a9cc-f6c9a4275d62"), "James", "JG", "Gichohi", "DL123456" },
                    { new Guid("d69540b3-fefa-4414-8da6-ec6a74c81c40"), "David", "DK", "Kibet", "DL123456" },
                    { new Guid("ea79041f-4c53-495e-8b61-bc60ea8d6775"), "Charles", "CM", "Maina", "DL123456" },
                    { new Guid("ee642ac8-c869-413e-8faa-6bcb6e192ca6"), "Erastus", "EK", "Kagwa", "DL123456" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 47, 24, 13, 93, 113, 25, 37, 228, 115, 61, 107, 243, 2, 164, 246, 73, 76, 130, 234, 99, 169, 62, 94, 165, 184, 138, 157, 122, 9, 162, 17, 23, 176, 145, 196, 243, 102, 82, 205, 113, 244, 140, 23, 54, 214, 58, 3, 231, 26, 65, 136, 34, 28, 168, 33, 143, 208, 163, 156, 191, 118, 198, 20, 42 }, new byte[] { 218, 158, 225, 208, 99, 48, 254, 9, 99, 19, 11, 113, 130, 221, 224, 195, 53, 212, 166, 136, 110, 207, 149, 165, 250, 215, 61, 180, 8, 253, 225, 187, 65, 96, 165, 168, 126, 47, 117, 195, 7, 123, 87, 253, 32, 91, 36, 13, 205, 97, 106, 190, 212, 217, 202, 39, 5, 193, 150, 4, 70, 233, 172, 152, 105, 85, 82, 171, 81, 249, 144, 132, 184, 163, 174, 67, 27, 78, 172, 118, 2, 155, 51, 127, 73, 133, 65, 101, 30, 54, 64, 224, 78, 145, 3, 165, 135, 102, 143, 99, 67, 175, 166, 43, 193, 84, 138, 116, 120, 229, 156, 175, 51, 108, 151, 230, 241, 250, 78, 91, 53, 255, 28, 15, 155, 149, 91, 245 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 47, 24, 13, 93, 113, 25, 37, 228, 115, 61, 107, 243, 2, 164, 246, 73, 76, 130, 234, 99, 169, 62, 94, 165, 184, 138, 157, 122, 9, 162, 17, 23, 176, 145, 196, 243, 102, 82, 205, 113, 244, 140, 23, 54, 214, 58, 3, 231, 26, 65, 136, 34, 28, 168, 33, 143, 208, 163, 156, 191, 118, 198, 20, 42 }, new byte[] { 218, 158, 225, 208, 99, 48, 254, 9, 99, 19, 11, 113, 130, 221, 224, 195, 53, 212, 166, 136, 110, 207, 149, 165, 250, 215, 61, 180, 8, 253, 225, 187, 65, 96, 165, 168, 126, 47, 117, 195, 7, 123, 87, 253, 32, 91, 36, 13, 205, 97, 106, 190, 212, 217, 202, 39, 5, 193, 150, 4, 70, 233, 172, 152, 105, 85, 82, 171, 81, 249, 144, 132, 184, 163, 174, 67, 27, 78, 172, 118, 2, 155, 51, 127, 73, 133, 65, 101, 30, 54, 64, 224, 78, 145, 3, 165, 135, 102, 143, 99, 67, 175, 166, 43, 193, 84, 138, 116, 120, 229, 156, 175, 51, 108, 151, 230, 241, 250, 78, 91, 53, 255, 28, 15, 155, 149, 91, 245 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 47, 24, 13, 93, 113, 25, 37, 228, 115, 61, 107, 243, 2, 164, 246, 73, 76, 130, 234, 99, 169, 62, 94, 165, 184, 138, 157, 122, 9, 162, 17, 23, 176, 145, 196, 243, 102, 82, 205, 113, 244, 140, 23, 54, 214, 58, 3, 231, 26, 65, 136, 34, 28, 168, 33, 143, 208, 163, 156, 191, 118, 198, 20, 42 }, new byte[] { 218, 158, 225, 208, 99, 48, 254, 9, 99, 19, 11, 113, 130, 221, 224, 195, 53, 212, 166, 136, 110, 207, 149, 165, 250, 215, 61, 180, 8, 253, 225, 187, 65, 96, 165, 168, 126, 47, 117, 195, 7, 123, 87, 253, 32, 91, 36, 13, 205, 97, 106, 190, 212, 217, 202, 39, 5, 193, 150, 4, 70, 233, 172, 152, 105, 85, 82, 171, 81, 249, 144, 132, 184, 163, 174, 67, 27, 78, 172, 118, 2, 155, 51, 127, 73, 133, 65, 101, 30, 54, 64, 224, 78, 145, 3, 165, 135, 102, 143, 99, 67, 175, 166, 43, 193, 84, 138, 116, 120, 229, 156, 175, 51, 108, 151, 230, 241, 250, 78, 91, 53, 255, 28, 15, 155, 149, 91, 245 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 47, 24, 13, 93, 113, 25, 37, 228, 115, 61, 107, 243, 2, 164, 246, 73, 76, 130, 234, 99, 169, 62, 94, 165, 184, 138, 157, 122, 9, 162, 17, 23, 176, 145, 196, 243, 102, 82, 205, 113, 244, 140, 23, 54, 214, 58, 3, 231, 26, 65, 136, 34, 28, 168, 33, 143, 208, 163, 156, 191, 118, 198, 20, 42 }, new byte[] { 218, 158, 225, 208, 99, 48, 254, 9, 99, 19, 11, 113, 130, 221, 224, 195, 53, 212, 166, 136, 110, 207, 149, 165, 250, 215, 61, 180, 8, 253, 225, 187, 65, 96, 165, 168, 126, 47, 117, 195, 7, 123, 87, 253, 32, 91, 36, 13, 205, 97, 106, 190, 212, 217, 202, 39, 5, 193, 150, 4, 70, 233, 172, 152, 105, 85, 82, 171, 81, 249, 144, 132, 184, 163, 174, 67, 27, 78, 172, 118, 2, 155, 51, 127, 73, 133, 65, 101, 30, 54, 64, 224, 78, 145, 3, 165, 135, 102, 143, 99, 67, 175, 166, 43, 193, 84, 138, 116, 120, 229, 156, 175, 51, 108, 151, 230, 241, 250, 78, 91, 53, 255, 28, 15, 155, 149, 91, 245 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 47, 24, 13, 93, 113, 25, 37, 228, 115, 61, 107, 243, 2, 164, 246, 73, 76, 130, 234, 99, 169, 62, 94, 165, 184, 138, 157, 122, 9, 162, 17, 23, 176, 145, 196, 243, 102, 82, 205, 113, 244, 140, 23, 54, 214, 58, 3, 231, 26, 65, 136, 34, 28, 168, 33, 143, 208, 163, 156, 191, 118, 198, 20, 42 }, new byte[] { 218, 158, 225, 208, 99, 48, 254, 9, 99, 19, 11, 113, 130, 221, 224, 195, 53, 212, 166, 136, 110, 207, 149, 165, 250, 215, 61, 180, 8, 253, 225, 187, 65, 96, 165, 168, 126, 47, 117, 195, 7, 123, 87, 253, 32, 91, 36, 13, 205, 97, 106, 190, 212, 217, 202, 39, 5, 193, 150, 4, 70, 233, 172, 152, 105, 85, 82, 171, 81, 249, 144, 132, 184, 163, 174, 67, 27, 78, 172, 118, 2, 155, 51, 127, 73, 133, 65, 101, 30, 54, 64, 224, 78, 145, 3, 165, 135, 102, 143, 99, 67, 175, 166, 43, 193, 84, 138, 116, 120, 229, 156, 175, 51, 108, 151, 230, 241, 250, 78, 91, 53, 255, 28, 15, 155, 149, 91, 245 } });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "BodyType", "VehicleRegistrationNumber" },
                values: new object[,]
                {
                    { new Guid("1fa2f85c-5a44-4fd5-bd05-b8a22d5429b2"), "Truck", "KDE 228S" },
                    { new Guid("40f50160-ef5b-47d7-8278-c89fe83ae420"), "Truck", "KCZ 595L" },
                    { new Guid("50da6c22-a65a-4a16-a931-7da5aacd298b"), "Truck", "KDL 085M" },
                    { new Guid("a9c675e9-a130-49b3-9085-0c591e98a027"), "Van", "KBF 462A" },
                    { new Guid("bd180c0f-7c7e-4731-8705-563aeff7c3ef"), "Van", "KAY 215H" },
                    { new Guid("c45b2ba7-b7d8-4952-acdb-8c15108fa389"), "Truck", "KCY 067A" },
                    { new Guid("cc81e350-d8f7-458e-bffe-ecc5415d4795"), "Truck", "KDB 387Q" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("16f3495e-e38a-4237-bf94-35b5fe1985e5"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("6929d93b-4b2c-45c0-8f81-9dc7f515fd10"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("9774bbc5-e173-4427-a969-cb72ef667051"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("9c6d8dd6-197c-4133-bd70-e9fb0ca7e5df"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("c193ba8f-2b26-40fb-8b8b-d2aeac9b834c"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("c7b0cb6b-d545-4935-ae4e-36896dcff509"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("d25fd8aa-425a-436a-a9cc-f6c9a4275d62"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("d69540b3-fefa-4414-8da6-ec6a74c81c40"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("ea79041f-4c53-495e-8b61-bc60ea8d6775"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("ee642ac8-c869-413e-8faa-6bcb6e192ca6"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("1fa2f85c-5a44-4fd5-bd05-b8a22d5429b2"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("40f50160-ef5b-47d7-8278-c89fe83ae420"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("50da6c22-a65a-4a16-a931-7da5aacd298b"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("a9c675e9-a130-49b3-9085-0c591e98a027"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("bd180c0f-7c7e-4731-8705-563aeff7c3ef"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("c45b2ba7-b7d8-4952-acdb-8c15108fa389"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("cc81e350-d8f7-458e-bffe-ecc5415d4795"));

            migrationBuilder.AlterColumn<string>(
                name: "WaybillNumber",
                table: "Parcels",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "QRCode",
                table: "Parcels",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "FirstName", "Initials", "LastName", "LicenseNumber" },
                values: new object[,]
                {
                    { new Guid("052db9ea-242d-4dd9-b7ec-fe50ae95ab28"), "Charles", "SK", "Maina", "DL123456" },
                    { new Guid("243f885d-8b0b-4f19-a7dc-3b6c90c566c4"), "Erastus", "EK", "Kagwa", "DL123456" },
                    { new Guid("2a173a02-5d97-4434-ae6f-55f1ab08fd91"), "Julius", "JK", "Kamula", "DL123456" },
                    { new Guid("31f05f8d-01be-4aa7-9920-968a1c5751ec"), "James", "SK", "Gichohi", "DL123456" },
                    { new Guid("45570e31-c40c-4440-9061-43f417239415"), "Robert", "RN", "Njuguna", "DL123456" },
                    { new Guid("4655e2d0-f391-4006-9622-272648b0785e"), "John", "JM", "Mwai", "DL123456" },
                    { new Guid("72b04a78-6f14-45a4-8c6a-22b669f5c001"), "David", "DM", "Mwangi", "DL123456" },
                    { new Guid("95759590-9076-40a8-b445-a84e461863c6"), "Stephen", "SK", "Kimuyu", "DL123456" },
                    { new Guid("bc56bb37-37b7-43ce-b82f-a6feff6d28e7"), "David", "DK", "Kibet", "DL123456" },
                    { new Guid("d66c50fd-082b-460a-8098-66ebc31560c9"), "John", "JN", "Njuguna", "DL123456" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 9, 101, 41, 228, 239, 189, 235, 174, 25, 35, 134, 125, 35, 140, 92, 63, 254, 45, 142, 226, 47, 127, 176, 85, 69, 170, 12, 13, 32, 213, 183, 212, 153, 96, 49, 143, 2, 91, 29, 24, 200, 178, 22, 129, 9, 107, 76, 173, 192, 231, 146, 104, 211, 132, 6, 3, 168, 225, 67, 202, 241, 109, 108, 55 }, new byte[] { 27, 35, 145, 171, 102, 146, 212, 95, 253, 18, 116, 57, 156, 3, 251, 21, 150, 131, 15, 52, 225, 237, 177, 44, 165, 113, 60, 189, 64, 242, 142, 181, 220, 159, 30, 132, 33, 60, 132, 65, 81, 141, 199, 182, 25, 212, 240, 21, 158, 194, 155, 181, 104, 242, 125, 63, 181, 255, 131, 241, 173, 57, 124, 188, 249, 203, 197, 228, 84, 13, 9, 111, 130, 107, 88, 150, 77, 38, 122, 95, 144, 53, 95, 186, 113, 13, 112, 14, 137, 242, 88, 96, 198, 50, 80, 210, 99, 31, 246, 99, 103, 119, 143, 134, 6, 97, 203, 66, 179, 135, 58, 114, 130, 9, 120, 21, 86, 39, 106, 145, 198, 180, 59, 111, 224, 51, 26, 36 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 9, 101, 41, 228, 239, 189, 235, 174, 25, 35, 134, 125, 35, 140, 92, 63, 254, 45, 142, 226, 47, 127, 176, 85, 69, 170, 12, 13, 32, 213, 183, 212, 153, 96, 49, 143, 2, 91, 29, 24, 200, 178, 22, 129, 9, 107, 76, 173, 192, 231, 146, 104, 211, 132, 6, 3, 168, 225, 67, 202, 241, 109, 108, 55 }, new byte[] { 27, 35, 145, 171, 102, 146, 212, 95, 253, 18, 116, 57, 156, 3, 251, 21, 150, 131, 15, 52, 225, 237, 177, 44, 165, 113, 60, 189, 64, 242, 142, 181, 220, 159, 30, 132, 33, 60, 132, 65, 81, 141, 199, 182, 25, 212, 240, 21, 158, 194, 155, 181, 104, 242, 125, 63, 181, 255, 131, 241, 173, 57, 124, 188, 249, 203, 197, 228, 84, 13, 9, 111, 130, 107, 88, 150, 77, 38, 122, 95, 144, 53, 95, 186, 113, 13, 112, 14, 137, 242, 88, 96, 198, 50, 80, 210, 99, 31, 246, 99, 103, 119, 143, 134, 6, 97, 203, 66, 179, 135, 58, 114, 130, 9, 120, 21, 86, 39, 106, 145, 198, 180, 59, 111, 224, 51, 26, 36 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 9, 101, 41, 228, 239, 189, 235, 174, 25, 35, 134, 125, 35, 140, 92, 63, 254, 45, 142, 226, 47, 127, 176, 85, 69, 170, 12, 13, 32, 213, 183, 212, 153, 96, 49, 143, 2, 91, 29, 24, 200, 178, 22, 129, 9, 107, 76, 173, 192, 231, 146, 104, 211, 132, 6, 3, 168, 225, 67, 202, 241, 109, 108, 55 }, new byte[] { 27, 35, 145, 171, 102, 146, 212, 95, 253, 18, 116, 57, 156, 3, 251, 21, 150, 131, 15, 52, 225, 237, 177, 44, 165, 113, 60, 189, 64, 242, 142, 181, 220, 159, 30, 132, 33, 60, 132, 65, 81, 141, 199, 182, 25, 212, 240, 21, 158, 194, 155, 181, 104, 242, 125, 63, 181, 255, 131, 241, 173, 57, 124, 188, 249, 203, 197, 228, 84, 13, 9, 111, 130, 107, 88, 150, 77, 38, 122, 95, 144, 53, 95, 186, 113, 13, 112, 14, 137, 242, 88, 96, 198, 50, 80, 210, 99, 31, 246, 99, 103, 119, 143, 134, 6, 97, 203, 66, 179, 135, 58, 114, 130, 9, 120, 21, 86, 39, 106, 145, 198, 180, 59, 111, 224, 51, 26, 36 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 9, 101, 41, 228, 239, 189, 235, 174, 25, 35, 134, 125, 35, 140, 92, 63, 254, 45, 142, 226, 47, 127, 176, 85, 69, 170, 12, 13, 32, 213, 183, 212, 153, 96, 49, 143, 2, 91, 29, 24, 200, 178, 22, 129, 9, 107, 76, 173, 192, 231, 146, 104, 211, 132, 6, 3, 168, 225, 67, 202, 241, 109, 108, 55 }, new byte[] { 27, 35, 145, 171, 102, 146, 212, 95, 253, 18, 116, 57, 156, 3, 251, 21, 150, 131, 15, 52, 225, 237, 177, 44, 165, 113, 60, 189, 64, 242, 142, 181, 220, 159, 30, 132, 33, 60, 132, 65, 81, 141, 199, 182, 25, 212, 240, 21, 158, 194, 155, 181, 104, 242, 125, 63, 181, 255, 131, 241, 173, 57, 124, 188, 249, 203, 197, 228, 84, 13, 9, 111, 130, 107, 88, 150, 77, 38, 122, 95, 144, 53, 95, 186, 113, 13, 112, 14, 137, 242, 88, 96, 198, 50, 80, 210, 99, 31, 246, 99, 103, 119, 143, 134, 6, 97, 203, 66, 179, 135, 58, 114, 130, 9, 120, 21, 86, 39, 106, 145, 198, 180, 59, 111, 224, 51, 26, 36 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 9, 101, 41, 228, 239, 189, 235, 174, 25, 35, 134, 125, 35, 140, 92, 63, 254, 45, 142, 226, 47, 127, 176, 85, 69, 170, 12, 13, 32, 213, 183, 212, 153, 96, 49, 143, 2, 91, 29, 24, 200, 178, 22, 129, 9, 107, 76, 173, 192, 231, 146, 104, 211, 132, 6, 3, 168, 225, 67, 202, 241, 109, 108, 55 }, new byte[] { 27, 35, 145, 171, 102, 146, 212, 95, 253, 18, 116, 57, 156, 3, 251, 21, 150, 131, 15, 52, 225, 237, 177, 44, 165, 113, 60, 189, 64, 242, 142, 181, 220, 159, 30, 132, 33, 60, 132, 65, 81, 141, 199, 182, 25, 212, 240, 21, 158, 194, 155, 181, 104, 242, 125, 63, 181, 255, 131, 241, 173, 57, 124, 188, 249, 203, 197, 228, 84, 13, 9, 111, 130, 107, 88, 150, 77, 38, 122, 95, 144, 53, 95, 186, 113, 13, 112, 14, 137, 242, 88, 96, 198, 50, 80, 210, 99, 31, 246, 99, 103, 119, 143, 134, 6, 97, 203, 66, 179, 135, 58, 114, 130, 9, 120, 21, 86, 39, 106, 145, 198, 180, 59, 111, 224, 51, 26, 36 } });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "BodyType", "VehicleRegistrationNumber" },
                values: new object[,]
                {
                    { new Guid("50be9366-8704-4845-ae27-4c4d3775798d"), "Truck", "KDL 085M" },
                    { new Guid("5abe04c1-c2fa-4676-a5bd-ab29afa27f34"), "Van", "KAY 215H" },
                    { new Guid("89b6eca1-61d4-41b2-afb1-c5c25383eb79"), "Truck", "KDB 387Q" },
                    { new Guid("b8da3965-4987-46e6-97ce-2f8089208f85"), "Truck", "KCY 067A" },
                    { new Guid("d041d9e1-f895-4caa-8303-6c7d93d62613"), "Truck", "KCZ 595L" },
                    { new Guid("d1e999f3-035d-4313-817a-71eac1dd8ca4"), "Truck", "KDE 228S" },
                    { new Guid("d951006a-2587-479d-b6fa-a0af140832eb"), "Van", "KBF 462A" }
                });
        }
    }
}
