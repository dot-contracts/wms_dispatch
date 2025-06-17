using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace wms_android.api.Migrations
{
    /// <inheritdoc />
    public partial class AddSignatureFields : Migration
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

            migrationBuilder.AddColumn<byte[]>(
                name: "SignatureData",
                table: "Parcels",
                type: "bytea",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SignedAt",
                table: "Parcels",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SignedBy",
                table: "Parcels",
                type: "text",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "FirstName", "Initials", "LastName", "LicenseNumber" },
                values: new object[,]
                {
                    { new Guid("08f30c52-fce3-4d36-8d14-60f9bb2f29eb"), "David", "DK", "Kibet", "DL123456" },
                    { new Guid("1703899c-3339-4237-ac00-68c0dc1af3d3"), "Robert", "RN", "Njuguna", "DL123456" },
                    { new Guid("2af6c867-47aa-4c45-b9ff-3123a2272525"), "David", "DM", "Mwangi", "DL123456" },
                    { new Guid("37a24eaa-a469-426f-9315-d007a3bdd44f"), "Julius", "JK", "Kamula", "DL123456" },
                    { new Guid("3a6a547b-f9b5-4acf-958c-a3851edd32b2"), "John", "JM", "Mwai", "DL123456" },
                    { new Guid("418474ee-3bf5-4c3b-a04a-966221a023fc"), "John", "JN", "Njuguna", "DL123456" },
                    { new Guid("7f843575-59fe-4678-a1d8-6ce1c6ff551c"), "Erastus", "EK", "Kagwa", "DL123456" },
                    { new Guid("952f64e8-52c2-4989-aead-9a3ca2998e16"), "Charles", "CM", "Maina", "DL123456" },
                    { new Guid("9aaa1015-f26d-4998-9c22-18fb8154617c"), "James", "JG", "Gichohi", "DL123456" },
                    { new Guid("b4e6b39e-ebd1-491f-b776-f88a11bea251"), "Stephen", "SK", "Kimuyu", "DL123456" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 253, 130, 67, 97, 248, 180, 135, 189, 204, 239, 60, 153, 75, 67, 255, 73, 149, 79, 145, 157, 158, 172, 214, 69, 151, 136, 191, 222, 61, 160, 19, 233, 43, 169, 6, 238, 68, 226, 131, 92, 236, 165, 155, 229, 0, 178, 165, 250, 33, 115, 186, 160, 254, 235, 109, 133, 71, 103, 6, 191, 253, 135, 130, 223 }, new byte[] { 160, 65, 122, 174, 12, 109, 237, 116, 121, 236, 252, 59, 59, 157, 94, 42, 80, 193, 152, 60, 10, 167, 164, 252, 100, 76, 42, 57, 36, 195, 232, 120, 68, 213, 180, 219, 103, 248, 166, 211, 56, 145, 227, 45, 101, 23, 118, 189, 101, 244, 2, 229, 2, 230, 80, 152, 141, 237, 145, 74, 205, 177, 151, 158, 241, 214, 116, 133, 202, 140, 12, 89, 177, 215, 219, 223, 40, 202, 139, 80, 207, 232, 160, 109, 14, 118, 161, 79, 23, 50, 159, 72, 43, 220, 131, 40, 82, 244, 76, 50, 146, 244, 104, 182, 69, 48, 79, 203, 246, 70, 185, 9, 52, 134, 102, 247, 241, 86, 33, 156, 85, 90, 207, 219, 170, 55, 206, 7 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 253, 130, 67, 97, 248, 180, 135, 189, 204, 239, 60, 153, 75, 67, 255, 73, 149, 79, 145, 157, 158, 172, 214, 69, 151, 136, 191, 222, 61, 160, 19, 233, 43, 169, 6, 238, 68, 226, 131, 92, 236, 165, 155, 229, 0, 178, 165, 250, 33, 115, 186, 160, 254, 235, 109, 133, 71, 103, 6, 191, 253, 135, 130, 223 }, new byte[] { 160, 65, 122, 174, 12, 109, 237, 116, 121, 236, 252, 59, 59, 157, 94, 42, 80, 193, 152, 60, 10, 167, 164, 252, 100, 76, 42, 57, 36, 195, 232, 120, 68, 213, 180, 219, 103, 248, 166, 211, 56, 145, 227, 45, 101, 23, 118, 189, 101, 244, 2, 229, 2, 230, 80, 152, 141, 237, 145, 74, 205, 177, 151, 158, 241, 214, 116, 133, 202, 140, 12, 89, 177, 215, 219, 223, 40, 202, 139, 80, 207, 232, 160, 109, 14, 118, 161, 79, 23, 50, 159, 72, 43, 220, 131, 40, 82, 244, 76, 50, 146, 244, 104, 182, 69, 48, 79, 203, 246, 70, 185, 9, 52, 134, 102, 247, 241, 86, 33, 156, 85, 90, 207, 219, 170, 55, 206, 7 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 253, 130, 67, 97, 248, 180, 135, 189, 204, 239, 60, 153, 75, 67, 255, 73, 149, 79, 145, 157, 158, 172, 214, 69, 151, 136, 191, 222, 61, 160, 19, 233, 43, 169, 6, 238, 68, 226, 131, 92, 236, 165, 155, 229, 0, 178, 165, 250, 33, 115, 186, 160, 254, 235, 109, 133, 71, 103, 6, 191, 253, 135, 130, 223 }, new byte[] { 160, 65, 122, 174, 12, 109, 237, 116, 121, 236, 252, 59, 59, 157, 94, 42, 80, 193, 152, 60, 10, 167, 164, 252, 100, 76, 42, 57, 36, 195, 232, 120, 68, 213, 180, 219, 103, 248, 166, 211, 56, 145, 227, 45, 101, 23, 118, 189, 101, 244, 2, 229, 2, 230, 80, 152, 141, 237, 145, 74, 205, 177, 151, 158, 241, 214, 116, 133, 202, 140, 12, 89, 177, 215, 219, 223, 40, 202, 139, 80, 207, 232, 160, 109, 14, 118, 161, 79, 23, 50, 159, 72, 43, 220, 131, 40, 82, 244, 76, 50, 146, 244, 104, 182, 69, 48, 79, 203, 246, 70, 185, 9, 52, 134, 102, 247, 241, 86, 33, 156, 85, 90, 207, 219, 170, 55, 206, 7 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 253, 130, 67, 97, 248, 180, 135, 189, 204, 239, 60, 153, 75, 67, 255, 73, 149, 79, 145, 157, 158, 172, 214, 69, 151, 136, 191, 222, 61, 160, 19, 233, 43, 169, 6, 238, 68, 226, 131, 92, 236, 165, 155, 229, 0, 178, 165, 250, 33, 115, 186, 160, 254, 235, 109, 133, 71, 103, 6, 191, 253, 135, 130, 223 }, new byte[] { 160, 65, 122, 174, 12, 109, 237, 116, 121, 236, 252, 59, 59, 157, 94, 42, 80, 193, 152, 60, 10, 167, 164, 252, 100, 76, 42, 57, 36, 195, 232, 120, 68, 213, 180, 219, 103, 248, 166, 211, 56, 145, 227, 45, 101, 23, 118, 189, 101, 244, 2, 229, 2, 230, 80, 152, 141, 237, 145, 74, 205, 177, 151, 158, 241, 214, 116, 133, 202, 140, 12, 89, 177, 215, 219, 223, 40, 202, 139, 80, 207, 232, 160, 109, 14, 118, 161, 79, 23, 50, 159, 72, 43, 220, 131, 40, 82, 244, 76, 50, 146, 244, 104, 182, 69, 48, 79, 203, 246, 70, 185, 9, 52, 134, 102, 247, 241, 86, 33, 156, 85, 90, 207, 219, 170, 55, 206, 7 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 253, 130, 67, 97, 248, 180, 135, 189, 204, 239, 60, 153, 75, 67, 255, 73, 149, 79, 145, 157, 158, 172, 214, 69, 151, 136, 191, 222, 61, 160, 19, 233, 43, 169, 6, 238, 68, 226, 131, 92, 236, 165, 155, 229, 0, 178, 165, 250, 33, 115, 186, 160, 254, 235, 109, 133, 71, 103, 6, 191, 253, 135, 130, 223 }, new byte[] { 160, 65, 122, 174, 12, 109, 237, 116, 121, 236, 252, 59, 59, 157, 94, 42, 80, 193, 152, 60, 10, 167, 164, 252, 100, 76, 42, 57, 36, 195, 232, 120, 68, 213, 180, 219, 103, 248, 166, 211, 56, 145, 227, 45, 101, 23, 118, 189, 101, 244, 2, 229, 2, 230, 80, 152, 141, 237, 145, 74, 205, 177, 151, 158, 241, 214, 116, 133, 202, 140, 12, 89, 177, 215, 219, 223, 40, 202, 139, 80, 207, 232, 160, 109, 14, 118, 161, 79, 23, 50, 159, 72, 43, 220, 131, 40, 82, 244, 76, 50, 146, 244, 104, 182, 69, 48, 79, 203, 246, 70, 185, 9, 52, 134, 102, 247, 241, 86, 33, 156, 85, 90, 207, 219, 170, 55, 206, 7 } });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "BodyType", "VehicleRegistrationNumber" },
                values: new object[,]
                {
                    { new Guid("40e21532-2c9e-45cb-93a6-b931f146ac96"), "Truck", "KDE 228S" },
                    { new Guid("53b77a6c-df19-4c26-8274-f69f7cf8b972"), "Truck", "KCY 067A" },
                    { new Guid("5598defb-323f-4983-932b-d71e1727db35"), "Truck", "KDL 085M" },
                    { new Guid("90a15e0d-a9b5-4801-a566-739a9d825b95"), "Van", "KAY 215H" },
                    { new Guid("98cdb920-5a7e-400d-a855-1e5823261265"), "Truck", "KDB 387Q" },
                    { new Guid("9b1f0174-fe92-43b1-85e8-3d9128d0e9ca"), "Truck", "KCZ 595L" },
                    { new Guid("d57c148a-f77b-4171-b3b3-8105bfac6ed1"), "Van", "KBF 462A" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("08f30c52-fce3-4d36-8d14-60f9bb2f29eb"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("1703899c-3339-4237-ac00-68c0dc1af3d3"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("2af6c867-47aa-4c45-b9ff-3123a2272525"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("37a24eaa-a469-426f-9315-d007a3bdd44f"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("3a6a547b-f9b5-4acf-958c-a3851edd32b2"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("418474ee-3bf5-4c3b-a04a-966221a023fc"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("7f843575-59fe-4678-a1d8-6ce1c6ff551c"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("952f64e8-52c2-4989-aead-9a3ca2998e16"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("9aaa1015-f26d-4998-9c22-18fb8154617c"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("b4e6b39e-ebd1-491f-b776-f88a11bea251"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("40e21532-2c9e-45cb-93a6-b931f146ac96"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("53b77a6c-df19-4c26-8274-f69f7cf8b972"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("5598defb-323f-4983-932b-d71e1727db35"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("90a15e0d-a9b5-4801-a566-739a9d825b95"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("98cdb920-5a7e-400d-a855-1e5823261265"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("9b1f0174-fe92-43b1-85e8-3d9128d0e9ca"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("d57c148a-f77b-4171-b3b3-8105bfac6ed1"));

            migrationBuilder.DropColumn(
                name: "SignatureData",
                table: "Parcels");

            migrationBuilder.DropColumn(
                name: "SignedAt",
                table: "Parcels");

            migrationBuilder.DropColumn(
                name: "SignedBy",
                table: "Parcels");

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
