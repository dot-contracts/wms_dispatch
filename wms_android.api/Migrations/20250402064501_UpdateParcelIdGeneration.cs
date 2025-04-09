using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace wms_android.api.Migrations
{
    /// <inheritdoc />
    public partial class UpdateParcelIdGeneration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("08e90668-85b6-45ba-865b-ed743f2f64e4"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("1dc008cf-fc46-451b-8f39-cff71ec87b1a"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("2c0338fa-e582-472f-a16f-e0c2de69e981"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("7ad9819f-bf32-47f8-bc98-95cf0b98b7ab"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("8a9c2192-a003-40d5-a0bc-1db28f28f457"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("959ee432-01ca-44e6-9f6e-47c20ad94696"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("c07addfc-e484-470a-8695-302f036c1e66"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("c670f8bf-6a20-41f4-9017-29f6442c0039"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("c933fec7-8bb8-46c7-809e-fbdd8e4666c1"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("efacc2fa-2c4d-4341-9d86-fe2ba3029c3c"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("0b94c9d5-df9d-41dc-ba92-f62ed52a2b96"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("396910ce-a6ef-4bfe-b393-5e3dd5a768ef"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("75fbd0b6-fd66-4414-9d3c-6ece6155275d"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("7ae1dd12-9c99-4f83-8ef6-2bf81c38b973"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("7cc435ca-a76e-4b35-a93c-382c75123cd1"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("87b8da42-5c25-43a6-8468-201c99d6dcd8"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("b65329e2-f910-4951-83f5-24688aa3a4ee"));

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "FirstName", "Initials", "LastName", "LicenseNumber" },
                values: new object[,]
                {
                    { new Guid("2a87f19e-6abe-4362-8b3c-9b80cada14a5"), "James", "JG", "Gichohi", "DL123456" },
                    { new Guid("3115713e-47b1-40df-b2f1-2bd183db049d"), "John", "JN", "Njuguna", "DL123456" },
                    { new Guid("3b8594e7-6e51-4ea0-b4b0-7442e31a59bd"), "David", "DK", "Kibet", "DL123456" },
                    { new Guid("3e743c05-1633-4d04-b397-91f2c808283b"), "Stephen", "SK", "Kimuyu", "DL123456" },
                    { new Guid("5381a657-df45-4ff7-b3b3-7c44cff4b2d2"), "Julius", "JK", "Kamula", "DL123456" },
                    { new Guid("631e7fc5-d479-4a96-a75b-111474f40355"), "Robert", "RN", "Njuguna", "DL123456" },
                    { new Guid("8e77c7dc-22ef-4354-9d4e-76f00086e1f9"), "Charles", "CM", "Maina", "DL123456" },
                    { new Guid("ad28edbc-1284-4f80-bba1-fde97a2690bc"), "Erastus", "EK", "Kagwa", "DL123456" },
                    { new Guid("b4bcf540-5d37-4169-99d4-5208f818d6ca"), "John", "JM", "Mwai", "DL123456" },
                    { new Guid("c9c1a449-0eaf-438b-8eec-49805045627b"), "David", "DM", "Mwangi", "DL123456" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 34, 51, 69, 168, 187, 108, 215, 201, 51, 40, 193, 167, 79, 28, 174, 240, 236, 223, 167, 206, 60, 15, 24, 216, 58, 225, 227, 155, 241, 156, 200, 2, 107, 201, 139, 13, 71, 202, 92, 188, 181, 62, 19, 255, 169, 216, 151, 172, 216, 95, 86, 245, 74, 255, 166, 151, 188, 240, 42, 206, 118, 38, 185, 58 }, new byte[] { 109, 131, 142, 140, 127, 32, 216, 136, 93, 86, 50, 237, 224, 134, 229, 235, 50, 7, 54, 108, 187, 235, 223, 197, 69, 33, 51, 16, 173, 150, 57, 56, 7, 227, 180, 39, 115, 149, 27, 91, 75, 190, 159, 5, 210, 112, 36, 82, 84, 30, 106, 193, 253, 112, 173, 14, 43, 163, 177, 19, 119, 9, 104, 53, 157, 87, 137, 242, 8, 126, 57, 68, 159, 6, 223, 67, 0, 49, 52, 133, 108, 128, 70, 10, 133, 221, 152, 25, 192, 83, 97, 216, 163, 244, 179, 125, 8, 55, 140, 159, 122, 44, 215, 101, 249, 215, 91, 144, 19, 157, 34, 188, 102, 215, 133, 168, 99, 58, 156, 92, 25, 198, 33, 55, 118, 20, 201, 49 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 34, 51, 69, 168, 187, 108, 215, 201, 51, 40, 193, 167, 79, 28, 174, 240, 236, 223, 167, 206, 60, 15, 24, 216, 58, 225, 227, 155, 241, 156, 200, 2, 107, 201, 139, 13, 71, 202, 92, 188, 181, 62, 19, 255, 169, 216, 151, 172, 216, 95, 86, 245, 74, 255, 166, 151, 188, 240, 42, 206, 118, 38, 185, 58 }, new byte[] { 109, 131, 142, 140, 127, 32, 216, 136, 93, 86, 50, 237, 224, 134, 229, 235, 50, 7, 54, 108, 187, 235, 223, 197, 69, 33, 51, 16, 173, 150, 57, 56, 7, 227, 180, 39, 115, 149, 27, 91, 75, 190, 159, 5, 210, 112, 36, 82, 84, 30, 106, 193, 253, 112, 173, 14, 43, 163, 177, 19, 119, 9, 104, 53, 157, 87, 137, 242, 8, 126, 57, 68, 159, 6, 223, 67, 0, 49, 52, 133, 108, 128, 70, 10, 133, 221, 152, 25, 192, 83, 97, 216, 163, 244, 179, 125, 8, 55, 140, 159, 122, 44, 215, 101, 249, 215, 91, 144, 19, 157, 34, 188, 102, 215, 133, 168, 99, 58, 156, 92, 25, 198, 33, 55, 118, 20, 201, 49 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 34, 51, 69, 168, 187, 108, 215, 201, 51, 40, 193, 167, 79, 28, 174, 240, 236, 223, 167, 206, 60, 15, 24, 216, 58, 225, 227, 155, 241, 156, 200, 2, 107, 201, 139, 13, 71, 202, 92, 188, 181, 62, 19, 255, 169, 216, 151, 172, 216, 95, 86, 245, 74, 255, 166, 151, 188, 240, 42, 206, 118, 38, 185, 58 }, new byte[] { 109, 131, 142, 140, 127, 32, 216, 136, 93, 86, 50, 237, 224, 134, 229, 235, 50, 7, 54, 108, 187, 235, 223, 197, 69, 33, 51, 16, 173, 150, 57, 56, 7, 227, 180, 39, 115, 149, 27, 91, 75, 190, 159, 5, 210, 112, 36, 82, 84, 30, 106, 193, 253, 112, 173, 14, 43, 163, 177, 19, 119, 9, 104, 53, 157, 87, 137, 242, 8, 126, 57, 68, 159, 6, 223, 67, 0, 49, 52, 133, 108, 128, 70, 10, 133, 221, 152, 25, 192, 83, 97, 216, 163, 244, 179, 125, 8, 55, 140, 159, 122, 44, 215, 101, 249, 215, 91, 144, 19, 157, 34, 188, 102, 215, 133, 168, 99, 58, 156, 92, 25, 198, 33, 55, 118, 20, 201, 49 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 34, 51, 69, 168, 187, 108, 215, 201, 51, 40, 193, 167, 79, 28, 174, 240, 236, 223, 167, 206, 60, 15, 24, 216, 58, 225, 227, 155, 241, 156, 200, 2, 107, 201, 139, 13, 71, 202, 92, 188, 181, 62, 19, 255, 169, 216, 151, 172, 216, 95, 86, 245, 74, 255, 166, 151, 188, 240, 42, 206, 118, 38, 185, 58 }, new byte[] { 109, 131, 142, 140, 127, 32, 216, 136, 93, 86, 50, 237, 224, 134, 229, 235, 50, 7, 54, 108, 187, 235, 223, 197, 69, 33, 51, 16, 173, 150, 57, 56, 7, 227, 180, 39, 115, 149, 27, 91, 75, 190, 159, 5, 210, 112, 36, 82, 84, 30, 106, 193, 253, 112, 173, 14, 43, 163, 177, 19, 119, 9, 104, 53, 157, 87, 137, 242, 8, 126, 57, 68, 159, 6, 223, 67, 0, 49, 52, 133, 108, 128, 70, 10, 133, 221, 152, 25, 192, 83, 97, 216, 163, 244, 179, 125, 8, 55, 140, 159, 122, 44, 215, 101, 249, 215, 91, 144, 19, 157, 34, 188, 102, 215, 133, 168, 99, 58, 156, 92, 25, 198, 33, 55, 118, 20, 201, 49 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 34, 51, 69, 168, 187, 108, 215, 201, 51, 40, 193, 167, 79, 28, 174, 240, 236, 223, 167, 206, 60, 15, 24, 216, 58, 225, 227, 155, 241, 156, 200, 2, 107, 201, 139, 13, 71, 202, 92, 188, 181, 62, 19, 255, 169, 216, 151, 172, 216, 95, 86, 245, 74, 255, 166, 151, 188, 240, 42, 206, 118, 38, 185, 58 }, new byte[] { 109, 131, 142, 140, 127, 32, 216, 136, 93, 86, 50, 237, 224, 134, 229, 235, 50, 7, 54, 108, 187, 235, 223, 197, 69, 33, 51, 16, 173, 150, 57, 56, 7, 227, 180, 39, 115, 149, 27, 91, 75, 190, 159, 5, 210, 112, 36, 82, 84, 30, 106, 193, 253, 112, 173, 14, 43, 163, 177, 19, 119, 9, 104, 53, 157, 87, 137, 242, 8, 126, 57, 68, 159, 6, 223, 67, 0, 49, 52, 133, 108, 128, 70, 10, 133, 221, 152, 25, 192, 83, 97, 216, 163, 244, 179, 125, 8, 55, 140, 159, 122, 44, 215, 101, 249, 215, 91, 144, 19, 157, 34, 188, 102, 215, 133, 168, 99, 58, 156, 92, 25, 198, 33, 55, 118, 20, 201, 49 } });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "BodyType", "VehicleRegistrationNumber" },
                values: new object[,]
                {
                    { new Guid("5270f5bb-8b24-403c-b07b-e159790338e5"), "Truck", "KDE 228S" },
                    { new Guid("637163c1-7932-40e6-ad55-73d029dfebef"), "Truck", "KCY 067A" },
                    { new Guid("775674af-d695-49c7-892f-a89268d85fb2"), "Van", "KBF 462A" },
                    { new Guid("86ef5f8d-63d3-4a7a-86cc-002285820480"), "Truck", "KCZ 595L" },
                    { new Guid("9af095f2-0de7-488a-9713-e24fadd3d236"), "Truck", "KDL 085M" },
                    { new Guid("9df93c1f-a4d5-49ca-beaf-d9b4ecdba0ea"), "Van", "KAY 215H" },
                    { new Guid("fa2e3509-3e94-4fe9-bc3c-6ac67c765842"), "Truck", "KDB 387Q" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("2a87f19e-6abe-4362-8b3c-9b80cada14a5"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("3115713e-47b1-40df-b2f1-2bd183db049d"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("3b8594e7-6e51-4ea0-b4b0-7442e31a59bd"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("3e743c05-1633-4d04-b397-91f2c808283b"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("5381a657-df45-4ff7-b3b3-7c44cff4b2d2"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("631e7fc5-d479-4a96-a75b-111474f40355"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("8e77c7dc-22ef-4354-9d4e-76f00086e1f9"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("ad28edbc-1284-4f80-bba1-fde97a2690bc"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("b4bcf540-5d37-4169-99d4-5208f818d6ca"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("c9c1a449-0eaf-438b-8eec-49805045627b"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("5270f5bb-8b24-403c-b07b-e159790338e5"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("637163c1-7932-40e6-ad55-73d029dfebef"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("775674af-d695-49c7-892f-a89268d85fb2"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("86ef5f8d-63d3-4a7a-86cc-002285820480"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("9af095f2-0de7-488a-9713-e24fadd3d236"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("9df93c1f-a4d5-49ca-beaf-d9b4ecdba0ea"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("fa2e3509-3e94-4fe9-bc3c-6ac67c765842"));

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "FirstName", "Initials", "LastName", "LicenseNumber" },
                values: new object[,]
                {
                    { new Guid("08e90668-85b6-45ba-865b-ed743f2f64e4"), "David", "DM", "Mwangi", "DL123456" },
                    { new Guid("1dc008cf-fc46-451b-8f39-cff71ec87b1a"), "Erastus", "EK", "Kagwa", "DL123456" },
                    { new Guid("2c0338fa-e582-472f-a16f-e0c2de69e981"), "Charles", "CM", "Maina", "DL123456" },
                    { new Guid("7ad9819f-bf32-47f8-bc98-95cf0b98b7ab"), "Stephen", "SK", "Kimuyu", "DL123456" },
                    { new Guid("8a9c2192-a003-40d5-a0bc-1db28f28f457"), "David", "DK", "Kibet", "DL123456" },
                    { new Guid("959ee432-01ca-44e6-9f6e-47c20ad94696"), "John", "JN", "Njuguna", "DL123456" },
                    { new Guid("c07addfc-e484-470a-8695-302f036c1e66"), "John", "JM", "Mwai", "DL123456" },
                    { new Guid("c670f8bf-6a20-41f4-9017-29f6442c0039"), "Julius", "JK", "Kamula", "DL123456" },
                    { new Guid("c933fec7-8bb8-46c7-809e-fbdd8e4666c1"), "Robert", "RN", "Njuguna", "DL123456" },
                    { new Guid("efacc2fa-2c4d-4341-9d86-fe2ba3029c3c"), "James", "JG", "Gichohi", "DL123456" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 226, 161, 32, 188, 233, 57, 172, 124, 216, 144, 51, 44, 115, 237, 96, 15, 116, 232, 7, 204, 28, 118, 127, 182, 18, 201, 131, 17, 85, 65, 80, 97, 76, 7, 89, 120, 205, 250, 103, 239, 198, 234, 39, 92, 115, 241, 80, 109, 92, 138, 230, 31, 249, 109, 22, 5, 11, 164, 135, 222, 140, 217, 138, 116 }, new byte[] { 135, 111, 41, 139, 122, 39, 184, 234, 109, 91, 219, 161, 164, 84, 201, 93, 216, 75, 23, 55, 142, 45, 250, 96, 149, 42, 24, 31, 240, 10, 193, 106, 118, 44, 6, 225, 15, 24, 206, 71, 58, 161, 14, 236, 33, 38, 235, 234, 135, 184, 120, 71, 190, 26, 152, 253, 35, 235, 53, 245, 10, 157, 165, 244, 163, 184, 136, 138, 247, 140, 69, 75, 171, 183, 60, 250, 201, 186, 132, 162, 57, 39, 74, 135, 26, 84, 62, 100, 136, 55, 58, 21, 203, 115, 118, 145, 235, 5, 115, 16, 67, 185, 187, 112, 48, 235, 38, 68, 29, 2, 4, 72, 14, 194, 182, 111, 166, 225, 196, 151, 57, 220, 194, 102, 49, 168, 242, 246 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 226, 161, 32, 188, 233, 57, 172, 124, 216, 144, 51, 44, 115, 237, 96, 15, 116, 232, 7, 204, 28, 118, 127, 182, 18, 201, 131, 17, 85, 65, 80, 97, 76, 7, 89, 120, 205, 250, 103, 239, 198, 234, 39, 92, 115, 241, 80, 109, 92, 138, 230, 31, 249, 109, 22, 5, 11, 164, 135, 222, 140, 217, 138, 116 }, new byte[] { 135, 111, 41, 139, 122, 39, 184, 234, 109, 91, 219, 161, 164, 84, 201, 93, 216, 75, 23, 55, 142, 45, 250, 96, 149, 42, 24, 31, 240, 10, 193, 106, 118, 44, 6, 225, 15, 24, 206, 71, 58, 161, 14, 236, 33, 38, 235, 234, 135, 184, 120, 71, 190, 26, 152, 253, 35, 235, 53, 245, 10, 157, 165, 244, 163, 184, 136, 138, 247, 140, 69, 75, 171, 183, 60, 250, 201, 186, 132, 162, 57, 39, 74, 135, 26, 84, 62, 100, 136, 55, 58, 21, 203, 115, 118, 145, 235, 5, 115, 16, 67, 185, 187, 112, 48, 235, 38, 68, 29, 2, 4, 72, 14, 194, 182, 111, 166, 225, 196, 151, 57, 220, 194, 102, 49, 168, 242, 246 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 226, 161, 32, 188, 233, 57, 172, 124, 216, 144, 51, 44, 115, 237, 96, 15, 116, 232, 7, 204, 28, 118, 127, 182, 18, 201, 131, 17, 85, 65, 80, 97, 76, 7, 89, 120, 205, 250, 103, 239, 198, 234, 39, 92, 115, 241, 80, 109, 92, 138, 230, 31, 249, 109, 22, 5, 11, 164, 135, 222, 140, 217, 138, 116 }, new byte[] { 135, 111, 41, 139, 122, 39, 184, 234, 109, 91, 219, 161, 164, 84, 201, 93, 216, 75, 23, 55, 142, 45, 250, 96, 149, 42, 24, 31, 240, 10, 193, 106, 118, 44, 6, 225, 15, 24, 206, 71, 58, 161, 14, 236, 33, 38, 235, 234, 135, 184, 120, 71, 190, 26, 152, 253, 35, 235, 53, 245, 10, 157, 165, 244, 163, 184, 136, 138, 247, 140, 69, 75, 171, 183, 60, 250, 201, 186, 132, 162, 57, 39, 74, 135, 26, 84, 62, 100, 136, 55, 58, 21, 203, 115, 118, 145, 235, 5, 115, 16, 67, 185, 187, 112, 48, 235, 38, 68, 29, 2, 4, 72, 14, 194, 182, 111, 166, 225, 196, 151, 57, 220, 194, 102, 49, 168, 242, 246 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 226, 161, 32, 188, 233, 57, 172, 124, 216, 144, 51, 44, 115, 237, 96, 15, 116, 232, 7, 204, 28, 118, 127, 182, 18, 201, 131, 17, 85, 65, 80, 97, 76, 7, 89, 120, 205, 250, 103, 239, 198, 234, 39, 92, 115, 241, 80, 109, 92, 138, 230, 31, 249, 109, 22, 5, 11, 164, 135, 222, 140, 217, 138, 116 }, new byte[] { 135, 111, 41, 139, 122, 39, 184, 234, 109, 91, 219, 161, 164, 84, 201, 93, 216, 75, 23, 55, 142, 45, 250, 96, 149, 42, 24, 31, 240, 10, 193, 106, 118, 44, 6, 225, 15, 24, 206, 71, 58, 161, 14, 236, 33, 38, 235, 234, 135, 184, 120, 71, 190, 26, 152, 253, 35, 235, 53, 245, 10, 157, 165, 244, 163, 184, 136, 138, 247, 140, 69, 75, 171, 183, 60, 250, 201, 186, 132, 162, 57, 39, 74, 135, 26, 84, 62, 100, 136, 55, 58, 21, 203, 115, 118, 145, 235, 5, 115, 16, 67, 185, 187, 112, 48, 235, 38, 68, 29, 2, 4, 72, 14, 194, 182, 111, 166, 225, 196, 151, 57, 220, 194, 102, 49, 168, 242, 246 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 226, 161, 32, 188, 233, 57, 172, 124, 216, 144, 51, 44, 115, 237, 96, 15, 116, 232, 7, 204, 28, 118, 127, 182, 18, 201, 131, 17, 85, 65, 80, 97, 76, 7, 89, 120, 205, 250, 103, 239, 198, 234, 39, 92, 115, 241, 80, 109, 92, 138, 230, 31, 249, 109, 22, 5, 11, 164, 135, 222, 140, 217, 138, 116 }, new byte[] { 135, 111, 41, 139, 122, 39, 184, 234, 109, 91, 219, 161, 164, 84, 201, 93, 216, 75, 23, 55, 142, 45, 250, 96, 149, 42, 24, 31, 240, 10, 193, 106, 118, 44, 6, 225, 15, 24, 206, 71, 58, 161, 14, 236, 33, 38, 235, 234, 135, 184, 120, 71, 190, 26, 152, 253, 35, 235, 53, 245, 10, 157, 165, 244, 163, 184, 136, 138, 247, 140, 69, 75, 171, 183, 60, 250, 201, 186, 132, 162, 57, 39, 74, 135, 26, 84, 62, 100, 136, 55, 58, 21, 203, 115, 118, 145, 235, 5, 115, 16, 67, 185, 187, 112, 48, 235, 38, 68, 29, 2, 4, 72, 14, 194, 182, 111, 166, 225, 196, 151, 57, 220, 194, 102, 49, 168, 242, 246 } });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "BodyType", "VehicleRegistrationNumber" },
                values: new object[,]
                {
                    { new Guid("0b94c9d5-df9d-41dc-ba92-f62ed52a2b96"), "Truck", "KDL 085M" },
                    { new Guid("396910ce-a6ef-4bfe-b393-5e3dd5a768ef"), "Truck", "KDB 387Q" },
                    { new Guid("75fbd0b6-fd66-4414-9d3c-6ece6155275d"), "Van", "KAY 215H" },
                    { new Guid("7ae1dd12-9c99-4f83-8ef6-2bf81c38b973"), "Van", "KBF 462A" },
                    { new Guid("7cc435ca-a76e-4b35-a93c-382c75123cd1"), "Truck", "KCY 067A" },
                    { new Guid("87b8da42-5c25-43a6-8468-201c99d6dcd8"), "Truck", "KDE 228S" },
                    { new Guid("b65329e2-f910-4951-83f5-24688aa3a4ee"), "Truck", "KCZ 595L" }
                });
        }
    }
}
