using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace wms_android.api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Initials = table.Column<string>(type: "text", nullable: false),
                    LicenseNumber = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parcels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    WaybillNumber = table.Column<string>(type: "text", nullable: false),
                    QRCode = table.Column<string>(type: "text", nullable: false),
                    DispatchedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DispatchTrackingCode = table.Column<string>(type: "text", nullable: true),
                    Sender = table.Column<string>(type: "text", nullable: false),
                    SenderTelephone = table.Column<string>(type: "text", nullable: false),
                    Receiver = table.Column<string>(type: "text", nullable: false),
                    ReceiverTelephone = table.Column<string>(type: "text", nullable: false),
                    Destination = table.Column<string>(type: "text", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Amount = table.Column<decimal>(type: "numeric", nullable: false),
                    Rate = table.Column<decimal>(type: "numeric", nullable: false),
                    PaymentMethods = table.Column<string>(type: "text", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "numeric", nullable: false),
                    TotalRate = table.Column<decimal>(type: "numeric", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parcels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    VehicleRegistrationNumber = table.Column<string>(type: "text", nullable: false),
                    BodyType = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Username = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "bytea", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "bytea", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    RoleId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Administrator", "Admin" },
                    { 2, "Manager", "Manager" },
                    { 3, "Regular User", "Clerk" },
                    { 4, "Client User", "Client" }
                });

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

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "Password", "PasswordHash", "PasswordSalt", "RoleId", "Username" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), "admin@example.com", "admin123", new byte[] { 9, 101, 41, 228, 239, 189, 235, 174, 25, 35, 134, 125, 35, 140, 92, 63, 254, 45, 142, 226, 47, 127, 176, 85, 69, 170, 12, 13, 32, 213, 183, 212, 153, 96, 49, 143, 2, 91, 29, 24, 200, 178, 22, 129, 9, 107, 76, 173, 192, 231, 146, 104, 211, 132, 6, 3, 168, 225, 67, 202, 241, 109, 108, 55 }, new byte[] { 27, 35, 145, 171, 102, 146, 212, 95, 253, 18, 116, 57, 156, 3, 251, 21, 150, 131, 15, 52, 225, 237, 177, 44, 165, 113, 60, 189, 64, 242, 142, 181, 220, 159, 30, 132, 33, 60, 132, 65, 81, 141, 199, 182, 25, 212, 240, 21, 158, 194, 155, 181, 104, 242, 125, 63, 181, 255, 131, 241, 173, 57, 124, 188, 249, 203, 197, 228, 84, 13, 9, 111, 130, 107, 88, 150, 77, 38, 122, 95, 144, 53, 95, 186, 113, 13, 112, 14, 137, 242, 88, 96, 198, 50, 80, 210, 99, 31, 246, 99, 103, 119, 143, 134, 6, 97, 203, 66, 179, 135, 58, 114, 130, 9, 120, 21, 86, 39, 106, 145, 198, 180, 59, 111, 224, 51, 26, 36 }, 1, "admin" },
                    { 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), "manager@example.com", "manager123", new byte[] { 9, 101, 41, 228, 239, 189, 235, 174, 25, 35, 134, 125, 35, 140, 92, 63, 254, 45, 142, 226, 47, 127, 176, 85, 69, 170, 12, 13, 32, 213, 183, 212, 153, 96, 49, 143, 2, 91, 29, 24, 200, 178, 22, 129, 9, 107, 76, 173, 192, 231, 146, 104, 211, 132, 6, 3, 168, 225, 67, 202, 241, 109, 108, 55 }, new byte[] { 27, 35, 145, 171, 102, 146, 212, 95, 253, 18, 116, 57, 156, 3, 251, 21, 150, 131, 15, 52, 225, 237, 177, 44, 165, 113, 60, 189, 64, 242, 142, 181, 220, 159, 30, 132, 33, 60, 132, 65, 81, 141, 199, 182, 25, 212, 240, 21, 158, 194, 155, 181, 104, 242, 125, 63, 181, 255, 131, 241, 173, 57, 124, 188, 249, 203, 197, 228, 84, 13, 9, 111, 130, 107, 88, 150, 77, 38, 122, 95, 144, 53, 95, 186, 113, 13, 112, 14, 137, 242, 88, 96, 198, 50, 80, 210, 99, 31, 246, 99, 103, 119, 143, 134, 6, 97, 203, 66, 179, 135, 58, 114, 130, 9, 120, 21, 86, 39, 106, 145, 198, 180, 59, 111, 224, 51, 26, 36 }, 2, "manager" },
                    { 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), "clerk1@example.com", "clerk123", new byte[] { 9, 101, 41, 228, 239, 189, 235, 174, 25, 35, 134, 125, 35, 140, 92, 63, 254, 45, 142, 226, 47, 127, 176, 85, 69, 170, 12, 13, 32, 213, 183, 212, 153, 96, 49, 143, 2, 91, 29, 24, 200, 178, 22, 129, 9, 107, 76, 173, 192, 231, 146, 104, 211, 132, 6, 3, 168, 225, 67, 202, 241, 109, 108, 55 }, new byte[] { 27, 35, 145, 171, 102, 146, 212, 95, 253, 18, 116, 57, 156, 3, 251, 21, 150, 131, 15, 52, 225, 237, 177, 44, 165, 113, 60, 189, 64, 242, 142, 181, 220, 159, 30, 132, 33, 60, 132, 65, 81, 141, 199, 182, 25, 212, 240, 21, 158, 194, 155, 181, 104, 242, 125, 63, 181, 255, 131, 241, 173, 57, 124, 188, 249, 203, 197, 228, 84, 13, 9, 111, 130, 107, 88, 150, 77, 38, 122, 95, 144, 53, 95, 186, 113, 13, 112, 14, 137, 242, 88, 96, 198, 50, 80, 210, 99, 31, 246, 99, 103, 119, 143, 134, 6, 97, 203, 66, 179, 135, 58, 114, 130, 9, 120, 21, 86, 39, 106, 145, 198, 180, 59, 111, 224, 51, 26, 36 }, 3, "clerk1" },
                    { 4, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), "clerk2@example.com", "clerk123", new byte[] { 9, 101, 41, 228, 239, 189, 235, 174, 25, 35, 134, 125, 35, 140, 92, 63, 254, 45, 142, 226, 47, 127, 176, 85, 69, 170, 12, 13, 32, 213, 183, 212, 153, 96, 49, 143, 2, 91, 29, 24, 200, 178, 22, 129, 9, 107, 76, 173, 192, 231, 146, 104, 211, 132, 6, 3, 168, 225, 67, 202, 241, 109, 108, 55 }, new byte[] { 27, 35, 145, 171, 102, 146, 212, 95, 253, 18, 116, 57, 156, 3, 251, 21, 150, 131, 15, 52, 225, 237, 177, 44, 165, 113, 60, 189, 64, 242, 142, 181, 220, 159, 30, 132, 33, 60, 132, 65, 81, 141, 199, 182, 25, 212, 240, 21, 158, 194, 155, 181, 104, 242, 125, 63, 181, 255, 131, 241, 173, 57, 124, 188, 249, 203, 197, 228, 84, 13, 9, 111, 130, 107, 88, 150, 77, 38, 122, 95, 144, 53, 95, 186, 113, 13, 112, 14, 137, 242, 88, 96, 198, 50, 80, 210, 99, 31, 246, 99, 103, 119, 143, 134, 6, 97, 203, 66, 179, 135, 58, 114, 130, 9, 120, 21, 86, 39, 106, 145, 198, 180, 59, 111, 224, 51, 26, 36 }, 3, "clerk2" },
                    { 5, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), "client1@example.com", "client123", new byte[] { 9, 101, 41, 228, 239, 189, 235, 174, 25, 35, 134, 125, 35, 140, 92, 63, 254, 45, 142, 226, 47, 127, 176, 85, 69, 170, 12, 13, 32, 213, 183, 212, 153, 96, 49, 143, 2, 91, 29, 24, 200, 178, 22, 129, 9, 107, 76, 173, 192, 231, 146, 104, 211, 132, 6, 3, 168, 225, 67, 202, 241, 109, 108, 55 }, new byte[] { 27, 35, 145, 171, 102, 146, 212, 95, 253, 18, 116, 57, 156, 3, 251, 21, 150, 131, 15, 52, 225, 237, 177, 44, 165, 113, 60, 189, 64, 242, 142, 181, 220, 159, 30, 132, 33, 60, 132, 65, 81, 141, 199, 182, 25, 212, 240, 21, 158, 194, 155, 181, 104, 242, 125, 63, 181, 255, 131, 241, 173, 57, 124, 188, 249, 203, 197, 228, 84, 13, 9, 111, 130, 107, 88, 150, 77, 38, 122, 95, 144, 53, 95, 186, 113, 13, 112, 14, 137, 242, 88, 96, 198, 50, 80, 210, 99, 31, 246, 99, 103, 119, 143, 134, 6, 97, 203, 66, 179, 135, 58, 114, 130, 9, 120, 21, 86, 39, 106, 145, 198, 180, 59, 111, 224, 51, 26, 36 }, 4, "client1" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "Parcels");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
