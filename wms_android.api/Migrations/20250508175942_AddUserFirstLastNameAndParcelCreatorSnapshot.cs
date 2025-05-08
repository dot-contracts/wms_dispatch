using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace wms_android.api.Migrations
{
    /// <inheritdoc />
    public partial class AddUserFirstLastNameAndParcelCreatorSnapshot : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("38d55623-9cfd-47dc-a3c5-5a8201d4dc74"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("3deee9fc-df26-4a88-b057-1b481fb3b2b6"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("5711642f-839f-40f2-a503-a47237a68723"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("7e7b6721-7707-422e-bfc9-5ed326ae5df8"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("7feac365-2621-4628-9abe-927d082a1ffd"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("853a7091-8ce6-44da-8c86-6e4aebf5431a"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("ad5217fb-bbfd-4a78-b5fd-41b730c179c0"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("b5e02260-931d-429c-ac76-e296dc4f8173"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("b968efbd-9902-43cc-8d22-f7310928919e"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("d8aa286a-d1b2-42ec-888f-c6128dcbc1f8"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("1329677b-2da9-4447-80ef-b3f690a0f104"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("298f6d68-f82a-4c75-a633-ddda65544101"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("3a0d96cd-9d48-46f8-afd9-64dcf7d55696"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("91c167f1-0d1c-44e9-8ee0-c043668b69f0"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("a815f695-023b-4255-8fe6-be3c404b2f5f"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("c314bca0-212d-4ad7-a03a-fda881255b98"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("f04e7d37-2a2c-4549-a575-f794053489c9"));

            migrationBuilder.AddColumn<string>(
                name: "CreatorLastNameSnapshot",
                table: "Parcels",
                type: "text",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "FirstName", "Initials", "LastName", "LicenseNumber" },
                values: new object[,]
                {
                    { new Guid("1dd704c8-d133-4bc2-9bfc-b7aff407904c"), "Stephen", "SK", "Kimuyu", "DL123456" },
                    { new Guid("4d0a2414-a4da-4ffe-a9cf-329e66a57df5"), "Erastus", "EK", "Kagwa", "DL123456" },
                    { new Guid("822298bc-c8cf-4675-83e4-da4998e7975f"), "John", "JN", "Njuguna", "DL123456" },
                    { new Guid("89098bfa-9dea-440a-b764-688b972b7550"), "David", "DM", "Mwangi", "DL123456" },
                    { new Guid("8b06943a-5870-4259-b2cd-17dabc1dc64b"), "James", "JG", "Gichohi", "DL123456" },
                    { new Guid("addb61f4-32b9-46f0-a45d-5881a0f95314"), "Robert", "RN", "Njuguna", "DL123456" },
                    { new Guid("c8c23b16-c816-407f-bd01-1db16391cff7"), "David", "DK", "Kibet", "DL123456" },
                    { new Guid("d0298b65-a910-4a93-a2cb-f2252567f0fd"), "Julius", "JK", "Kamula", "DL123456" },
                    { new Guid("e73d28d3-a820-4f2e-b71c-6a4a27fa9a43"), "Charles", "CM", "Maina", "DL123456" },
                    { new Guid("f6c14df9-a0f8-44e0-b818-8bc0bc92bf05"), "John", "JM", "Mwai", "DL123456" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FirstName", "LastName", "PasswordHash", "PasswordSalt" },
                values: new object[] { "Admin", "User", new byte[] { 131, 60, 88, 220, 185, 43, 159, 26, 54, 36, 234, 150, 104, 195, 190, 7, 50, 158, 91, 15, 183, 224, 147, 33, 172, 228, 224, 232, 133, 37, 250, 76, 126, 162, 211, 26, 28, 74, 151, 206, 160, 193, 233, 89, 179, 41, 153, 189, 249, 123, 38, 110, 142, 23, 21, 107, 145, 200, 8, 17, 46, 154, 83, 7 }, new byte[] { 32, 156, 66, 222, 115, 31, 141, 246, 95, 125, 185, 108, 14, 176, 11, 211, 4, 221, 8, 54, 201, 13, 21, 15, 76, 246, 137, 28, 87, 184, 118, 145, 166, 192, 143, 28, 131, 185, 249, 225, 236, 89, 90, 143, 92, 187, 2, 13, 40, 237, 141, 197, 33, 28, 181, 94, 239, 44, 186, 148, 229, 200, 18, 106, 56, 163, 51, 190, 82, 161, 65, 168, 177, 74, 234, 151, 39, 2, 50, 137, 102, 216, 200, 193, 234, 98, 153, 37, 221, 11, 44, 226, 107, 86, 102, 184, 77, 226, 59, 176, 243, 32, 37, 100, 193, 177, 220, 64, 180, 55, 10, 38, 255, 224, 45, 127, 181, 127, 27, 137, 103, 158, 220, 214, 149, 96, 190, 126 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FirstName", "LastName", "PasswordHash", "PasswordSalt" },
                values: new object[] { "Manager", "Person", new byte[] { 131, 60, 88, 220, 185, 43, 159, 26, 54, 36, 234, 150, 104, 195, 190, 7, 50, 158, 91, 15, 183, 224, 147, 33, 172, 228, 224, 232, 133, 37, 250, 76, 126, 162, 211, 26, 28, 74, 151, 206, 160, 193, 233, 89, 179, 41, 153, 189, 249, 123, 38, 110, 142, 23, 21, 107, 145, 200, 8, 17, 46, 154, 83, 7 }, new byte[] { 32, 156, 66, 222, 115, 31, 141, 246, 95, 125, 185, 108, 14, 176, 11, 211, 4, 221, 8, 54, 201, 13, 21, 15, 76, 246, 137, 28, 87, 184, 118, 145, 166, 192, 143, 28, 131, 185, 249, 225, 236, 89, 90, 143, 92, 187, 2, 13, 40, 237, 141, 197, 33, 28, 181, 94, 239, 44, 186, 148, 229, 200, 18, 106, 56, 163, 51, 190, 82, 161, 65, 168, 177, 74, 234, 151, 39, 2, 50, 137, 102, 216, 200, 193, 234, 98, 153, 37, 221, 11, 44, 226, 107, 86, 102, 184, 77, 226, 59, 176, 243, 32, 37, 100, 193, 177, 220, 64, 180, 55, 10, 38, 255, 224, 45, 127, 181, 127, 27, 137, 103, 158, 220, 214, 149, 96, 190, 126 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FirstName", "LastName", "PasswordHash", "PasswordSalt" },
                values: new object[] { "Clerk", "One", new byte[] { 131, 60, 88, 220, 185, 43, 159, 26, 54, 36, 234, 150, 104, 195, 190, 7, 50, 158, 91, 15, 183, 224, 147, 33, 172, 228, 224, 232, 133, 37, 250, 76, 126, 162, 211, 26, 28, 74, 151, 206, 160, 193, 233, 89, 179, 41, 153, 189, 249, 123, 38, 110, 142, 23, 21, 107, 145, 200, 8, 17, 46, 154, 83, 7 }, new byte[] { 32, 156, 66, 222, 115, 31, 141, 246, 95, 125, 185, 108, 14, 176, 11, 211, 4, 221, 8, 54, 201, 13, 21, 15, 76, 246, 137, 28, 87, 184, 118, 145, 166, 192, 143, 28, 131, 185, 249, 225, 236, 89, 90, 143, 92, 187, 2, 13, 40, 237, 141, 197, 33, 28, 181, 94, 239, 44, 186, 148, 229, 200, 18, 106, 56, 163, 51, 190, 82, 161, 65, 168, 177, 74, 234, 151, 39, 2, 50, 137, 102, 216, 200, 193, 234, 98, 153, 37, 221, 11, 44, 226, 107, 86, 102, 184, 77, 226, 59, 176, 243, 32, 37, 100, 193, 177, 220, 64, 180, 55, 10, 38, 255, 224, 45, 127, 181, 127, 27, 137, 103, 158, 220, 214, 149, 96, 190, 126 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FirstName", "LastName", "PasswordHash", "PasswordSalt" },
                values: new object[] { "Clerk", "Two", new byte[] { 131, 60, 88, 220, 185, 43, 159, 26, 54, 36, 234, 150, 104, 195, 190, 7, 50, 158, 91, 15, 183, 224, 147, 33, 172, 228, 224, 232, 133, 37, 250, 76, 126, 162, 211, 26, 28, 74, 151, 206, 160, 193, 233, 89, 179, 41, 153, 189, 249, 123, 38, 110, 142, 23, 21, 107, 145, 200, 8, 17, 46, 154, 83, 7 }, new byte[] { 32, 156, 66, 222, 115, 31, 141, 246, 95, 125, 185, 108, 14, 176, 11, 211, 4, 221, 8, 54, 201, 13, 21, 15, 76, 246, 137, 28, 87, 184, 118, 145, 166, 192, 143, 28, 131, 185, 249, 225, 236, 89, 90, 143, 92, 187, 2, 13, 40, 237, 141, 197, 33, 28, 181, 94, 239, 44, 186, 148, 229, 200, 18, 106, 56, 163, 51, 190, 82, 161, 65, 168, 177, 74, 234, 151, 39, 2, 50, 137, 102, 216, 200, 193, 234, 98, 153, 37, 221, 11, 44, 226, 107, 86, 102, 184, 77, 226, 59, 176, 243, 32, 37, 100, 193, 177, 220, 64, 180, 55, 10, 38, 255, 224, 45, 127, 181, 127, 27, 137, 103, 158, 220, 214, 149, 96, 190, 126 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FirstName", "LastName", "PasswordHash", "PasswordSalt" },
                values: new object[] { "Client", "UserOne", new byte[] { 131, 60, 88, 220, 185, 43, 159, 26, 54, 36, 234, 150, 104, 195, 190, 7, 50, 158, 91, 15, 183, 224, 147, 33, 172, 228, 224, 232, 133, 37, 250, 76, 126, 162, 211, 26, 28, 74, 151, 206, 160, 193, 233, 89, 179, 41, 153, 189, 249, 123, 38, 110, 142, 23, 21, 107, 145, 200, 8, 17, 46, 154, 83, 7 }, new byte[] { 32, 156, 66, 222, 115, 31, 141, 246, 95, 125, 185, 108, 14, 176, 11, 211, 4, 221, 8, 54, 201, 13, 21, 15, 76, 246, 137, 28, 87, 184, 118, 145, 166, 192, 143, 28, 131, 185, 249, 225, 236, 89, 90, 143, 92, 187, 2, 13, 40, 237, 141, 197, 33, 28, 181, 94, 239, 44, 186, 148, 229, 200, 18, 106, 56, 163, 51, 190, 82, 161, 65, 168, 177, 74, 234, 151, 39, 2, 50, 137, 102, 216, 200, 193, 234, 98, 153, 37, 221, 11, 44, 226, 107, 86, 102, 184, 77, 226, 59, 176, 243, 32, 37, 100, 193, 177, 220, 64, 180, 55, 10, 38, 255, 224, 45, 127, 181, 127, 27, 137, 103, 158, 220, 214, 149, 96, 190, 126 } });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "BodyType", "VehicleRegistrationNumber" },
                values: new object[,]
                {
                    { new Guid("27eca24b-b238-40e4-af2b-0e014b5da9d0"), "Truck", "KDL 085M" },
                    { new Guid("87545ff0-1528-4ec0-bec1-5a8286e6e2d8"), "Truck", "KCZ 595L" },
                    { new Guid("b1a730a9-e76d-45bd-bf4b-50549af6349d"), "Truck", "KCY 067A" },
                    { new Guid("c08cd63b-eff6-4962-aa05-2262249cbd52"), "Van", "KBF 462A" },
                    { new Guid("d6f36e1a-e68f-416f-9aee-01c2bca70a5d"), "Truck", "KDE 228S" },
                    { new Guid("d8726f1a-63ca-445f-9ba5-c2faba5af19d"), "Truck", "KDB 387Q" },
                    { new Guid("dd206699-c0d2-4573-b8fc-70adeff1912e"), "Van", "KAY 215H" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("1dd704c8-d133-4bc2-9bfc-b7aff407904c"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("4d0a2414-a4da-4ffe-a9cf-329e66a57df5"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("822298bc-c8cf-4675-83e4-da4998e7975f"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("89098bfa-9dea-440a-b764-688b972b7550"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("8b06943a-5870-4259-b2cd-17dabc1dc64b"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("addb61f4-32b9-46f0-a45d-5881a0f95314"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("c8c23b16-c816-407f-bd01-1db16391cff7"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("d0298b65-a910-4a93-a2cb-f2252567f0fd"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("e73d28d3-a820-4f2e-b71c-6a4a27fa9a43"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("f6c14df9-a0f8-44e0-b818-8bc0bc92bf05"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("27eca24b-b238-40e4-af2b-0e014b5da9d0"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("87545ff0-1528-4ec0-bec1-5a8286e6e2d8"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("b1a730a9-e76d-45bd-bf4b-50549af6349d"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("c08cd63b-eff6-4962-aa05-2262249cbd52"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("d6f36e1a-e68f-416f-9aee-01c2bca70a5d"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("d8726f1a-63ca-445f-9ba5-c2faba5af19d"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("dd206699-c0d2-4573-b8fc-70adeff1912e"));

            migrationBuilder.DropColumn(
                name: "CreatorLastNameSnapshot",
                table: "Parcels");

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "FirstName", "Initials", "LastName", "LicenseNumber" },
                values: new object[,]
                {
                    { new Guid("38d55623-9cfd-47dc-a3c5-5a8201d4dc74"), "Charles", "CM", "Maina", "DL123456" },
                    { new Guid("3deee9fc-df26-4a88-b057-1b481fb3b2b6"), "James", "JG", "Gichohi", "DL123456" },
                    { new Guid("5711642f-839f-40f2-a503-a47237a68723"), "Erastus", "EK", "Kagwa", "DL123456" },
                    { new Guid("7e7b6721-7707-422e-bfc9-5ed326ae5df8"), "John", "JN", "Njuguna", "DL123456" },
                    { new Guid("7feac365-2621-4628-9abe-927d082a1ffd"), "David", "DM", "Mwangi", "DL123456" },
                    { new Guid("853a7091-8ce6-44da-8c86-6e4aebf5431a"), "Stephen", "SK", "Kimuyu", "DL123456" },
                    { new Guid("ad5217fb-bbfd-4a78-b5fd-41b730c179c0"), "David", "DK", "Kibet", "DL123456" },
                    { new Guid("b5e02260-931d-429c-ac76-e296dc4f8173"), "Julius", "JK", "Kamula", "DL123456" },
                    { new Guid("b968efbd-9902-43cc-8d22-f7310928919e"), "Robert", "RN", "Njuguna", "DL123456" },
                    { new Guid("d8aa286a-d1b2-42ec-888f-c6128dcbc1f8"), "John", "JM", "Mwai", "DL123456" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 69, 230, 100, 239, 55, 150, 58, 102, 159, 201, 20, 20, 242, 15, 16, 93, 169, 24, 34, 254, 254, 140, 98, 212, 213, 107, 12, 76, 138, 30, 232, 165, 209, 104, 181, 218, 157, 78, 167, 22, 221, 109, 73, 4, 198, 124, 208, 68, 53, 70, 93, 38, 34, 25, 169, 90, 81, 93, 19, 66, 6, 181, 34, 100 }, new byte[] { 30, 190, 111, 218, 166, 160, 114, 170, 152, 237, 22, 48, 14, 110, 190, 221, 194, 188, 96, 158, 249, 255, 117, 222, 12, 86, 182, 169, 151, 224, 101, 28, 247, 172, 16, 152, 141, 240, 105, 112, 228, 129, 229, 116, 207, 50, 123, 233, 128, 51, 88, 235, 228, 218, 91, 37, 182, 189, 82, 2, 73, 186, 60, 11, 35, 187, 128, 79, 228, 211, 63, 71, 106, 123, 61, 151, 5, 139, 18, 10, 139, 20, 67, 32, 57, 164, 70, 82, 83, 36, 35, 39, 93, 154, 2, 100, 253, 179, 187, 222, 151, 212, 105, 68, 237, 93, 58, 189, 142, 132, 59, 106, 154, 228, 30, 255, 250, 199, 249, 75, 251, 241, 217, 49, 55, 205, 187, 231 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 69, 230, 100, 239, 55, 150, 58, 102, 159, 201, 20, 20, 242, 15, 16, 93, 169, 24, 34, 254, 254, 140, 98, 212, 213, 107, 12, 76, 138, 30, 232, 165, 209, 104, 181, 218, 157, 78, 167, 22, 221, 109, 73, 4, 198, 124, 208, 68, 53, 70, 93, 38, 34, 25, 169, 90, 81, 93, 19, 66, 6, 181, 34, 100 }, new byte[] { 30, 190, 111, 218, 166, 160, 114, 170, 152, 237, 22, 48, 14, 110, 190, 221, 194, 188, 96, 158, 249, 255, 117, 222, 12, 86, 182, 169, 151, 224, 101, 28, 247, 172, 16, 152, 141, 240, 105, 112, 228, 129, 229, 116, 207, 50, 123, 233, 128, 51, 88, 235, 228, 218, 91, 37, 182, 189, 82, 2, 73, 186, 60, 11, 35, 187, 128, 79, 228, 211, 63, 71, 106, 123, 61, 151, 5, 139, 18, 10, 139, 20, 67, 32, 57, 164, 70, 82, 83, 36, 35, 39, 93, 154, 2, 100, 253, 179, 187, 222, 151, 212, 105, 68, 237, 93, 58, 189, 142, 132, 59, 106, 154, 228, 30, 255, 250, 199, 249, 75, 251, 241, 217, 49, 55, 205, 187, 231 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 69, 230, 100, 239, 55, 150, 58, 102, 159, 201, 20, 20, 242, 15, 16, 93, 169, 24, 34, 254, 254, 140, 98, 212, 213, 107, 12, 76, 138, 30, 232, 165, 209, 104, 181, 218, 157, 78, 167, 22, 221, 109, 73, 4, 198, 124, 208, 68, 53, 70, 93, 38, 34, 25, 169, 90, 81, 93, 19, 66, 6, 181, 34, 100 }, new byte[] { 30, 190, 111, 218, 166, 160, 114, 170, 152, 237, 22, 48, 14, 110, 190, 221, 194, 188, 96, 158, 249, 255, 117, 222, 12, 86, 182, 169, 151, 224, 101, 28, 247, 172, 16, 152, 141, 240, 105, 112, 228, 129, 229, 116, 207, 50, 123, 233, 128, 51, 88, 235, 228, 218, 91, 37, 182, 189, 82, 2, 73, 186, 60, 11, 35, 187, 128, 79, 228, 211, 63, 71, 106, 123, 61, 151, 5, 139, 18, 10, 139, 20, 67, 32, 57, 164, 70, 82, 83, 36, 35, 39, 93, 154, 2, 100, 253, 179, 187, 222, 151, 212, 105, 68, 237, 93, 58, 189, 142, 132, 59, 106, 154, 228, 30, 255, 250, 199, 249, 75, 251, 241, 217, 49, 55, 205, 187, 231 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 69, 230, 100, 239, 55, 150, 58, 102, 159, 201, 20, 20, 242, 15, 16, 93, 169, 24, 34, 254, 254, 140, 98, 212, 213, 107, 12, 76, 138, 30, 232, 165, 209, 104, 181, 218, 157, 78, 167, 22, 221, 109, 73, 4, 198, 124, 208, 68, 53, 70, 93, 38, 34, 25, 169, 90, 81, 93, 19, 66, 6, 181, 34, 100 }, new byte[] { 30, 190, 111, 218, 166, 160, 114, 170, 152, 237, 22, 48, 14, 110, 190, 221, 194, 188, 96, 158, 249, 255, 117, 222, 12, 86, 182, 169, 151, 224, 101, 28, 247, 172, 16, 152, 141, 240, 105, 112, 228, 129, 229, 116, 207, 50, 123, 233, 128, 51, 88, 235, 228, 218, 91, 37, 182, 189, 82, 2, 73, 186, 60, 11, 35, 187, 128, 79, 228, 211, 63, 71, 106, 123, 61, 151, 5, 139, 18, 10, 139, 20, 67, 32, 57, 164, 70, 82, 83, 36, 35, 39, 93, 154, 2, 100, 253, 179, 187, 222, 151, 212, 105, 68, 237, 93, 58, 189, 142, 132, 59, 106, 154, 228, 30, 255, 250, 199, 249, 75, 251, 241, 217, 49, 55, 205, 187, 231 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 69, 230, 100, 239, 55, 150, 58, 102, 159, 201, 20, 20, 242, 15, 16, 93, 169, 24, 34, 254, 254, 140, 98, 212, 213, 107, 12, 76, 138, 30, 232, 165, 209, 104, 181, 218, 157, 78, 167, 22, 221, 109, 73, 4, 198, 124, 208, 68, 53, 70, 93, 38, 34, 25, 169, 90, 81, 93, 19, 66, 6, 181, 34, 100 }, new byte[] { 30, 190, 111, 218, 166, 160, 114, 170, 152, 237, 22, 48, 14, 110, 190, 221, 194, 188, 96, 158, 249, 255, 117, 222, 12, 86, 182, 169, 151, 224, 101, 28, 247, 172, 16, 152, 141, 240, 105, 112, 228, 129, 229, 116, 207, 50, 123, 233, 128, 51, 88, 235, 228, 218, 91, 37, 182, 189, 82, 2, 73, 186, 60, 11, 35, 187, 128, 79, 228, 211, 63, 71, 106, 123, 61, 151, 5, 139, 18, 10, 139, 20, 67, 32, 57, 164, 70, 82, 83, 36, 35, 39, 93, 154, 2, 100, 253, 179, 187, 222, 151, 212, 105, 68, 237, 93, 58, 189, 142, 132, 59, 106, 154, 228, 30, 255, 250, 199, 249, 75, 251, 241, 217, 49, 55, 205, 187, 231 } });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "BodyType", "VehicleRegistrationNumber" },
                values: new object[,]
                {
                    { new Guid("1329677b-2da9-4447-80ef-b3f690a0f104"), "Truck", "KDE 228S" },
                    { new Guid("298f6d68-f82a-4c75-a633-ddda65544101"), "Truck", "KDL 085M" },
                    { new Guid("3a0d96cd-9d48-46f8-afd9-64dcf7d55696"), "Truck", "KCY 067A" },
                    { new Guid("91c167f1-0d1c-44e9-8ee0-c043668b69f0"), "Van", "KBF 462A" },
                    { new Guid("a815f695-023b-4255-8fe6-be3c404b2f5f"), "Van", "KAY 215H" },
                    { new Guid("c314bca0-212d-4ad7-a03a-fda881255b98"), "Truck", "KDB 387Q" },
                    { new Guid("f04e7d37-2a2c-4549-a575-f794053489c9"), "Truck", "KCZ 595L" }
                });
        }
    }
}
