using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace wms_android.api.Migrations
{
    /// <inheritdoc />
    public partial class AddDestinationToDispatch : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Destination",
                table: "Dispatches",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    address = table.Column<string>(type: "text", nullable: false),
                    phone = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.id);
                });

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
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "bytea", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "bytea", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    RoleId = table.Column<int>(type: "integer", nullable: false),
                    BranchId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContractCustomers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    CompanyName = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Email = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    Address = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    ContactPerson = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    ContractNumber = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    PaymentTerms = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    TaxRate = table.Column<decimal>(type: "numeric(5,2)", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedById = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractCustomers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContractCustomers_Users_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateTable(
                name: "UserBranches",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    BranchId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserBranches", x => new { x.UserId, x.BranchId });
                    table.ForeignKey(
                        name: "FK_UserBranches_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserBranches_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    InvoiceNumber = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    CustomerId = table.Column<int>(type: "integer", nullable: false),
                    IssueDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DueDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Status = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    Subtotal = table.Column<decimal>(type: "numeric(12,2)", nullable: false),
                    TaxAmount = table.Column<decimal>(type: "numeric(12,2)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "numeric(12,2)", nullable: false),
                    Notes = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    CreatedById = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invoices_ContractCustomers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "ContractCustomers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Invoices_Users_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Parcels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    WaybillNumber = table.Column<string>(type: "text", nullable: true),
                    QRCode = table.Column<string>(type: "text", nullable: true),
                    DispatchedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DispatchTrackingCode = table.Column<string>(type: "text", nullable: true),
                    CreatedById = table.Column<int>(type: "integer", nullable: true),
                    CreatorLastNameSnapshot = table.Column<string>(type: "text", nullable: true),
                    ShipmentId = table.Column<Guid>(type: "uuid", nullable: true),
                    Sender = table.Column<string>(type: "text", nullable: false),
                    SenderTelephone = table.Column<string>(type: "text", nullable: false),
                    Receiver = table.Column<string>(type: "text", nullable: false),
                    ReceiverTelephone = table.Column<string>(type: "text", nullable: false),
                    Destination = table.Column<string>(type: "text", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Amount = table.Column<decimal>(type: "numeric", nullable: true),
                    Rate = table.Column<decimal>(type: "numeric", nullable: true),
                    PaymentMethods = table.Column<string>(type: "text", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "numeric", nullable: false),
                    TotalRate = table.Column<decimal>(type: "numeric", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parcels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Parcels_Shipments_ShipmentId",
                        column: x => x.ShipmentId,
                        principalTable: "Shipments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Parcels_Users_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    InvoiceId = table.Column<int>(type: "integer", nullable: false),
                    ParcelId = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    WaybillNumber = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InvoiceItems_Invoices_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Invoices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "id", "address", "email", "name", "phone" },
                values: new object[,]
                {
                    { 1, "Mombasa Address", "mombasa@email.com", "Mombasa", "111" },
                    { 2, "Nairobi Address", "nairobi@email.com", "Nairobi", "222" },
                    { 3, "Kisumu Address", "kisumu@email.com", "Kisumu", "333" },
                    { 4, "Eldoret Address", "eldoret@email.com", "Eldoret", "444" },
                    { 5, "Nakuru Address", "nakuru@email.com", "Nakuru", "555" },
                    { 6, "Kericho Address", "kericho@email.com", "Kericho", "666" },
                    { 7, "Kakamega Address", "kakamega@email.com", "Kakamega", "777" },
                    { 8, "Kapsabet Address", "kapsabet@email.com", "Kapsabet", "888" },
                    { 9, "Kitale Address", "kitale@email.com", "Kitale", "999" }
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "FirstName", "Initials", "LastName", "LicenseNumber" },
                values: new object[,]
                {
                    { new Guid("49aa23c5-e454-4fcf-a543-e16dcf7f72e1"), "James", "JG", "Gichohi", "DL123456" },
                    { new Guid("75cd5dd2-4bf9-46e1-85b8-ba7d04191d1d"), "John", "JN", "Njuguna", "DL123456" },
                    { new Guid("7e4870b9-a598-4374-a475-0b81dd29c10e"), "John", "JM", "Mwai", "DL123456" },
                    { new Guid("8424130c-21b6-460e-8d17-fdbcc3fa2f35"), "David", "DM", "Mwangi", "DL123456" },
                    { new Guid("c2adda8c-5c36-491a-ba7a-f230d63117d4"), "Robert", "RN", "Njuguna", "DL123456" },
                    { new Guid("cfe120cf-dcf2-4c5d-97cf-f786975de9eb"), "Stephen", "SK", "Kimuyu", "DL123456" },
                    { new Guid("d114a9da-83c1-4f2c-891a-45497bd98775"), "David", "DK", "Kibet", "DL123456" },
                    { new Guid("d6e8f355-8c70-4497-852a-64a0abc1d08e"), "Charles", "CM", "Maina", "DL123456" },
                    { new Guid("ddd65053-d023-4ed6-b1f0-68b1d0ef0aac"), "Erastus", "EK", "Kagwa", "DL123456" },
                    { new Guid("e72bcbe1-7e1f-447a-9c22-e30962f962ae"), "Julius", "JK", "Kamula", "DL123456" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BranchId", "CreatedAt", "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "RoleId", "Username" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), "admin@example.com", "Admin", "User", new byte[] { 42, 127, 212, 3, 223, 31, 63, 201, 81, 130, 181, 78, 167, 235, 219, 83, 177, 174, 117, 97, 5, 30, 43, 75, 188, 65, 233, 69, 196, 208, 89, 207, 100, 129, 138, 174, 19, 69, 29, 208, 31, 95, 5, 218, 216, 194, 246, 98, 113, 109, 151, 177, 81, 56, 92, 74, 114, 54, 234, 139, 242, 124, 22, 63 }, new byte[] { 138, 142, 125, 46, 245, 66, 236, 40, 27, 191, 70, 30, 100, 110, 55, 52, 9, 150, 122, 203, 66, 161, 144, 89, 107, 21, 160, 150, 104, 174, 20, 181, 34, 241, 117, 71, 24, 177, 183, 41, 70, 154, 246, 61, 119, 170, 81, 123, 130, 132, 221, 163, 78, 202, 124, 60, 159, 33, 0, 163, 37, 65, 53, 55, 13, 106, 15, 33, 235, 213, 13, 165, 137, 239, 134, 178, 128, 187, 153, 1, 150, 250, 104, 5, 107, 29, 203, 3, 85, 25, 111, 28, 96, 73, 101, 235, 115, 20, 30, 251, 168, 181, 25, 18, 244, 133, 120, 93, 5, 180, 2, 101, 76, 202, 233, 52, 169, 43, 5, 81, 84, 192, 118, 11, 239, 61, 235, 87 }, 1, "admin" },
                    { 2, null, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), "manager@example.com", "Manager", "Person", new byte[] { 42, 127, 212, 3, 223, 31, 63, 201, 81, 130, 181, 78, 167, 235, 219, 83, 177, 174, 117, 97, 5, 30, 43, 75, 188, 65, 233, 69, 196, 208, 89, 207, 100, 129, 138, 174, 19, 69, 29, 208, 31, 95, 5, 218, 216, 194, 246, 98, 113, 109, 151, 177, 81, 56, 92, 74, 114, 54, 234, 139, 242, 124, 22, 63 }, new byte[] { 138, 142, 125, 46, 245, 66, 236, 40, 27, 191, 70, 30, 100, 110, 55, 52, 9, 150, 122, 203, 66, 161, 144, 89, 107, 21, 160, 150, 104, 174, 20, 181, 34, 241, 117, 71, 24, 177, 183, 41, 70, 154, 246, 61, 119, 170, 81, 123, 130, 132, 221, 163, 78, 202, 124, 60, 159, 33, 0, 163, 37, 65, 53, 55, 13, 106, 15, 33, 235, 213, 13, 165, 137, 239, 134, 178, 128, 187, 153, 1, 150, 250, 104, 5, 107, 29, 203, 3, 85, 25, 111, 28, 96, 73, 101, 235, 115, 20, 30, 251, 168, 181, 25, 18, 244, 133, 120, 93, 5, 180, 2, 101, 76, 202, 233, 52, 169, 43, 5, 81, 84, 192, 118, 11, 239, 61, 235, 87 }, 2, "manager" },
                    { 3, null, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), "clerk1@example.com", "Clerk", "One", new byte[] { 42, 127, 212, 3, 223, 31, 63, 201, 81, 130, 181, 78, 167, 235, 219, 83, 177, 174, 117, 97, 5, 30, 43, 75, 188, 65, 233, 69, 196, 208, 89, 207, 100, 129, 138, 174, 19, 69, 29, 208, 31, 95, 5, 218, 216, 194, 246, 98, 113, 109, 151, 177, 81, 56, 92, 74, 114, 54, 234, 139, 242, 124, 22, 63 }, new byte[] { 138, 142, 125, 46, 245, 66, 236, 40, 27, 191, 70, 30, 100, 110, 55, 52, 9, 150, 122, 203, 66, 161, 144, 89, 107, 21, 160, 150, 104, 174, 20, 181, 34, 241, 117, 71, 24, 177, 183, 41, 70, 154, 246, 61, 119, 170, 81, 123, 130, 132, 221, 163, 78, 202, 124, 60, 159, 33, 0, 163, 37, 65, 53, 55, 13, 106, 15, 33, 235, 213, 13, 165, 137, 239, 134, 178, 128, 187, 153, 1, 150, 250, 104, 5, 107, 29, 203, 3, 85, 25, 111, 28, 96, 73, 101, 235, 115, 20, 30, 251, 168, 181, 25, 18, 244, 133, 120, 93, 5, 180, 2, 101, 76, 202, 233, 52, 169, 43, 5, 81, 84, 192, 118, 11, 239, 61, 235, 87 }, 3, "clerk1" },
                    { 4, null, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), "clerk2@example.com", "Clerk", "Two", new byte[] { 42, 127, 212, 3, 223, 31, 63, 201, 81, 130, 181, 78, 167, 235, 219, 83, 177, 174, 117, 97, 5, 30, 43, 75, 188, 65, 233, 69, 196, 208, 89, 207, 100, 129, 138, 174, 19, 69, 29, 208, 31, 95, 5, 218, 216, 194, 246, 98, 113, 109, 151, 177, 81, 56, 92, 74, 114, 54, 234, 139, 242, 124, 22, 63 }, new byte[] { 138, 142, 125, 46, 245, 66, 236, 40, 27, 191, 70, 30, 100, 110, 55, 52, 9, 150, 122, 203, 66, 161, 144, 89, 107, 21, 160, 150, 104, 174, 20, 181, 34, 241, 117, 71, 24, 177, 183, 41, 70, 154, 246, 61, 119, 170, 81, 123, 130, 132, 221, 163, 78, 202, 124, 60, 159, 33, 0, 163, 37, 65, 53, 55, 13, 106, 15, 33, 235, 213, 13, 165, 137, 239, 134, 178, 128, 187, 153, 1, 150, 250, 104, 5, 107, 29, 203, 3, 85, 25, 111, 28, 96, 73, 101, 235, 115, 20, 30, 251, 168, 181, 25, 18, 244, 133, 120, 93, 5, 180, 2, 101, 76, 202, 233, 52, 169, 43, 5, 81, 84, 192, 118, 11, 239, 61, 235, 87 }, 3, "clerk2" },
                    { 5, null, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), "client@example.com", "Client", "User", new byte[] { 42, 127, 212, 3, 223, 31, 63, 201, 81, 130, 181, 78, 167, 235, 219, 83, 177, 174, 117, 97, 5, 30, 43, 75, 188, 65, 233, 69, 196, 208, 89, 207, 100, 129, 138, 174, 19, 69, 29, 208, 31, 95, 5, 218, 216, 194, 246, 98, 113, 109, 151, 177, 81, 56, 92, 74, 114, 54, 234, 139, 242, 124, 22, 63 }, new byte[] { 138, 142, 125, 46, 245, 66, 236, 40, 27, 191, 70, 30, 100, 110, 55, 52, 9, 150, 122, 203, 66, 161, 144, 89, 107, 21, 160, 150, 104, 174, 20, 181, 34, 241, 117, 71, 24, 177, 183, 41, 70, 154, 246, 61, 119, 170, 81, 123, 130, 132, 221, 163, 78, 202, 124, 60, 159, 33, 0, 163, 37, 65, 53, 55, 13, 106, 15, 33, 235, 213, 13, 165, 137, 239, 134, 178, 128, 187, 153, 1, 150, 250, 104, 5, 107, 29, 203, 3, 85, 25, 111, 28, 96, 73, 101, 235, 115, 20, 30, 251, 168, 181, 25, 18, 244, 133, 120, 93, 5, 180, 2, 101, 76, 202, 233, 52, 169, 43, 5, 81, 84, 192, 118, 11, 239, 61, 235, 87 }, 4, "client" },
                    { 6, null, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), "client2@example.com", "Client", "UserTwo", new byte[] { 42, 127, 212, 3, 223, 31, 63, 201, 81, 130, 181, 78, 167, 235, 219, 83, 177, 174, 117, 97, 5, 30, 43, 75, 188, 65, 233, 69, 196, 208, 89, 207, 100, 129, 138, 174, 19, 69, 29, 208, 31, 95, 5, 218, 216, 194, 246, 98, 113, 109, 151, 177, 81, 56, 92, 74, 114, 54, 234, 139, 242, 124, 22, 63 }, new byte[] { 138, 142, 125, 46, 245, 66, 236, 40, 27, 191, 70, 30, 100, 110, 55, 52, 9, 150, 122, 203, 66, 161, 144, 89, 107, 21, 160, 150, 104, 174, 20, 181, 34, 241, 117, 71, 24, 177, 183, 41, 70, 154, 246, 61, 119, 170, 81, 123, 130, 132, 221, 163, 78, 202, 124, 60, 159, 33, 0, 163, 37, 65, 53, 55, 13, 106, 15, 33, 235, 213, 13, 165, 137, 239, 134, 178, 128, 187, 153, 1, 150, 250, 104, 5, 107, 29, 203, 3, 85, 25, 111, 28, 96, 73, 101, 235, 115, 20, 30, 251, 168, 181, 25, 18, 244, 133, 120, 93, 5, 180, 2, 101, 76, 202, 233, 52, 169, 43, 5, 81, 84, 192, 118, 11, 239, 61, 235, 87 }, 4, "client2" }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "BodyType", "VehicleRegistrationNumber" },
                values: new object[,]
                {
                    { new Guid("322bcf9f-0f7a-4290-907e-5671d62de217"), "Truck", "KCZ 595L" },
                    { new Guid("6f4bfe56-15a7-477c-89e4-bb3ac58a9c4d"), "Van", "KBF 462A" },
                    { new Guid("b21258c4-6a5b-47b2-9a9d-761a07f41484"), "Truck", "KDL 085M" },
                    { new Guid("bb29615f-8726-4110-9830-a1f94a3c9582"), "Truck", "KCY 067A" },
                    { new Guid("d1bfaeae-4998-4919-aa4a-23cd77487194"), "Van", "KAY 215H" },
                    { new Guid("e7dfa1c7-5ef8-4dad-a63c-ced418c2d69a"), "Truck", "KDE 228S" },
                    { new Guid("ed257729-ac78-4352-87cb-0f5905ab955d"), "Truck", "KDB 387Q" }
                });

            migrationBuilder.InsertData(
                table: "UserBranches",
                columns: new[] { "BranchId", "UserId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 2, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContractCustomers_CreatedById",
                table: "ContractCustomers",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceItems_InvoiceId",
                table: "InvoiceItems",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_CreatedById",
                table: "Invoices",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_CustomerId",
                table: "Invoices",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Parcels_CreatedById",
                table: "Parcels",
                column: "CreatedById");

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

            migrationBuilder.CreateIndex(
                name: "IX_UserBranches_BranchId",
                table: "UserBranches",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_BranchId",
                table: "Users",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_DispatchParcels_Dispatches_DispatchId",
                table: "DispatchParcels",
                column: "DispatchId",
                principalTable: "Dispatches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DispatchParcels_Parcels_ParcelsId",
                table: "DispatchParcels",
                column: "ParcelsId",
                principalTable: "Parcels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DispatchParcels_Dispatches_DispatchId",
                table: "DispatchParcels");

            migrationBuilder.DropForeignKey(
                name: "FK_DispatchParcels_Parcels_ParcelsId",
                table: "DispatchParcels");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "InvoiceItems");

            migrationBuilder.DropTable(
                name: "Parcels");

            migrationBuilder.DropTable(
                name: "UserBranches");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "Shipments");

            migrationBuilder.DropTable(
                name: "ContractCustomers");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropColumn(
                name: "Destination",
                table: "Dispatches");
        }
    }
}
