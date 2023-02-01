using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AccountManagement.Persistence.Migrations
{
    public partial class ChangeNameGuidColumnToTraceCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Guid",
                table: "DemandPackets",
                newName: "TraceCode");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "WithdrawAccountTransactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 17, 0, 57, 33, 595, DateTimeKind.Local).AddTicks(1022),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 17, 0, 30, 1, 602, DateTimeKind.Local).AddTicks(1378));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "WithdrawAccountTransactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 17, 0, 57, 33, 595, DateTimeKind.Local).AddTicks(971),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 17, 0, 30, 1, 602, DateTimeKind.Local).AddTicks(1292));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Transactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 17, 0, 57, 33, 594, DateTimeKind.Local).AddTicks(9338),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 17, 0, 30, 1, 601, DateTimeKind.Local).AddTicks(8957));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Transactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 17, 0, 57, 33, 594, DateTimeKind.Local).AddTicks(9252),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 17, 0, 30, 1, 601, DateTimeKind.Local).AddTicks(8885));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Letters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 17, 0, 57, 33, 594, DateTimeKind.Local).AddTicks(5164),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 17, 0, 30, 1, 601, DateTimeKind.Local).AddTicks(4780));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Letters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 17, 0, 57, 33, 594, DateTimeKind.Local).AddTicks(4985),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 17, 0, 30, 1, 601, DateTimeKind.Local).AddTicks(4627));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "DemandPackets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 17, 0, 57, 33, 594, DateTimeKind.Local).AddTicks(7316),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 17, 0, 30, 1, 601, DateTimeKind.Local).AddTicks(6846));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DemandPackets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 17, 0, 57, 33, 594, DateTimeKind.Local).AddTicks(7226),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 17, 0, 30, 1, 601, DateTimeKind.Local).AddTicks(6751));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 17, 0, 57, 33, 594, DateTimeKind.Local).AddTicks(6904),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 17, 0, 30, 1, 601, DateTimeKind.Local).AddTicks(6460));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 17, 0, 57, 33, 594, DateTimeKind.Local).AddTicks(6844),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 17, 0, 30, 1, 601, DateTimeKind.Local).AddTicks(6399));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "BlockAccountTransactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 17, 0, 57, 33, 595, DateTimeKind.Local).AddTicks(406),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 17, 0, 30, 1, 602, DateTimeKind.Local).AddTicks(641));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BlockAccountTransactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 17, 0, 57, 33, 595, DateTimeKind.Local).AddTicks(295),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 17, 0, 30, 1, 602, DateTimeKind.Local).AddTicks(537));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Accounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 17, 0, 57, 33, 594, DateTimeKind.Local).AddTicks(6130),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 17, 0, 30, 1, 601, DateTimeKind.Local).AddTicks(5720));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Accounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 17, 0, 57, 33, 594, DateTimeKind.Local).AddTicks(6074),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 17, 0, 30, 1, 601, DateTimeKind.Local).AddTicks(5630));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TraceCode",
                table: "DemandPackets",
                newName: "Guid");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "WithdrawAccountTransactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 17, 0, 30, 1, 602, DateTimeKind.Local).AddTicks(1378),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 17, 0, 57, 33, 595, DateTimeKind.Local).AddTicks(1022));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "WithdrawAccountTransactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 17, 0, 30, 1, 602, DateTimeKind.Local).AddTicks(1292),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 17, 0, 57, 33, 595, DateTimeKind.Local).AddTicks(971));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Transactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 17, 0, 30, 1, 601, DateTimeKind.Local).AddTicks(8957),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 17, 0, 57, 33, 594, DateTimeKind.Local).AddTicks(9338));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Transactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 17, 0, 30, 1, 601, DateTimeKind.Local).AddTicks(8885),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 17, 0, 57, 33, 594, DateTimeKind.Local).AddTicks(9252));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Letters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 17, 0, 30, 1, 601, DateTimeKind.Local).AddTicks(4780),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 17, 0, 57, 33, 594, DateTimeKind.Local).AddTicks(5164));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Letters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 17, 0, 30, 1, 601, DateTimeKind.Local).AddTicks(4627),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 17, 0, 57, 33, 594, DateTimeKind.Local).AddTicks(4985));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "DemandPackets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 17, 0, 30, 1, 601, DateTimeKind.Local).AddTicks(6846),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 17, 0, 57, 33, 594, DateTimeKind.Local).AddTicks(7316));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DemandPackets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 17, 0, 30, 1, 601, DateTimeKind.Local).AddTicks(6751),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 17, 0, 57, 33, 594, DateTimeKind.Local).AddTicks(7226));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 17, 0, 30, 1, 601, DateTimeKind.Local).AddTicks(6460),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 17, 0, 57, 33, 594, DateTimeKind.Local).AddTicks(6904));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 17, 0, 30, 1, 601, DateTimeKind.Local).AddTicks(6399),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 17, 0, 57, 33, 594, DateTimeKind.Local).AddTicks(6844));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "BlockAccountTransactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 17, 0, 30, 1, 602, DateTimeKind.Local).AddTicks(641),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 17, 0, 57, 33, 595, DateTimeKind.Local).AddTicks(406));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BlockAccountTransactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 17, 0, 30, 1, 602, DateTimeKind.Local).AddTicks(537),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 17, 0, 57, 33, 595, DateTimeKind.Local).AddTicks(295));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Accounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 17, 0, 30, 1, 601, DateTimeKind.Local).AddTicks(5720),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 17, 0, 57, 33, 594, DateTimeKind.Local).AddTicks(6130));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Accounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 17, 0, 30, 1, 601, DateTimeKind.Local).AddTicks(5630),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 17, 0, 57, 33, 594, DateTimeKind.Local).AddTicks(6074));
        }
    }
}
