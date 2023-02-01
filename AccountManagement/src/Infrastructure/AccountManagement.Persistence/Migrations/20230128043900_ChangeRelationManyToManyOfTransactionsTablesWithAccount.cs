using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AccountManagement.Persistence.Migrations
{
    public partial class ChangeRelationManyToManyOfTransactionsTablesWithAccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_WithdrawAccountTransactions_AccountId",
                table: "WithdrawAccountTransactions");

            migrationBuilder.DropIndex(
                name: "IX_BlockAccountTransactions_AccountId",
                table: "BlockAccountTransactions");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "WithdrawAccountTransactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 27, 20, 39, 0, 342, DateTimeKind.Local).AddTicks(1092),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 23, 0, 25, 5, 734, DateTimeKind.Local).AddTicks(5802));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "WithdrawAccountTransactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 27, 20, 39, 0, 342, DateTimeKind.Local).AddTicks(1040),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 23, 0, 25, 5, 734, DateTimeKind.Local).AddTicks(5717));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Transactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 27, 20, 39, 0, 341, DateTimeKind.Local).AddTicks(9703),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 23, 0, 25, 5, 734, DateTimeKind.Local).AddTicks(4193));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Transactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 27, 20, 39, 0, 341, DateTimeKind.Local).AddTicks(9557),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 23, 0, 25, 5, 734, DateTimeKind.Local).AddTicks(4105));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Letters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 27, 20, 39, 0, 341, DateTimeKind.Local).AddTicks(6030),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 23, 0, 25, 5, 734, DateTimeKind.Local).AddTicks(793));

            migrationBuilder.AlterColumn<string>(
                name: "Date",
                table: "Letters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "1/27/2023",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "1/23/2023");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Letters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 27, 20, 39, 0, 341, DateTimeKind.Local).AddTicks(5856),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 23, 0, 25, 5, 734, DateTimeKind.Local).AddTicks(615));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "DemandPackets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 27, 20, 39, 0, 341, DateTimeKind.Local).AddTicks(8063),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 23, 0, 25, 5, 734, DateTimeKind.Local).AddTicks(2881));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DemandPackets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 27, 20, 39, 0, 341, DateTimeKind.Local).AddTicks(7999),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 23, 0, 25, 5, 734, DateTimeKind.Local).AddTicks(2816));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 27, 20, 39, 0, 341, DateTimeKind.Local).AddTicks(7679),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 23, 0, 25, 5, 734, DateTimeKind.Local).AddTicks(2489));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 27, 20, 39, 0, 341, DateTimeKind.Local).AddTicks(7600),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 23, 0, 25, 5, 734, DateTimeKind.Local).AddTicks(2401));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "BlockAccountTransactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 27, 20, 39, 0, 342, DateTimeKind.Local).AddTicks(657),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 23, 0, 25, 5, 734, DateTimeKind.Local).AddTicks(5121));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BlockAccountTransactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 27, 20, 39, 0, 342, DateTimeKind.Local).AddTicks(599),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 23, 0, 25, 5, 734, DateTimeKind.Local).AddTicks(5065));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Accounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 27, 20, 39, 0, 341, DateTimeKind.Local).AddTicks(6961),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 23, 0, 25, 5, 734, DateTimeKind.Local).AddTicks(1717));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Accounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 27, 20, 39, 0, 341, DateTimeKind.Local).AddTicks(6902),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 23, 0, 25, 5, 734, DateTimeKind.Local).AddTicks(1658));

            migrationBuilder.CreateIndex(
                name: "IX_WithdrawAccountTransactions_AccountId",
                table: "WithdrawAccountTransactions",
                column: "AccountId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BlockAccountTransactions_AccountId",
                table: "BlockAccountTransactions",
                column: "AccountId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_WithdrawAccountTransactions_AccountId",
                table: "WithdrawAccountTransactions");

            migrationBuilder.DropIndex(
                name: "IX_BlockAccountTransactions_AccountId",
                table: "BlockAccountTransactions");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "WithdrawAccountTransactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 23, 0, 25, 5, 734, DateTimeKind.Local).AddTicks(5802),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 27, 20, 39, 0, 342, DateTimeKind.Local).AddTicks(1092));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "WithdrawAccountTransactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 23, 0, 25, 5, 734, DateTimeKind.Local).AddTicks(5717),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 27, 20, 39, 0, 342, DateTimeKind.Local).AddTicks(1040));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Transactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 23, 0, 25, 5, 734, DateTimeKind.Local).AddTicks(4193),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 27, 20, 39, 0, 341, DateTimeKind.Local).AddTicks(9703));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Transactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 23, 0, 25, 5, 734, DateTimeKind.Local).AddTicks(4105),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 27, 20, 39, 0, 341, DateTimeKind.Local).AddTicks(9557));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Letters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 23, 0, 25, 5, 734, DateTimeKind.Local).AddTicks(793),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 27, 20, 39, 0, 341, DateTimeKind.Local).AddTicks(6030));

            migrationBuilder.AlterColumn<string>(
                name: "Date",
                table: "Letters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "1/23/2023",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "1/27/2023");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Letters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 23, 0, 25, 5, 734, DateTimeKind.Local).AddTicks(615),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 27, 20, 39, 0, 341, DateTimeKind.Local).AddTicks(5856));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "DemandPackets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 23, 0, 25, 5, 734, DateTimeKind.Local).AddTicks(2881),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 27, 20, 39, 0, 341, DateTimeKind.Local).AddTicks(8063));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DemandPackets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 23, 0, 25, 5, 734, DateTimeKind.Local).AddTicks(2816),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 27, 20, 39, 0, 341, DateTimeKind.Local).AddTicks(7999));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 23, 0, 25, 5, 734, DateTimeKind.Local).AddTicks(2489),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 27, 20, 39, 0, 341, DateTimeKind.Local).AddTicks(7679));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 23, 0, 25, 5, 734, DateTimeKind.Local).AddTicks(2401),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 27, 20, 39, 0, 341, DateTimeKind.Local).AddTicks(7600));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "BlockAccountTransactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 23, 0, 25, 5, 734, DateTimeKind.Local).AddTicks(5121),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 27, 20, 39, 0, 342, DateTimeKind.Local).AddTicks(657));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BlockAccountTransactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 23, 0, 25, 5, 734, DateTimeKind.Local).AddTicks(5065),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 27, 20, 39, 0, 342, DateTimeKind.Local).AddTicks(599));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Accounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 23, 0, 25, 5, 734, DateTimeKind.Local).AddTicks(1717),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 27, 20, 39, 0, 341, DateTimeKind.Local).AddTicks(6961));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Accounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 23, 0, 25, 5, 734, DateTimeKind.Local).AddTicks(1658),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 27, 20, 39, 0, 341, DateTimeKind.Local).AddTicks(6902));

            migrationBuilder.CreateIndex(
                name: "IX_WithdrawAccountTransactions_AccountId",
                table: "WithdrawAccountTransactions",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_BlockAccountTransactions_AccountId",
                table: "BlockAccountTransactions",
                column: "AccountId");
        }
    }
}
