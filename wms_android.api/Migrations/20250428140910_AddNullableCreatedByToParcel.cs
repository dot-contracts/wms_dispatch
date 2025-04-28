using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace wms_android.api.Migrations
{
    /// <inheritdoc />
    public partial class AddNullableCreatedByToParcel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "Parcels",
                type: "integer",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Parcels_CreatedById",
                table: "Parcels",
                column: "CreatedById");

            migrationBuilder.AddForeignKey(
                name: "FK_Parcels_Users_CreatedById",
                table: "Parcels",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Parcels_Users_CreatedById",
                table: "Parcels");

            migrationBuilder.DropIndex(
                name: "IX_Parcels_CreatedById",
                table: "Parcels");

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

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Parcels");

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
    }
}
