using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace wms_android.api.Migrations
{
    /// <inheritdoc />
    public partial class AddDispatchEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("20b9dfef-45eb-48e7-9f3b-07cee66f868e"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("22e78582-439e-465b-b4d1-7f414292eb24"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("2511e814-4063-4478-88f9-7da32c9f7ca3"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("69a35cf9-098d-45a6-b3a3-212ac085f929"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("7ecf2b05-e862-4b17-b578-edacbf8d8326"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("80e98a59-21fa-48e8-bf36-ee9b46e7da46"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("b63afd9e-8f71-4ad1-b4b5-8e44e97a9b61"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("c023b85f-4897-4371-9739-6d2483979fee"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("cb982c97-a909-4145-8e11-e876a1071ae6"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("f2c46c47-e51b-4349-b927-7eca87cc7fa8"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("2f4af14d-8c84-4aab-a948-f7f538d6a1b0"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("33437df3-7124-48e1-888f-88d4602d19bd"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("3d8de8f8-bfcc-4ec2-a21c-0129c4e7773c"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("6d36865b-0adf-45bf-be5b-fa45b85dd81c"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("8da310e7-8317-48a0-9d87-52644cd2fbf7"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("bc446d65-a005-4652-990f-8323b56a153f"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("e3c54906-12cd-4a3c-b158-92d3ff781ab8"));

            migrationBuilder.CreateTable(
                name: "Dispatches",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SourceBranch = table.Column<string>(type: "text", nullable: false),
                    VehicleNumber = table.Column<string>(type: "text", nullable: false),
                    Driver = table.Column<string>(type: "text", nullable: false),
                    ParcelIds = table.Column<List<Guid>>(type: "uuid[]", nullable: false),
                    DispatchTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dispatches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DispatchParcels",
                columns: table => new
                {
                    DispatchId = table.Column<Guid>(type: "uuid", nullable: false),
                    ParcelsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DispatchParcels", x => new { x.DispatchId, x.ParcelsId });
                    table.ForeignKey(
                        name: "FK_DispatchParcels_Dispatches_DispatchId",
                        column: x => x.DispatchId,
                        principalTable: "Dispatches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DispatchParcels_Parcels_ParcelsId",
                        column: x => x.ParcelsId,
                        principalTable: "Parcels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "FirstName", "Initials", "LastName", "LicenseNumber" },
                values: new object[,]
                {
                    { new Guid("020eb8b5-7841-44d9-8cf8-05371c553f4f"), "David", "DK", "Kibet", "DL123456" },
                    { new Guid("48e69376-4795-45e9-9b4a-071297c7ed56"), "Robert", "RN", "Njuguna", "DL123456" },
                    { new Guid("5203ada3-9073-433b-ba12-bf820244af84"), "Charles", "CM", "Maina", "DL123456" },
                    { new Guid("6cf40357-9e84-43c8-82bb-57190dc4f5ec"), "Erastus", "EK", "Kagwa", "DL123456" },
                    { new Guid("a12563db-9e91-40b5-a320-d0400171aade"), "James", "JG", "Gichohi", "DL123456" },
                    { new Guid("bf40d661-40c7-4fb2-ba16-d188ff8333ca"), "John", "JN", "Njuguna", "DL123456" },
                    { new Guid("cdd12685-0219-4bf6-8c02-43b3a701756e"), "Stephen", "SK", "Kimuyu", "DL123456" },
                    { new Guid("e4607dd9-5d99-4af2-89bf-6647e351100b"), "David", "DM", "Mwangi", "DL123456" },
                    { new Guid("e4c20650-2aa2-47c4-8f3d-6e243f7e681e"), "John", "JM", "Mwai", "DL123456" },
                    { new Guid("eae8214e-996d-47f8-bf96-228d2fb5cf8e"), "Julius", "JK", "Kamula", "DL123456" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 111, 184, 52, 230, 226, 98, 103, 181, 50, 246, 238, 148, 231, 137, 217, 190, 130, 254, 188, 178, 135, 68, 57, 200, 167, 28, 207, 115, 220, 184, 82, 245, 101, 23, 61, 251, 95, 127, 215, 93, 215, 229, 156, 150, 13, 49, 90, 252, 197, 126, 229, 44, 175, 68, 238, 62, 52, 154, 110, 14, 180, 51, 253, 174 }, new byte[] { 253, 46, 24, 198, 146, 144, 201, 128, 219, 31, 74, 118, 19, 236, 144, 140, 211, 78, 108, 125, 142, 207, 198, 230, 73, 103, 67, 56, 133, 224, 138, 108, 128, 5, 89, 32, 28, 39, 41, 219, 171, 79, 20, 85, 197, 115, 171, 48, 84, 184, 167, 130, 72, 56, 7, 197, 233, 188, 155, 62, 75, 222, 168, 26, 248, 64, 102, 27, 182, 110, 168, 222, 73, 185, 140, 2, 50, 61, 175, 203, 69, 46, 75, 49, 213, 59, 230, 81, 132, 121, 228, 253, 0, 100, 14, 82, 25, 87, 18, 98, 161, 4, 147, 118, 25, 103, 130, 161, 52, 202, 122, 180, 64, 159, 78, 127, 19, 178, 163, 201, 6, 205, 186, 144, 155, 79, 3, 132 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 111, 184, 52, 230, 226, 98, 103, 181, 50, 246, 238, 148, 231, 137, 217, 190, 130, 254, 188, 178, 135, 68, 57, 200, 167, 28, 207, 115, 220, 184, 82, 245, 101, 23, 61, 251, 95, 127, 215, 93, 215, 229, 156, 150, 13, 49, 90, 252, 197, 126, 229, 44, 175, 68, 238, 62, 52, 154, 110, 14, 180, 51, 253, 174 }, new byte[] { 253, 46, 24, 198, 146, 144, 201, 128, 219, 31, 74, 118, 19, 236, 144, 140, 211, 78, 108, 125, 142, 207, 198, 230, 73, 103, 67, 56, 133, 224, 138, 108, 128, 5, 89, 32, 28, 39, 41, 219, 171, 79, 20, 85, 197, 115, 171, 48, 84, 184, 167, 130, 72, 56, 7, 197, 233, 188, 155, 62, 75, 222, 168, 26, 248, 64, 102, 27, 182, 110, 168, 222, 73, 185, 140, 2, 50, 61, 175, 203, 69, 46, 75, 49, 213, 59, 230, 81, 132, 121, 228, 253, 0, 100, 14, 82, 25, 87, 18, 98, 161, 4, 147, 118, 25, 103, 130, 161, 52, 202, 122, 180, 64, 159, 78, 127, 19, 178, 163, 201, 6, 205, 186, 144, 155, 79, 3, 132 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 111, 184, 52, 230, 226, 98, 103, 181, 50, 246, 238, 148, 231, 137, 217, 190, 130, 254, 188, 178, 135, 68, 57, 200, 167, 28, 207, 115, 220, 184, 82, 245, 101, 23, 61, 251, 95, 127, 215, 93, 215, 229, 156, 150, 13, 49, 90, 252, 197, 126, 229, 44, 175, 68, 238, 62, 52, 154, 110, 14, 180, 51, 253, 174 }, new byte[] { 253, 46, 24, 198, 146, 144, 201, 128, 219, 31, 74, 118, 19, 236, 144, 140, 211, 78, 108, 125, 142, 207, 198, 230, 73, 103, 67, 56, 133, 224, 138, 108, 128, 5, 89, 32, 28, 39, 41, 219, 171, 79, 20, 85, 197, 115, 171, 48, 84, 184, 167, 130, 72, 56, 7, 197, 233, 188, 155, 62, 75, 222, 168, 26, 248, 64, 102, 27, 182, 110, 168, 222, 73, 185, 140, 2, 50, 61, 175, 203, 69, 46, 75, 49, 213, 59, 230, 81, 132, 121, 228, 253, 0, 100, 14, 82, 25, 87, 18, 98, 161, 4, 147, 118, 25, 103, 130, 161, 52, 202, 122, 180, 64, 159, 78, 127, 19, 178, 163, 201, 6, 205, 186, 144, 155, 79, 3, 132 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 111, 184, 52, 230, 226, 98, 103, 181, 50, 246, 238, 148, 231, 137, 217, 190, 130, 254, 188, 178, 135, 68, 57, 200, 167, 28, 207, 115, 220, 184, 82, 245, 101, 23, 61, 251, 95, 127, 215, 93, 215, 229, 156, 150, 13, 49, 90, 252, 197, 126, 229, 44, 175, 68, 238, 62, 52, 154, 110, 14, 180, 51, 253, 174 }, new byte[] { 253, 46, 24, 198, 146, 144, 201, 128, 219, 31, 74, 118, 19, 236, 144, 140, 211, 78, 108, 125, 142, 207, 198, 230, 73, 103, 67, 56, 133, 224, 138, 108, 128, 5, 89, 32, 28, 39, 41, 219, 171, 79, 20, 85, 197, 115, 171, 48, 84, 184, 167, 130, 72, 56, 7, 197, 233, 188, 155, 62, 75, 222, 168, 26, 248, 64, 102, 27, 182, 110, 168, 222, 73, 185, 140, 2, 50, 61, 175, 203, 69, 46, 75, 49, 213, 59, 230, 81, 132, 121, 228, 253, 0, 100, 14, 82, 25, 87, 18, 98, 161, 4, 147, 118, 25, 103, 130, 161, 52, 202, 122, 180, 64, 159, 78, 127, 19, 178, 163, 201, 6, 205, 186, 144, 155, 79, 3, 132 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 111, 184, 52, 230, 226, 98, 103, 181, 50, 246, 238, 148, 231, 137, 217, 190, 130, 254, 188, 178, 135, 68, 57, 200, 167, 28, 207, 115, 220, 184, 82, 245, 101, 23, 61, 251, 95, 127, 215, 93, 215, 229, 156, 150, 13, 49, 90, 252, 197, 126, 229, 44, 175, 68, 238, 62, 52, 154, 110, 14, 180, 51, 253, 174 }, new byte[] { 253, 46, 24, 198, 146, 144, 201, 128, 219, 31, 74, 118, 19, 236, 144, 140, 211, 78, 108, 125, 142, 207, 198, 230, 73, 103, 67, 56, 133, 224, 138, 108, 128, 5, 89, 32, 28, 39, 41, 219, 171, 79, 20, 85, 197, 115, 171, 48, 84, 184, 167, 130, 72, 56, 7, 197, 233, 188, 155, 62, 75, 222, 168, 26, 248, 64, 102, 27, 182, 110, 168, 222, 73, 185, 140, 2, 50, 61, 175, 203, 69, 46, 75, 49, 213, 59, 230, 81, 132, 121, 228, 253, 0, 100, 14, 82, 25, 87, 18, 98, 161, 4, 147, 118, 25, 103, 130, 161, 52, 202, 122, 180, 64, 159, 78, 127, 19, 178, 163, 201, 6, 205, 186, 144, 155, 79, 3, 132 } });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "BodyType", "VehicleRegistrationNumber" },
                values: new object[,]
                {
                    { new Guid("26a4ad68-7593-4ad4-b488-31a5c62b91f1"), "Truck", "KDL 085M" },
                    { new Guid("2eeb9755-3d80-488f-bc46-6447b7842067"), "Van", "KBF 462A" },
                    { new Guid("6c7d78f9-1356-462e-98f3-600853b098bc"), "Truck", "KDE 228S" },
                    { new Guid("90f1210e-2287-4eff-8d0a-e971e80f99c5"), "Truck", "KCY 067A" },
                    { new Guid("9925837f-e04b-4074-bdb6-6b55119bc528"), "Truck", "KDB 387Q" },
                    { new Guid("c5d38d75-d540-43b6-88ff-36a59159b4dc"), "Van", "KAY 215H" },
                    { new Guid("dceafa42-0d32-4cc1-906d-73347d61f05b"), "Truck", "KCZ 595L" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DispatchParcels_ParcelsId",
                table: "DispatchParcels",
                column: "ParcelsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DispatchParcels");

            migrationBuilder.DropTable(
                name: "Dispatches");

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("020eb8b5-7841-44d9-8cf8-05371c553f4f"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("48e69376-4795-45e9-9b4a-071297c7ed56"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("5203ada3-9073-433b-ba12-bf820244af84"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("6cf40357-9e84-43c8-82bb-57190dc4f5ec"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("a12563db-9e91-40b5-a320-d0400171aade"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("bf40d661-40c7-4fb2-ba16-d188ff8333ca"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("cdd12685-0219-4bf6-8c02-43b3a701756e"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("e4607dd9-5d99-4af2-89bf-6647e351100b"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("e4c20650-2aa2-47c4-8f3d-6e243f7e681e"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("eae8214e-996d-47f8-bf96-228d2fb5cf8e"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("26a4ad68-7593-4ad4-b488-31a5c62b91f1"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("2eeb9755-3d80-488f-bc46-6447b7842067"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("6c7d78f9-1356-462e-98f3-600853b098bc"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("90f1210e-2287-4eff-8d0a-e971e80f99c5"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("9925837f-e04b-4074-bdb6-6b55119bc528"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("c5d38d75-d540-43b6-88ff-36a59159b4dc"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("dceafa42-0d32-4cc1-906d-73347d61f05b"));

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "FirstName", "Initials", "LastName", "LicenseNumber" },
                values: new object[,]
                {
                    { new Guid("20b9dfef-45eb-48e7-9f3b-07cee66f868e"), "Charles", "CM", "Maina", "DL123456" },
                    { new Guid("22e78582-439e-465b-b4d1-7f414292eb24"), "John", "JN", "Njuguna", "DL123456" },
                    { new Guid("2511e814-4063-4478-88f9-7da32c9f7ca3"), "David", "DK", "Kibet", "DL123456" },
                    { new Guid("69a35cf9-098d-45a6-b3a3-212ac085f929"), "Robert", "RN", "Njuguna", "DL123456" },
                    { new Guid("7ecf2b05-e862-4b17-b578-edacbf8d8326"), "Stephen", "SK", "Kimuyu", "DL123456" },
                    { new Guid("80e98a59-21fa-48e8-bf36-ee9b46e7da46"), "David", "DM", "Mwangi", "DL123456" },
                    { new Guid("b63afd9e-8f71-4ad1-b4b5-8e44e97a9b61"), "John", "JM", "Mwai", "DL123456" },
                    { new Guid("c023b85f-4897-4371-9739-6d2483979fee"), "James", "JG", "Gichohi", "DL123456" },
                    { new Guid("cb982c97-a909-4145-8e11-e876a1071ae6"), "Erastus", "EK", "Kagwa", "DL123456" },
                    { new Guid("f2c46c47-e51b-4349-b927-7eca87cc7fa8"), "Julius", "JK", "Kamula", "DL123456" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 67, 94, 201, 144, 214, 90, 1, 242, 42, 222, 153, 65, 87, 209, 56, 249, 250, 134, 97, 45, 103, 47, 51, 212, 172, 114, 19, 247, 111, 95, 18, 115, 113, 149, 27, 82, 30, 173, 38, 220, 81, 197, 68, 176, 19, 76, 58, 60, 138, 192, 219, 151, 223, 177, 205, 227, 96, 123, 240, 64, 239, 168, 196, 244 }, new byte[] { 140, 11, 19, 146, 77, 57, 164, 7, 220, 182, 123, 89, 3, 27, 76, 116, 6, 23, 150, 109, 130, 206, 72, 86, 143, 189, 85, 187, 124, 75, 178, 68, 64, 117, 154, 173, 40, 2, 124, 139, 236, 118, 61, 248, 108, 216, 201, 155, 83, 96, 107, 124, 164, 86, 116, 178, 255, 116, 143, 227, 106, 89, 170, 202, 97, 186, 43, 255, 58, 178, 237, 62, 189, 91, 45, 127, 251, 241, 14, 2, 32, 52, 185, 94, 181, 198, 165, 234, 229, 60, 80, 157, 127, 227, 86, 62, 71, 85, 55, 189, 35, 44, 221, 231, 13, 232, 204, 8, 186, 81, 113, 108, 131, 91, 61, 124, 70, 85, 79, 144, 160, 249, 37, 142, 95, 50, 117, 53 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 67, 94, 201, 144, 214, 90, 1, 242, 42, 222, 153, 65, 87, 209, 56, 249, 250, 134, 97, 45, 103, 47, 51, 212, 172, 114, 19, 247, 111, 95, 18, 115, 113, 149, 27, 82, 30, 173, 38, 220, 81, 197, 68, 176, 19, 76, 58, 60, 138, 192, 219, 151, 223, 177, 205, 227, 96, 123, 240, 64, 239, 168, 196, 244 }, new byte[] { 140, 11, 19, 146, 77, 57, 164, 7, 220, 182, 123, 89, 3, 27, 76, 116, 6, 23, 150, 109, 130, 206, 72, 86, 143, 189, 85, 187, 124, 75, 178, 68, 64, 117, 154, 173, 40, 2, 124, 139, 236, 118, 61, 248, 108, 216, 201, 155, 83, 96, 107, 124, 164, 86, 116, 178, 255, 116, 143, 227, 106, 89, 170, 202, 97, 186, 43, 255, 58, 178, 237, 62, 189, 91, 45, 127, 251, 241, 14, 2, 32, 52, 185, 94, 181, 198, 165, 234, 229, 60, 80, 157, 127, 227, 86, 62, 71, 85, 55, 189, 35, 44, 221, 231, 13, 232, 204, 8, 186, 81, 113, 108, 131, 91, 61, 124, 70, 85, 79, 144, 160, 249, 37, 142, 95, 50, 117, 53 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 67, 94, 201, 144, 214, 90, 1, 242, 42, 222, 153, 65, 87, 209, 56, 249, 250, 134, 97, 45, 103, 47, 51, 212, 172, 114, 19, 247, 111, 95, 18, 115, 113, 149, 27, 82, 30, 173, 38, 220, 81, 197, 68, 176, 19, 76, 58, 60, 138, 192, 219, 151, 223, 177, 205, 227, 96, 123, 240, 64, 239, 168, 196, 244 }, new byte[] { 140, 11, 19, 146, 77, 57, 164, 7, 220, 182, 123, 89, 3, 27, 76, 116, 6, 23, 150, 109, 130, 206, 72, 86, 143, 189, 85, 187, 124, 75, 178, 68, 64, 117, 154, 173, 40, 2, 124, 139, 236, 118, 61, 248, 108, 216, 201, 155, 83, 96, 107, 124, 164, 86, 116, 178, 255, 116, 143, 227, 106, 89, 170, 202, 97, 186, 43, 255, 58, 178, 237, 62, 189, 91, 45, 127, 251, 241, 14, 2, 32, 52, 185, 94, 181, 198, 165, 234, 229, 60, 80, 157, 127, 227, 86, 62, 71, 85, 55, 189, 35, 44, 221, 231, 13, 232, 204, 8, 186, 81, 113, 108, 131, 91, 61, 124, 70, 85, 79, 144, 160, 249, 37, 142, 95, 50, 117, 53 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 67, 94, 201, 144, 214, 90, 1, 242, 42, 222, 153, 65, 87, 209, 56, 249, 250, 134, 97, 45, 103, 47, 51, 212, 172, 114, 19, 247, 111, 95, 18, 115, 113, 149, 27, 82, 30, 173, 38, 220, 81, 197, 68, 176, 19, 76, 58, 60, 138, 192, 219, 151, 223, 177, 205, 227, 96, 123, 240, 64, 239, 168, 196, 244 }, new byte[] { 140, 11, 19, 146, 77, 57, 164, 7, 220, 182, 123, 89, 3, 27, 76, 116, 6, 23, 150, 109, 130, 206, 72, 86, 143, 189, 85, 187, 124, 75, 178, 68, 64, 117, 154, 173, 40, 2, 124, 139, 236, 118, 61, 248, 108, 216, 201, 155, 83, 96, 107, 124, 164, 86, 116, 178, 255, 116, 143, 227, 106, 89, 170, 202, 97, 186, 43, 255, 58, 178, 237, 62, 189, 91, 45, 127, 251, 241, 14, 2, 32, 52, 185, 94, 181, 198, 165, 234, 229, 60, 80, 157, 127, 227, 86, 62, 71, 85, 55, 189, 35, 44, 221, 231, 13, 232, 204, 8, 186, 81, 113, 108, 131, 91, 61, 124, 70, 85, 79, 144, 160, 249, 37, 142, 95, 50, 117, 53 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 67, 94, 201, 144, 214, 90, 1, 242, 42, 222, 153, 65, 87, 209, 56, 249, 250, 134, 97, 45, 103, 47, 51, 212, 172, 114, 19, 247, 111, 95, 18, 115, 113, 149, 27, 82, 30, 173, 38, 220, 81, 197, 68, 176, 19, 76, 58, 60, 138, 192, 219, 151, 223, 177, 205, 227, 96, 123, 240, 64, 239, 168, 196, 244 }, new byte[] { 140, 11, 19, 146, 77, 57, 164, 7, 220, 182, 123, 89, 3, 27, 76, 116, 6, 23, 150, 109, 130, 206, 72, 86, 143, 189, 85, 187, 124, 75, 178, 68, 64, 117, 154, 173, 40, 2, 124, 139, 236, 118, 61, 248, 108, 216, 201, 155, 83, 96, 107, 124, 164, 86, 116, 178, 255, 116, 143, 227, 106, 89, 170, 202, 97, 186, 43, 255, 58, 178, 237, 62, 189, 91, 45, 127, 251, 241, 14, 2, 32, 52, 185, 94, 181, 198, 165, 234, 229, 60, 80, 157, 127, 227, 86, 62, 71, 85, 55, 189, 35, 44, 221, 231, 13, 232, 204, 8, 186, 81, 113, 108, 131, 91, 61, 124, 70, 85, 79, 144, 160, 249, 37, 142, 95, 50, 117, 53 } });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "BodyType", "VehicleRegistrationNumber" },
                values: new object[,]
                {
                    { new Guid("2f4af14d-8c84-4aab-a948-f7f538d6a1b0"), "Van", "KBF 462A" },
                    { new Guid("33437df3-7124-48e1-888f-88d4602d19bd"), "Truck", "KDL 085M" },
                    { new Guid("3d8de8f8-bfcc-4ec2-a21c-0129c4e7773c"), "Van", "KAY 215H" },
                    { new Guid("6d36865b-0adf-45bf-be5b-fa45b85dd81c"), "Truck", "KCY 067A" },
                    { new Guid("8da310e7-8317-48a0-9d87-52644cd2fbf7"), "Truck", "KCZ 595L" },
                    { new Guid("bc446d65-a005-4652-990f-8323b56a153f"), "Truck", "KDB 387Q" },
                    { new Guid("e3c54906-12cd-4a3c-b158-92d3ff781ab8"), "Truck", "KDE 228S" }
                });
        }
    }
}
