using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace wms_android.api.Migrations
{
    /// <inheritdoc />
    public partial class AddDispatchCodeFieldOnly : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("1e1e22f0-c6a6-4e56-8245-e79674b7f56f"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("66bb18ba-245c-449b-950b-159c7563003e"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("785f04a9-23f1-4320-9589-40a3a2f284ad"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("86b89e7a-2598-450e-8f16-7137402f676e"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("a31fde51-28e1-44f7-918a-8850a3a3f8c4"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("a455b44e-1b06-4b3a-abe7-36969cfedd84"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("b485e2ce-4475-4232-9ff8-feba450c2dbf"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("cfbc5460-bb79-4ced-a1bd-8d92e54215a0"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("d43a1b47-8390-40c6-b85c-f020f1581a83"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("df60f1ca-8ec9-4135-ba7b-417d5405e143"));

            migrationBuilder.DeleteData(
                table: "UserBranches",
                keyColumns: new[] { "BranchId", "UserId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "UserBranches",
                keyColumns: new[] { "BranchId", "UserId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "UserBranches",
                keyColumns: new[] { "BranchId", "UserId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "UserBranches",
                keyColumns: new[] { "BranchId", "UserId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("3308121f-385f-4417-9fde-de18627fea29"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("43ea91e8-93cd-44e9-b102-571a02ebf2a7"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("96ad9256-0722-4a47-be50-e864f178be16"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("9ced0e48-f867-4dd1-8ad9-19830e71318f"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("a8e056bc-c492-4c56-8c0f-235ce2a29706"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("b708e180-1273-4964-896f-228655c78d24"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("e8e7f6c5-2940-4afd-8723-fad13de282b9"));

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Branches",
                newName: "phone");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Branches",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Branches",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Branches",
                newName: "address");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Branches",
                newName: "id");

            migrationBuilder.AddColumn<string>(
                name: "DispatchCode",
                table: "Dispatches",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DispatchCode",
                table: "Dispatches");

            migrationBuilder.RenameColumn(
                name: "phone",
                table: "Branches",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Branches",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Branches",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "address",
                table: "Branches",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Branches",
                newName: "Id");

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "Address", "Email", "Name", "Phone" },
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
                    { new Guid("1e1e22f0-c6a6-4e56-8245-e79674b7f56f"), "John", "JN", "Njuguna", "DL123456" },
                    { new Guid("66bb18ba-245c-449b-950b-159c7563003e"), "David", "DM", "Mwangi", "DL123456" },
                    { new Guid("785f04a9-23f1-4320-9589-40a3a2f284ad"), "Erastus", "EK", "Kagwa", "DL123456" },
                    { new Guid("86b89e7a-2598-450e-8f16-7137402f676e"), "Julius", "JK", "Kamula", "DL123456" },
                    { new Guid("a31fde51-28e1-44f7-918a-8850a3a3f8c4"), "Robert", "RN", "Njuguna", "DL123456" },
                    { new Guid("a455b44e-1b06-4b3a-abe7-36969cfedd84"), "Charles", "CM", "Maina", "DL123456" },
                    { new Guid("b485e2ce-4475-4232-9ff8-feba450c2dbf"), "James", "JG", "Gichohi", "DL123456" },
                    { new Guid("cfbc5460-bb79-4ced-a1bd-8d92e54215a0"), "Stephen", "SK", "Kimuyu", "DL123456" },
                    { new Guid("d43a1b47-8390-40c6-b85c-f020f1581a83"), "David", "DK", "Kibet", "DL123456" },
                    { new Guid("df60f1ca-8ec9-4135-ba7b-417d5405e143"), "John", "JM", "Mwai", "DL123456" }
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
                    { new Guid("3308121f-385f-4417-9fde-de18627fea29"), "Van", "KAY 215H" },
                    { new Guid("43ea91e8-93cd-44e9-b102-571a02ebf2a7"), "Truck", "KDB 387Q" },
                    { new Guid("96ad9256-0722-4a47-be50-e864f178be16"), "Truck", "KCZ 595L" },
                    { new Guid("9ced0e48-f867-4dd1-8ad9-19830e71318f"), "Truck", "KDL 085M" },
                    { new Guid("a8e056bc-c492-4c56-8c0f-235ce2a29706"), "Truck", "KDE 228S" },
                    { new Guid("b708e180-1273-4964-896f-228655c78d24"), "Van", "KBF 462A" },
                    { new Guid("e8e7f6c5-2940-4afd-8723-fad13de282b9"), "Truck", "KCY 067A" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "RoleId", "Username" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), "admin@example.com", "Admin", "User", new byte[] { 204, 184, 167, 112, 26, 169, 162, 245, 0, 179, 14, 107, 251, 42, 112, 189, 13, 198, 152, 53, 1, 255, 5, 53, 151, 76, 119, 141, 69, 45, 112, 59, 246, 77, 104, 48, 133, 155, 155, 11, 139, 178, 233, 187, 176, 119, 95, 82, 86, 153, 208, 1, 170, 153, 1, 239, 80, 3, 68, 146, 234, 121, 72, 230 }, new byte[] { 158, 132, 159, 95, 154, 88, 234, 251, 11, 79, 80, 119, 191, 187, 38, 195, 83, 129, 199, 46, 59, 51, 224, 17, 137, 51, 94, 236, 66, 129, 66, 132, 232, 142, 247, 10, 108, 242, 210, 35, 224, 154, 154, 86, 44, 119, 228, 70, 125, 23, 118, 199, 88, 131, 37, 76, 97, 185, 107, 162, 195, 30, 105, 187, 202, 217, 30, 200, 150, 221, 101, 184, 213, 75, 115, 43, 62, 100, 187, 184, 84, 159, 132, 16, 239, 14, 44, 56, 221, 199, 45, 113, 243, 181, 184, 110, 103, 98, 80, 54, 137, 109, 249, 74, 43, 139, 98, 202, 57, 130, 135, 115, 96, 184, 205, 25, 57, 46, 215, 192, 203, 245, 152, 51, 246, 17, 74, 73 }, 1, "admin" },
                    { 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), "manager@example.com", "Manager", "Person", new byte[] { 204, 184, 167, 112, 26, 169, 162, 245, 0, 179, 14, 107, 251, 42, 112, 189, 13, 198, 152, 53, 1, 255, 5, 53, 151, 76, 119, 141, 69, 45, 112, 59, 246, 77, 104, 48, 133, 155, 155, 11, 139, 178, 233, 187, 176, 119, 95, 82, 86, 153, 208, 1, 170, 153, 1, 239, 80, 3, 68, 146, 234, 121, 72, 230 }, new byte[] { 158, 132, 159, 95, 154, 88, 234, 251, 11, 79, 80, 119, 191, 187, 38, 195, 83, 129, 199, 46, 59, 51, 224, 17, 137, 51, 94, 236, 66, 129, 66, 132, 232, 142, 247, 10, 108, 242, 210, 35, 224, 154, 154, 86, 44, 119, 228, 70, 125, 23, 118, 199, 88, 131, 37, 76, 97, 185, 107, 162, 195, 30, 105, 187, 202, 217, 30, 200, 150, 221, 101, 184, 213, 75, 115, 43, 62, 100, 187, 184, 84, 159, 132, 16, 239, 14, 44, 56, 221, 199, 45, 113, 243, 181, 184, 110, 103, 98, 80, 54, 137, 109, 249, 74, 43, 139, 98, 202, 57, 130, 135, 115, 96, 184, 205, 25, 57, 46, 215, 192, 203, 245, 152, 51, 246, 17, 74, 73 }, 2, "manager" },
                    { 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), "clerk1@example.com", "Clerk", "One", new byte[] { 204, 184, 167, 112, 26, 169, 162, 245, 0, 179, 14, 107, 251, 42, 112, 189, 13, 198, 152, 53, 1, 255, 5, 53, 151, 76, 119, 141, 69, 45, 112, 59, 246, 77, 104, 48, 133, 155, 155, 11, 139, 178, 233, 187, 176, 119, 95, 82, 86, 153, 208, 1, 170, 153, 1, 239, 80, 3, 68, 146, 234, 121, 72, 230 }, new byte[] { 158, 132, 159, 95, 154, 88, 234, 251, 11, 79, 80, 119, 191, 187, 38, 195, 83, 129, 199, 46, 59, 51, 224, 17, 137, 51, 94, 236, 66, 129, 66, 132, 232, 142, 247, 10, 108, 242, 210, 35, 224, 154, 154, 86, 44, 119, 228, 70, 125, 23, 118, 199, 88, 131, 37, 76, 97, 185, 107, 162, 195, 30, 105, 187, 202, 217, 30, 200, 150, 221, 101, 184, 213, 75, 115, 43, 62, 100, 187, 184, 84, 159, 132, 16, 239, 14, 44, 56, 221, 199, 45, 113, 243, 181, 184, 110, 103, 98, 80, 54, 137, 109, 249, 74, 43, 139, 98, 202, 57, 130, 135, 115, 96, 184, 205, 25, 57, 46, 215, 192, 203, 245, 152, 51, 246, 17, 74, 73 }, 3, "clerk1" },
                    { 4, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), "clerk2@example.com", "Clerk", "Two", new byte[] { 204, 184, 167, 112, 26, 169, 162, 245, 0, 179, 14, 107, 251, 42, 112, 189, 13, 198, 152, 53, 1, 255, 5, 53, 151, 76, 119, 141, 69, 45, 112, 59, 246, 77, 104, 48, 133, 155, 155, 11, 139, 178, 233, 187, 176, 119, 95, 82, 86, 153, 208, 1, 170, 153, 1, 239, 80, 3, 68, 146, 234, 121, 72, 230 }, new byte[] { 158, 132, 159, 95, 154, 88, 234, 251, 11, 79, 80, 119, 191, 187, 38, 195, 83, 129, 199, 46, 59, 51, 224, 17, 137, 51, 94, 236, 66, 129, 66, 132, 232, 142, 247, 10, 108, 242, 210, 35, 224, 154, 154, 86, 44, 119, 228, 70, 125, 23, 118, 199, 88, 131, 37, 76, 97, 185, 107, 162, 195, 30, 105, 187, 202, 217, 30, 200, 150, 221, 101, 184, 213, 75, 115, 43, 62, 100, 187, 184, 84, 159, 132, 16, 239, 14, 44, 56, 221, 199, 45, 113, 243, 181, 184, 110, 103, 98, 80, 54, 137, 109, 249, 74, 43, 139, 98, 202, 57, 130, 135, 115, 96, 184, 205, 25, 57, 46, 215, 192, 203, 245, 152, 51, 246, 17, 74, 73 }, 3, "clerk2" },
                    { 5, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), "client1@example.com", "Client", "UserOne", new byte[] { 204, 184, 167, 112, 26, 169, 162, 245, 0, 179, 14, 107, 251, 42, 112, 189, 13, 198, 152, 53, 1, 255, 5, 53, 151, 76, 119, 141, 69, 45, 112, 59, 246, 77, 104, 48, 133, 155, 155, 11, 139, 178, 233, 187, 176, 119, 95, 82, 86, 153, 208, 1, 170, 153, 1, 239, 80, 3, 68, 146, 234, 121, 72, 230 }, new byte[] { 158, 132, 159, 95, 154, 88, 234, 251, 11, 79, 80, 119, 191, 187, 38, 195, 83, 129, 199, 46, 59, 51, 224, 17, 137, 51, 94, 236, 66, 129, 66, 132, 232, 142, 247, 10, 108, 242, 210, 35, 224, 154, 154, 86, 44, 119, 228, 70, 125, 23, 118, 199, 88, 131, 37, 76, 97, 185, 107, 162, 195, 30, 105, 187, 202, 217, 30, 200, 150, 221, 101, 184, 213, 75, 115, 43, 62, 100, 187, 184, 84, 159, 132, 16, 239, 14, 44, 56, 221, 199, 45, 113, 243, 181, 184, 110, 103, 98, 80, 54, 137, 109, 249, 74, 43, 139, 98, 202, 57, 130, 135, 115, 96, 184, 205, 25, 57, 46, 215, 192, 203, 245, 152, 51, 246, 17, 74, 73 }, 4, "client1" },
                    { 6, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), "client2@example.com", "Client", "UserTwo", new byte[] { 204, 184, 167, 112, 26, 169, 162, 245, 0, 179, 14, 107, 251, 42, 112, 189, 13, 198, 152, 53, 1, 255, 5, 53, 151, 76, 119, 141, 69, 45, 112, 59, 246, 77, 104, 48, 133, 155, 155, 11, 139, 178, 233, 187, 176, 119, 95, 82, 86, 153, 208, 1, 170, 153, 1, 239, 80, 3, 68, 146, 234, 121, 72, 230 }, new byte[] { 158, 132, 159, 95, 154, 88, 234, 251, 11, 79, 80, 119, 191, 187, 38, 195, 83, 129, 199, 46, 59, 51, 224, 17, 137, 51, 94, 236, 66, 129, 66, 132, 232, 142, 247, 10, 108, 242, 210, 35, 224, 154, 154, 86, 44, 119, 228, 70, 125, 23, 118, 199, 88, 131, 37, 76, 97, 185, 107, 162, 195, 30, 105, 187, 202, 217, 30, 200, 150, 221, 101, 184, 213, 75, 115, 43, 62, 100, 187, 184, 84, 159, 132, 16, 239, 14, 44, 56, 221, 199, 45, 113, 243, 181, 184, 110, 103, 98, 80, 54, 137, 109, 249, 74, 43, 139, 98, 202, 57, 130, 135, 115, 96, 184, 205, 25, 57, 46, 215, 192, 203, 245, 152, 51, 246, 17, 74, 73 }, 4, "client2" }
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
        }
    }
}
