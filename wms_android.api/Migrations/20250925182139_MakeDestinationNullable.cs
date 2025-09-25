using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace wms_android.api.Migrations
{
    /// <inheritdoc />
    public partial class MakeDestinationNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Branches_BranchId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "LoginSessions");

            migrationBuilder.DropTable(
                name: "UserActivities");

            migrationBuilder.DropTable(
                name: "Devices");

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("01b9d000-4b43-4257-8c79-4640178851f5"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("15178260-1f63-48b0-82d3-e6e327155011"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("2d77ed35-9aef-4a97-99ce-23108657cd5c"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("5165eeca-e40c-4b2d-8f55-0996266b52c8"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("6f12d8c2-b6e9-43fd-92ef-a2e890ad94f1"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("a5ef4aff-a37e-4cbf-a7bd-4747beac4b6b"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("a68fd189-500f-4cfd-bb16-2453480f78ee"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("bf900519-4688-4d9f-bd2e-a16c2fce87bf"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("cd68e9c0-9892-466e-af07-f4f5727338bb"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("d39ad8c8-0fe7-4155-9e64-9e6ac0b038f9"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("0abab865-83b8-4bb1-9cfe-1bdb2c2e30e9"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("5da5b147-aecb-442a-b9a7-0a5dea588453"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("66652716-1260-4654-a987-8070cb7d125d"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("83e1a859-e675-45f8-b5e0-ecd4cd1e8ab3"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("954e8dca-1a23-49a2-8af9-638cd10c4369"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("95c7cf16-43af-4917-ba92-64765d8791cf"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("b28b10f7-e3d1-4a1a-a3c4-67554a1b0538"));

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "Destination",
                table: "Dispatches",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Branches_BranchId",
                table: "Users",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Branches_BranchId",
                table: "Users");

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

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Users",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "Destination",
                table: "Dispatches",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AndroidVersion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    AppVersion = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    DeviceName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    DeviceType = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false, defaultValue: "android"),
                    FirstSeen = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    LastSeen = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Manufacturer = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Model = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    SerialNumber = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserActivities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    ActivityType = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Details = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    IpAddress = table.Column<string>(type: "character varying(45)", maxLength: 45, nullable: true),
                    Timestamp = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UserAgent = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserActivities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserActivities_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LoginSessions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DeviceId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    IpAddress = table.Column<string>(type: "character varying(45)", maxLength: 45, nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Location = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    LoginTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    LogoutTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    SessionId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserAgent = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginSessions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LoginSessions_Devices_DeviceId",
                        column: x => x.DeviceId,
                        principalTable: "Devices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LoginSessions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "FirstName", "Initials", "LastName", "LicenseNumber" },
                values: new object[,]
                {
                    { new Guid("01b9d000-4b43-4257-8c79-4640178851f5"), "David", "DK", "Kibet", "DL123456" },
                    { new Guid("15178260-1f63-48b0-82d3-e6e327155011"), "Erastus", "EK", "Kagwa", "DL123456" },
                    { new Guid("2d77ed35-9aef-4a97-99ce-23108657cd5c"), "Stephen", "SK", "Kimuyu", "DL123456" },
                    { new Guid("5165eeca-e40c-4b2d-8f55-0996266b52c8"), "John", "JN", "Njuguna", "DL123456" },
                    { new Guid("6f12d8c2-b6e9-43fd-92ef-a2e890ad94f1"), "Julius", "JK", "Kamula", "DL123456" },
                    { new Guid("a5ef4aff-a37e-4cbf-a7bd-4747beac4b6b"), "John", "JM", "Mwai", "DL123456" },
                    { new Guid("a68fd189-500f-4cfd-bb16-2453480f78ee"), "David", "DM", "Mwangi", "DL123456" },
                    { new Guid("bf900519-4688-4d9f-bd2e-a16c2fce87bf"), "Robert", "RN", "Njuguna", "DL123456" },
                    { new Guid("cd68e9c0-9892-466e-af07-f4f5727338bb"), "James", "JG", "Gichohi", "DL123456" },
                    { new Guid("d39ad8c8-0fe7-4155-9e64-9e6ac0b038f9"), "Charles", "CM", "Maina", "DL123456" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IsActive", "PasswordHash", "PasswordSalt" },
                values: new object[] { true, new byte[] { 61, 103, 201, 176, 82, 111, 235, 157, 22, 64, 150, 71, 239, 61, 157, 5, 88, 42, 0, 153, 251, 187, 141, 91, 15, 216, 127, 238, 117, 123, 128, 156, 167, 30, 211, 81, 196, 233, 36, 243, 222, 89, 150, 229, 255, 51, 224, 233, 65, 130, 39, 79, 157, 176, 118, 121, 155, 3, 65, 9, 165, 160, 47, 96 }, new byte[] { 187, 51, 194, 110, 248, 163, 214, 19, 57, 245, 36, 43, 204, 103, 220, 66, 43, 31, 230, 210, 10, 255, 165, 138, 71, 167, 20, 42, 31, 69, 64, 180, 81, 158, 86, 73, 195, 24, 62, 125, 54, 79, 143, 230, 137, 254, 108, 200, 219, 180, 47, 50, 123, 134, 112, 121, 191, 191, 113, 195, 179, 16, 144, 22, 235, 141, 47, 150, 28, 112, 200, 63, 30, 155, 132, 254, 209, 165, 117, 7, 69, 171, 161, 198, 12, 44, 11, 45, 52, 137, 119, 126, 247, 223, 245, 91, 168, 206, 194, 194, 20, 75, 179, 153, 144, 170, 17, 231, 124, 170, 145, 15, 201, 89, 23, 31, 53, 142, 191, 2, 144, 117, 248, 115, 6, 180, 195, 34 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IsActive", "PasswordHash", "PasswordSalt" },
                values: new object[] { true, new byte[] { 61, 103, 201, 176, 82, 111, 235, 157, 22, 64, 150, 71, 239, 61, 157, 5, 88, 42, 0, 153, 251, 187, 141, 91, 15, 216, 127, 238, 117, 123, 128, 156, 167, 30, 211, 81, 196, 233, 36, 243, 222, 89, 150, 229, 255, 51, 224, 233, 65, 130, 39, 79, 157, 176, 118, 121, 155, 3, 65, 9, 165, 160, 47, 96 }, new byte[] { 187, 51, 194, 110, 248, 163, 214, 19, 57, 245, 36, 43, 204, 103, 220, 66, 43, 31, 230, 210, 10, 255, 165, 138, 71, 167, 20, 42, 31, 69, 64, 180, 81, 158, 86, 73, 195, 24, 62, 125, 54, 79, 143, 230, 137, 254, 108, 200, 219, 180, 47, 50, 123, 134, 112, 121, 191, 191, 113, 195, 179, 16, 144, 22, 235, 141, 47, 150, 28, 112, 200, 63, 30, 155, 132, 254, 209, 165, 117, 7, 69, 171, 161, 198, 12, 44, 11, 45, 52, 137, 119, 126, 247, 223, 245, 91, 168, 206, 194, 194, 20, 75, 179, 153, 144, 170, 17, 231, 124, 170, 145, 15, 201, 89, 23, 31, 53, 142, 191, 2, 144, 117, 248, 115, 6, 180, 195, 34 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IsActive", "PasswordHash", "PasswordSalt" },
                values: new object[] { true, new byte[] { 61, 103, 201, 176, 82, 111, 235, 157, 22, 64, 150, 71, 239, 61, 157, 5, 88, 42, 0, 153, 251, 187, 141, 91, 15, 216, 127, 238, 117, 123, 128, 156, 167, 30, 211, 81, 196, 233, 36, 243, 222, 89, 150, 229, 255, 51, 224, 233, 65, 130, 39, 79, 157, 176, 118, 121, 155, 3, 65, 9, 165, 160, 47, 96 }, new byte[] { 187, 51, 194, 110, 248, 163, 214, 19, 57, 245, 36, 43, 204, 103, 220, 66, 43, 31, 230, 210, 10, 255, 165, 138, 71, 167, 20, 42, 31, 69, 64, 180, 81, 158, 86, 73, 195, 24, 62, 125, 54, 79, 143, 230, 137, 254, 108, 200, 219, 180, 47, 50, 123, 134, 112, 121, 191, 191, 113, 195, 179, 16, 144, 22, 235, 141, 47, 150, 28, 112, 200, 63, 30, 155, 132, 254, 209, 165, 117, 7, 69, 171, 161, 198, 12, 44, 11, 45, 52, 137, 119, 126, 247, 223, 245, 91, 168, 206, 194, 194, 20, 75, 179, 153, 144, 170, 17, 231, 124, 170, 145, 15, 201, 89, 23, 31, 53, 142, 191, 2, 144, 117, 248, 115, 6, 180, 195, 34 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IsActive", "PasswordHash", "PasswordSalt" },
                values: new object[] { true, new byte[] { 61, 103, 201, 176, 82, 111, 235, 157, 22, 64, 150, 71, 239, 61, 157, 5, 88, 42, 0, 153, 251, 187, 141, 91, 15, 216, 127, 238, 117, 123, 128, 156, 167, 30, 211, 81, 196, 233, 36, 243, 222, 89, 150, 229, 255, 51, 224, 233, 65, 130, 39, 79, 157, 176, 118, 121, 155, 3, 65, 9, 165, 160, 47, 96 }, new byte[] { 187, 51, 194, 110, 248, 163, 214, 19, 57, 245, 36, 43, 204, 103, 220, 66, 43, 31, 230, 210, 10, 255, 165, 138, 71, 167, 20, 42, 31, 69, 64, 180, 81, 158, 86, 73, 195, 24, 62, 125, 54, 79, 143, 230, 137, 254, 108, 200, 219, 180, 47, 50, 123, 134, 112, 121, 191, 191, 113, 195, 179, 16, 144, 22, 235, 141, 47, 150, 28, 112, 200, 63, 30, 155, 132, 254, 209, 165, 117, 7, 69, 171, 161, 198, 12, 44, 11, 45, 52, 137, 119, 126, 247, 223, 245, 91, 168, 206, 194, 194, 20, 75, 179, 153, 144, 170, 17, 231, 124, 170, 145, 15, 201, 89, 23, 31, 53, 142, 191, 2, 144, 117, 248, 115, 6, 180, 195, 34 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "IsActive", "PasswordHash", "PasswordSalt" },
                values: new object[] { true, new byte[] { 61, 103, 201, 176, 82, 111, 235, 157, 22, 64, 150, 71, 239, 61, 157, 5, 88, 42, 0, 153, 251, 187, 141, 91, 15, 216, 127, 238, 117, 123, 128, 156, 167, 30, 211, 81, 196, 233, 36, 243, 222, 89, 150, 229, 255, 51, 224, 233, 65, 130, 39, 79, 157, 176, 118, 121, 155, 3, 65, 9, 165, 160, 47, 96 }, new byte[] { 187, 51, 194, 110, 248, 163, 214, 19, 57, 245, 36, 43, 204, 103, 220, 66, 43, 31, 230, 210, 10, 255, 165, 138, 71, 167, 20, 42, 31, 69, 64, 180, 81, 158, 86, 73, 195, 24, 62, 125, 54, 79, 143, 230, 137, 254, 108, 200, 219, 180, 47, 50, 123, 134, 112, 121, 191, 191, 113, 195, 179, 16, 144, 22, 235, 141, 47, 150, 28, 112, 200, 63, 30, 155, 132, 254, 209, 165, 117, 7, 69, 171, 161, 198, 12, 44, 11, 45, 52, 137, 119, 126, 247, 223, 245, 91, 168, 206, 194, 194, 20, 75, 179, 153, 144, 170, 17, 231, 124, 170, 145, 15, 201, 89, 23, 31, 53, 142, 191, 2, 144, 117, 248, 115, 6, 180, 195, 34 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "IsActive", "PasswordHash", "PasswordSalt" },
                values: new object[] { true, new byte[] { 61, 103, 201, 176, 82, 111, 235, 157, 22, 64, 150, 71, 239, 61, 157, 5, 88, 42, 0, 153, 251, 187, 141, 91, 15, 216, 127, 238, 117, 123, 128, 156, 167, 30, 211, 81, 196, 233, 36, 243, 222, 89, 150, 229, 255, 51, 224, 233, 65, 130, 39, 79, 157, 176, 118, 121, 155, 3, 65, 9, 165, 160, 47, 96 }, new byte[] { 187, 51, 194, 110, 248, 163, 214, 19, 57, 245, 36, 43, 204, 103, 220, 66, 43, 31, 230, 210, 10, 255, 165, 138, 71, 167, 20, 42, 31, 69, 64, 180, 81, 158, 86, 73, 195, 24, 62, 125, 54, 79, 143, 230, 137, 254, 108, 200, 219, 180, 47, 50, 123, 134, 112, 121, 191, 191, 113, 195, 179, 16, 144, 22, 235, 141, 47, 150, 28, 112, 200, 63, 30, 155, 132, 254, 209, 165, 117, 7, 69, 171, 161, 198, 12, 44, 11, 45, 52, 137, 119, 126, 247, 223, 245, 91, 168, 206, 194, 194, 20, 75, 179, 153, 144, 170, 17, 231, 124, 170, 145, 15, 201, 89, 23, 31, 53, 142, 191, 2, 144, 117, 248, 115, 6, 180, 195, 34 } });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "BodyType", "VehicleRegistrationNumber" },
                values: new object[,]
                {
                    { new Guid("0abab865-83b8-4bb1-9cfe-1bdb2c2e30e9"), "Truck", "KCY 067A" },
                    { new Guid("5da5b147-aecb-442a-b9a7-0a5dea588453"), "Truck", "KDL 085M" },
                    { new Guid("66652716-1260-4654-a987-8070cb7d125d"), "Truck", "KDB 387Q" },
                    { new Guid("83e1a859-e675-45f8-b5e0-ecd4cd1e8ab3"), "Truck", "KDE 228S" },
                    { new Guid("954e8dca-1a23-49a2-8af9-638cd10c4369"), "Van", "KAY 215H" },
                    { new Guid("95c7cf16-43af-4917-ba92-64765d8791cf"), "Van", "KBF 462A" },
                    { new Guid("b28b10f7-e3d1-4a1a-a3c4-67554a1b0538"), "Truck", "KCZ 595L" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Devices_SerialNumber",
                table: "Devices",
                column: "SerialNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LoginSessions_DeviceId",
                table: "LoginSessions",
                column: "DeviceId");

            migrationBuilder.CreateIndex(
                name: "IX_LoginSessions_SessionId",
                table: "LoginSessions",
                column: "SessionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LoginSessions_UserId",
                table: "LoginSessions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserActivities_UserId",
                table: "UserActivities",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Branches_BranchId",
                table: "Users",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "id");
        }
    }
}
