using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace wms_android.api.Migrations
{
    /// <inheritdoc />
    public partial class AddShipmentsAndModifyParcels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Parcels_WaybillNumber",
                table: "Parcels");

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

            migrationBuilder.AddColumn<Guid>(
                name: "ShipmentId",
                table: "Parcels",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Shipments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    WaybillNumber = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<int>(type: "integer", nullable: true),
                    CreatorLastNameSnapshot = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shipments_Users_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.Sql(@"
DO $$
DECLARE
    parcel_record RECORD;
    shipment_guid uuid;
BEGIN
    -- Loop through distinct non-null WaybillNumbers from existing Parcels
    FOR parcel_record IN
        SELECT
            p.""WaybillNumber"",
            MIN(p.""Id"") as ""FirstParcelId"", -- To get a representative parcel for CreatedAt, CreatedById etc.
            MIN(p.""CreatedAt"") as ""MinCreatedAt"",
            (SELECT ""CreatedById"" FROM ""Parcels"" WHERE ""Id"" = MIN(p.""Id"")) as ""ParcelCreatedById"",
            (SELECT ""CreatorLastNameSnapshot"" FROM ""Parcels"" WHERE ""Id"" = MIN(p.""Id"")) as ""ParcelCreatorLastNameSnapshot""
        FROM ""Parcels"" p
        WHERE p.""WaybillNumber"" IS NOT NULL AND p.""WaybillNumber"" <> ''
        GROUP BY p.""WaybillNumber""
    LOOP
        -- Generate a new GUID for the Shipment
        shipment_guid := gen_random_uuid(); -- PostgreSQL function to generate a UUID

        -- Insert a new Shipment record
        INSERT INTO ""Shipments"" (""Id"", ""WaybillNumber"", ""CreatedAt"", ""CreatedById"", ""CreatorLastNameSnapshot"")
        VALUES (
            shipment_guid,
            parcel_record.""WaybillNumber"",
            COALESCE(parcel_record.""MinCreatedAt"", NOW()), -- Use parcel's CreatedAt, fallback to NOW()
            parcel_record.""ParcelCreatedById"",
            COALESCE(parcel_record.""ParcelCreatorLastNameSnapshot"", '') -- Fallback to empty string if null
        );

        -- Update all Parcels that have this WaybillNumber to link to the new Shipment
        UPDATE ""Parcels""
        SET ""ShipmentId"" = shipment_guid
        WHERE ""WaybillNumber"" = parcel_record.""WaybillNumber"";
    END LOOP;
END $$;
");

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

            migrationBuilder.CreateIndex(
                name: "IX_Parcels_ShipmentId",
                table: "Parcels",
                column: "ShipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Shipments_CreatedById",
                table: "Shipments",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Shipments_WaybillNumber",
                table: "Shipments",
                column: "WaybillNumber",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Parcels_Shipments_ShipmentId",
                table: "Parcels",
                column: "ShipmentId",
                principalTable: "Shipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Parcels_Shipments_ShipmentId",
                table: "Parcels");

            migrationBuilder.DropTable(
                name: "Shipments");

            migrationBuilder.DropIndex(
                name: "IX_Parcels_ShipmentId",
                table: "Parcels");

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

            migrationBuilder.DropColumn(
                name: "ShipmentId",
                table: "Parcels");

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
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 131, 60, 88, 220, 185, 43, 159, 26, 54, 36, 234, 150, 104, 195, 190, 7, 50, 158, 91, 15, 183, 224, 147, 33, 172, 228, 224, 232, 133, 37, 250, 76, 126, 162, 211, 26, 28, 74, 151, 206, 160, 193, 233, 89, 179, 41, 153, 189, 249, 123, 38, 110, 142, 23, 21, 107, 145, 200, 8, 17, 46, 154, 83, 7 }, new byte[] { 32, 156, 66, 222, 115, 31, 141, 246, 95, 125, 185, 108, 14, 176, 11, 211, 4, 221, 8, 54, 201, 13, 21, 15, 76, 246, 137, 28, 87, 184, 118, 145, 166, 192, 143, 28, 131, 185, 249, 225, 236, 89, 90, 143, 92, 187, 2, 13, 40, 237, 141, 197, 33, 28, 181, 94, 239, 44, 186, 148, 229, 200, 18, 106, 56, 163, 51, 190, 82, 161, 65, 168, 177, 74, 234, 151, 39, 2, 50, 137, 102, 216, 200, 193, 234, 98, 153, 37, 221, 11, 44, 226, 107, 86, 102, 184, 77, 226, 59, 176, 243, 32, 37, 100, 193, 177, 220, 64, 180, 55, 10, 38, 255, 224, 45, 127, 181, 127, 27, 137, 103, 158, 220, 214, 149, 96, 190, 126 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 131, 60, 88, 220, 185, 43, 159, 26, 54, 36, 234, 150, 104, 195, 190, 7, 50, 158, 91, 15, 183, 224, 147, 33, 172, 228, 224, 232, 133, 37, 250, 76, 126, 162, 211, 26, 28, 74, 151, 206, 160, 193, 233, 89, 179, 41, 153, 189, 249, 123, 38, 110, 142, 23, 21, 107, 145, 200, 8, 17, 46, 154, 83, 7 }, new byte[] { 32, 156, 66, 222, 115, 31, 141, 246, 95, 125, 185, 108, 14, 176, 11, 211, 4, 221, 8, 54, 201, 13, 21, 15, 76, 246, 137, 28, 87, 184, 118, 145, 166, 192, 143, 28, 131, 185, 249, 225, 236, 89, 90, 143, 92, 187, 2, 13, 40, 237, 141, 197, 33, 28, 181, 94, 239, 44, 186, 148, 229, 200, 18, 106, 56, 163, 51, 190, 82, 161, 65, 168, 177, 74, 234, 151, 39, 2, 50, 137, 102, 216, 200, 193, 234, 98, 153, 37, 221, 11, 44, 226, 107, 86, 102, 184, 77, 226, 59, 176, 243, 32, 37, 100, 193, 177, 220, 64, 180, 55, 10, 38, 255, 224, 45, 127, 181, 127, 27, 137, 103, 158, 220, 214, 149, 96, 190, 126 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 131, 60, 88, 220, 185, 43, 159, 26, 54, 36, 234, 150, 104, 195, 190, 7, 50, 158, 91, 15, 183, 224, 147, 33, 172, 228, 224, 232, 133, 37, 250, 76, 126, 162, 211, 26, 28, 74, 151, 206, 160, 193, 233, 89, 179, 41, 153, 189, 249, 123, 38, 110, 142, 23, 21, 107, 145, 200, 8, 17, 46, 154, 83, 7 }, new byte[] { 32, 156, 66, 222, 115, 31, 141, 246, 95, 125, 185, 108, 14, 176, 11, 211, 4, 221, 8, 54, 201, 13, 21, 15, 76, 246, 137, 28, 87, 184, 118, 145, 166, 192, 143, 28, 131, 185, 249, 225, 236, 89, 90, 143, 92, 187, 2, 13, 40, 237, 141, 197, 33, 28, 181, 94, 239, 44, 186, 148, 229, 200, 18, 106, 56, 163, 51, 190, 82, 161, 65, 168, 177, 74, 234, 151, 39, 2, 50, 137, 102, 216, 200, 193, 234, 98, 153, 37, 221, 11, 44, 226, 107, 86, 102, 184, 77, 226, 59, 176, 243, 32, 37, 100, 193, 177, 220, 64, 180, 55, 10, 38, 255, 224, 45, 127, 181, 127, 27, 137, 103, 158, 220, 214, 149, 96, 190, 126 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 131, 60, 88, 220, 185, 43, 159, 26, 54, 36, 234, 150, 104, 195, 190, 7, 50, 158, 91, 15, 183, 224, 147, 33, 172, 228, 224, 232, 133, 37, 250, 76, 126, 162, 211, 26, 28, 74, 151, 206, 160, 193, 233, 89, 179, 41, 153, 189, 249, 123, 38, 110, 142, 23, 21, 107, 145, 200, 8, 17, 46, 154, 83, 7 }, new byte[] { 32, 156, 66, 222, 115, 31, 141, 246, 95, 125, 185, 108, 14, 176, 11, 211, 4, 221, 8, 54, 201, 13, 21, 15, 76, 246, 137, 28, 87, 184, 118, 145, 166, 192, 143, 28, 131, 185, 249, 225, 236, 89, 90, 143, 92, 187, 2, 13, 40, 237, 141, 197, 33, 28, 181, 94, 239, 44, 186, 148, 229, 200, 18, 106, 56, 163, 51, 190, 82, 161, 65, 168, 177, 74, 234, 151, 39, 2, 50, 137, 102, 216, 200, 193, 234, 98, 153, 37, 221, 11, 44, 226, 107, 86, 102, 184, 77, 226, 59, 176, 243, 32, 37, 100, 193, 177, 220, 64, 180, 55, 10, 38, 255, 224, 45, 127, 181, 127, 27, 137, 103, 158, 220, 214, 149, 96, 190, 126 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 131, 60, 88, 220, 185, 43, 159, 26, 54, 36, 234, 150, 104, 195, 190, 7, 50, 158, 91, 15, 183, 224, 147, 33, 172, 228, 224, 232, 133, 37, 250, 76, 126, 162, 211, 26, 28, 74, 151, 206, 160, 193, 233, 89, 179, 41, 153, 189, 249, 123, 38, 110, 142, 23, 21, 107, 145, 200, 8, 17, 46, 154, 83, 7 }, new byte[] { 32, 156, 66, 222, 115, 31, 141, 246, 95, 125, 185, 108, 14, 176, 11, 211, 4, 221, 8, 54, 201, 13, 21, 15, 76, 246, 137, 28, 87, 184, 118, 145, 166, 192, 143, 28, 131, 185, 249, 225, 236, 89, 90, 143, 92, 187, 2, 13, 40, 237, 141, 197, 33, 28, 181, 94, 239, 44, 186, 148, 229, 200, 18, 106, 56, 163, 51, 190, 82, 161, 65, 168, 177, 74, 234, 151, 39, 2, 50, 137, 102, 216, 200, 193, 234, 98, 153, 37, 221, 11, 44, 226, 107, 86, 102, 184, 77, 226, 59, 176, 243, 32, 37, 100, 193, 177, 220, 64, 180, 55, 10, 38, 255, 224, 45, 127, 181, 127, 27, 137, 103, 158, 220, 214, 149, 96, 190, 126 } });

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

            migrationBuilder.CreateIndex(
                name: "IX_Parcels_WaybillNumber",
                table: "Parcels",
                column: "WaybillNumber",
                unique: true);
        }
    }
}
