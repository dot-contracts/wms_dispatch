using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace wms_android.api.Migrations
{
    /// <inheritdoc />
    public partial class RemovePasswordFromUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Users");

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

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "RoleId", "Username" },
                values: new object[] { 6, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), "client2@example.com", "Client", "UserTwo", new byte[] { 152, 188, 5, 135, 85, 137, 91, 2, 182, 239, 133, 18, 174, 200, 95, 163, 10, 22, 99, 65, 140, 254, 218, 160, 49, 196, 67, 235, 129, 16, 179, 191, 154, 188, 75, 100, 251, 222, 189, 40, 146, 244, 85, 61, 171, 110, 60, 251, 68, 111, 163, 98, 17, 3, 84, 99, 187, 222, 79, 209, 104, 97, 32, 129 }, new byte[] { 209, 152, 30, 185, 239, 33, 78, 228, 44, 89, 57, 13, 8, 54, 75, 120, 235, 236, 214, 219, 221, 40, 226, 143, 97, 194, 37, 90, 204, 63, 45, 43, 238, 93, 163, 81, 250, 134, 37, 97, 156, 69, 40, 7, 173, 253, 241, 196, 205, 64, 100, 245, 220, 152, 38, 220, 114, 144, 169, 194, 105, 246, 211, 14, 199, 65, 9, 206, 177, 125, 218, 30, 30, 42, 172, 62, 93, 170, 82, 125, 229, 95, 45, 126, 229, 239, 150, 253, 126, 87, 64, 51, 42, 63, 38, 143, 117, 137, 77, 128, 214, 203, 202, 149, 30, 70, 243, 66, 252, 77, 132, 29, 143, 137, 67, 0, 148, 147, 248, 37, 64, 149, 231, 135, 254, 181, 182, 180 }, 4, "client2" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

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

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "");

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
                columns: new[] { "Password", "PasswordHash", "PasswordSalt" },
                values: new object[] { "admin123", new byte[] { 111, 184, 52, 230, 226, 98, 103, 181, 50, 246, 238, 148, 231, 137, 217, 190, 130, 254, 188, 178, 135, 68, 57, 200, 167, 28, 207, 115, 220, 184, 82, 245, 101, 23, 61, 251, 95, 127, 215, 93, 215, 229, 156, 150, 13, 49, 90, 252, 197, 126, 229, 44, 175, 68, 238, 62, 52, 154, 110, 14, 180, 51, 253, 174 }, new byte[] { 253, 46, 24, 198, 146, 144, 201, 128, 219, 31, 74, 118, 19, 236, 144, 140, 211, 78, 108, 125, 142, 207, 198, 230, 73, 103, 67, 56, 133, 224, 138, 108, 128, 5, 89, 32, 28, 39, 41, 219, 171, 79, 20, 85, 197, 115, 171, 48, 84, 184, 167, 130, 72, 56, 7, 197, 233, 188, 155, 62, 75, 222, 168, 26, 248, 64, 102, 27, 182, 110, 168, 222, 73, 185, 140, 2, 50, 61, 175, 203, 69, 46, 75, 49, 213, 59, 230, 81, 132, 121, 228, 253, 0, 100, 14, 82, 25, 87, 18, 98, 161, 4, 147, 118, 25, 103, 130, 161, 52, 202, 122, 180, 64, 159, 78, 127, 19, 178, 163, 201, 6, 205, 186, 144, 155, 79, 3, 132 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Password", "PasswordHash", "PasswordSalt" },
                values: new object[] { "manager123", new byte[] { 111, 184, 52, 230, 226, 98, 103, 181, 50, 246, 238, 148, 231, 137, 217, 190, 130, 254, 188, 178, 135, 68, 57, 200, 167, 28, 207, 115, 220, 184, 82, 245, 101, 23, 61, 251, 95, 127, 215, 93, 215, 229, 156, 150, 13, 49, 90, 252, 197, 126, 229, 44, 175, 68, 238, 62, 52, 154, 110, 14, 180, 51, 253, 174 }, new byte[] { 253, 46, 24, 198, 146, 144, 201, 128, 219, 31, 74, 118, 19, 236, 144, 140, 211, 78, 108, 125, 142, 207, 198, 230, 73, 103, 67, 56, 133, 224, 138, 108, 128, 5, 89, 32, 28, 39, 41, 219, 171, 79, 20, 85, 197, 115, 171, 48, 84, 184, 167, 130, 72, 56, 7, 197, 233, 188, 155, 62, 75, 222, 168, 26, 248, 64, 102, 27, 182, 110, 168, 222, 73, 185, 140, 2, 50, 61, 175, 203, 69, 46, 75, 49, 213, 59, 230, 81, 132, 121, 228, 253, 0, 100, 14, 82, 25, 87, 18, 98, 161, 4, 147, 118, 25, 103, 130, 161, 52, 202, 122, 180, 64, 159, 78, 127, 19, 178, 163, 201, 6, 205, 186, 144, 155, 79, 3, 132 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Password", "PasswordHash", "PasswordSalt" },
                values: new object[] { "clerk123", new byte[] { 111, 184, 52, 230, 226, 98, 103, 181, 50, 246, 238, 148, 231, 137, 217, 190, 130, 254, 188, 178, 135, 68, 57, 200, 167, 28, 207, 115, 220, 184, 82, 245, 101, 23, 61, 251, 95, 127, 215, 93, 215, 229, 156, 150, 13, 49, 90, 252, 197, 126, 229, 44, 175, 68, 238, 62, 52, 154, 110, 14, 180, 51, 253, 174 }, new byte[] { 253, 46, 24, 198, 146, 144, 201, 128, 219, 31, 74, 118, 19, 236, 144, 140, 211, 78, 108, 125, 142, 207, 198, 230, 73, 103, 67, 56, 133, 224, 138, 108, 128, 5, 89, 32, 28, 39, 41, 219, 171, 79, 20, 85, 197, 115, 171, 48, 84, 184, 167, 130, 72, 56, 7, 197, 233, 188, 155, 62, 75, 222, 168, 26, 248, 64, 102, 27, 182, 110, 168, 222, 73, 185, 140, 2, 50, 61, 175, 203, 69, 46, 75, 49, 213, 59, 230, 81, 132, 121, 228, 253, 0, 100, 14, 82, 25, 87, 18, 98, 161, 4, 147, 118, 25, 103, 130, 161, 52, 202, 122, 180, 64, 159, 78, 127, 19, 178, 163, 201, 6, 205, 186, 144, 155, 79, 3, 132 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Password", "PasswordHash", "PasswordSalt" },
                values: new object[] { "clerk123", new byte[] { 111, 184, 52, 230, 226, 98, 103, 181, 50, 246, 238, 148, 231, 137, 217, 190, 130, 254, 188, 178, 135, 68, 57, 200, 167, 28, 207, 115, 220, 184, 82, 245, 101, 23, 61, 251, 95, 127, 215, 93, 215, 229, 156, 150, 13, 49, 90, 252, 197, 126, 229, 44, 175, 68, 238, 62, 52, 154, 110, 14, 180, 51, 253, 174 }, new byte[] { 253, 46, 24, 198, 146, 144, 201, 128, 219, 31, 74, 118, 19, 236, 144, 140, 211, 78, 108, 125, 142, 207, 198, 230, 73, 103, 67, 56, 133, 224, 138, 108, 128, 5, 89, 32, 28, 39, 41, 219, 171, 79, 20, 85, 197, 115, 171, 48, 84, 184, 167, 130, 72, 56, 7, 197, 233, 188, 155, 62, 75, 222, 168, 26, 248, 64, 102, 27, 182, 110, 168, 222, 73, 185, 140, 2, 50, 61, 175, 203, 69, 46, 75, 49, 213, 59, 230, 81, 132, 121, 228, 253, 0, 100, 14, 82, 25, 87, 18, 98, 161, 4, 147, 118, 25, 103, 130, 161, 52, 202, 122, 180, 64, 159, 78, 127, 19, 178, 163, 201, 6, 205, 186, 144, 155, 79, 3, 132 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Password", "PasswordHash", "PasswordSalt" },
                values: new object[] { "client123", new byte[] { 111, 184, 52, 230, 226, 98, 103, 181, 50, 246, 238, 148, 231, 137, 217, 190, 130, 254, 188, 178, 135, 68, 57, 200, 167, 28, 207, 115, 220, 184, 82, 245, 101, 23, 61, 251, 95, 127, 215, 93, 215, 229, 156, 150, 13, 49, 90, 252, 197, 126, 229, 44, 175, 68, 238, 62, 52, 154, 110, 14, 180, 51, 253, 174 }, new byte[] { 253, 46, 24, 198, 146, 144, 201, 128, 219, 31, 74, 118, 19, 236, 144, 140, 211, 78, 108, 125, 142, 207, 198, 230, 73, 103, 67, 56, 133, 224, 138, 108, 128, 5, 89, 32, 28, 39, 41, 219, 171, 79, 20, 85, 197, 115, 171, 48, 84, 184, 167, 130, 72, 56, 7, 197, 233, 188, 155, 62, 75, 222, 168, 26, 248, 64, 102, 27, 182, 110, 168, 222, 73, 185, 140, 2, 50, 61, 175, 203, 69, 46, 75, 49, 213, 59, 230, 81, 132, 121, 228, 253, 0, 100, 14, 82, 25, 87, 18, 98, 161, 4, 147, 118, 25, 103, 130, 161, 52, 202, 122, 180, 64, 159, 78, 127, 19, 178, 163, 201, 6, 205, 186, 144, 155, 79, 3, 132 } });

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
        }
    }
}
