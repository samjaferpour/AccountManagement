using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AccountManagement.Persistence.Migrations
{
    public partial class AddTypeDescriptionFildIntoAccountTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "WithdrawAccountTransactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 17, 6, 43, 44, 388, DateTimeKind.Local).AddTicks(251),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 17, 6, 28, 37, 488, DateTimeKind.Local).AddTicks(2087));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "WithdrawAccountTransactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 17, 6, 43, 44, 388, DateTimeKind.Local).AddTicks(131),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 17, 6, 28, 37, 488, DateTimeKind.Local).AddTicks(2012));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Transactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 17, 6, 43, 44, 387, DateTimeKind.Local).AddTicks(8299),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 17, 6, 28, 37, 488, DateTimeKind.Local).AddTicks(545));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Transactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 17, 6, 43, 44, 387, DateTimeKind.Local).AddTicks(8230),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 17, 6, 28, 37, 488, DateTimeKind.Local).AddTicks(482));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Letters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 17, 6, 43, 44, 387, DateTimeKind.Local).AddTicks(4119),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 17, 6, 28, 37, 487, DateTimeKind.Local).AddTicks(6578));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Letters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 17, 6, 43, 44, 387, DateTimeKind.Local).AddTicks(3969),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 17, 6, 28, 37, 487, DateTimeKind.Local).AddTicks(6453));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "DemandPackets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 17, 6, 43, 44, 387, DateTimeKind.Local).AddTicks(6187),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 17, 6, 28, 37, 487, DateTimeKind.Local).AddTicks(8392));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DemandPackets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 17, 6, 43, 44, 387, DateTimeKind.Local).AddTicks(6122),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 17, 6, 28, 37, 487, DateTimeKind.Local).AddTicks(8309));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 17, 6, 43, 44, 387, DateTimeKind.Local).AddTicks(5795),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 17, 6, 28, 37, 487, DateTimeKind.Local).AddTicks(8027));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 17, 6, 43, 44, 387, DateTimeKind.Local).AddTicks(5718),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 17, 6, 28, 37, 487, DateTimeKind.Local).AddTicks(7962));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "BlockAccountTransactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 17, 6, 43, 44, 387, DateTimeKind.Local).AddTicks(9510),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 17, 6, 28, 37, 488, DateTimeKind.Local).AddTicks(1525));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BlockAccountTransactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 17, 6, 43, 44, 387, DateTimeKind.Local).AddTicks(9440),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 17, 6, 28, 37, 488, DateTimeKind.Local).AddTicks(1470));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Accounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 17, 6, 43, 44, 387, DateTimeKind.Local).AddTicks(5048),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 17, 6, 28, 37, 487, DateTimeKind.Local).AddTicks(7360));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Accounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 17, 6, 43, 44, 387, DateTimeKind.Local).AddTicks(4963),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 17, 6, 28, 37, 487, DateTimeKind.Local).AddTicks(7301));

            migrationBuilder.AddColumn<string>(
                name: "TypeDescription",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TypeDescription",
                table: "Accounts");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "WithdrawAccountTransactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 17, 6, 28, 37, 488, DateTimeKind.Local).AddTicks(2087),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 17, 6, 43, 44, 388, DateTimeKind.Local).AddTicks(251));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "WithdrawAccountTransactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 17, 6, 28, 37, 488, DateTimeKind.Local).AddTicks(2012),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 17, 6, 43, 44, 388, DateTimeKind.Local).AddTicks(131));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Transactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 17, 6, 28, 37, 488, DateTimeKind.Local).AddTicks(545),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 17, 6, 43, 44, 387, DateTimeKind.Local).AddTicks(8299));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Transactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 17, 6, 28, 37, 488, DateTimeKind.Local).AddTicks(482),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 17, 6, 43, 44, 387, DateTimeKind.Local).AddTicks(8230));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Letters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 17, 6, 28, 37, 487, DateTimeKind.Local).AddTicks(6578),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 17, 6, 43, 44, 387, DateTimeKind.Local).AddTicks(4119));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Letters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 17, 6, 28, 37, 487, DateTimeKind.Local).AddTicks(6453),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 17, 6, 43, 44, 387, DateTimeKind.Local).AddTicks(3969));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "DemandPackets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 17, 6, 28, 37, 487, DateTimeKind.Local).AddTicks(8392),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 17, 6, 43, 44, 387, DateTimeKind.Local).AddTicks(6187));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DemandPackets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 17, 6, 28, 37, 487, DateTimeKind.Local).AddTicks(8309),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 17, 6, 43, 44, 387, DateTimeKind.Local).AddTicks(6122));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 17, 6, 28, 37, 487, DateTimeKind.Local).AddTicks(8027),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 17, 6, 43, 44, 387, DateTimeKind.Local).AddTicks(5795));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 17, 6, 28, 37, 487, DateTimeKind.Local).AddTicks(7962),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 17, 6, 43, 44, 387, DateTimeKind.Local).AddTicks(5718));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "BlockAccountTransactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 17, 6, 28, 37, 488, DateTimeKind.Local).AddTicks(1525),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 17, 6, 43, 44, 387, DateTimeKind.Local).AddTicks(9510));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BlockAccountTransactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 17, 6, 28, 37, 488, DateTimeKind.Local).AddTicks(1470),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 17, 6, 43, 44, 387, DateTimeKind.Local).AddTicks(9440));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Accounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 17, 6, 28, 37, 487, DateTimeKind.Local).AddTicks(7360),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 17, 6, 43, 44, 387, DateTimeKind.Local).AddTicks(5048));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Accounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 17, 6, 28, 37, 487, DateTimeKind.Local).AddTicks(7301),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 17, 6, 43, 44, 387, DateTimeKind.Local).AddTicks(4963));
        }
    }
}
