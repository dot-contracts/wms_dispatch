using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wms_android.data.Migrations
{
    /// <inheritdoc />
    public partial class PaymentmethodPropertyAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PaymentMethods",
                table: "Parcels",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentMethods",
                table: "Parcels");
        }
    }
}
