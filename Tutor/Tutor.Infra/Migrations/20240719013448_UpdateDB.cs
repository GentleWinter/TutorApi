using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tutor.Infra.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tutor",
                table: "Tutor");

            migrationBuilder.RenameTable(
                name: "Tutor",
                newName: "TB_TUTOR");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "TB_TUTOR",
                newName: "PASSWORD");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "TB_TUTOR",
                newName: "NAME");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "TB_TUTOR",
                newName: "EMAIL");

            migrationBuilder.RenameColumn(
                name: "Document",
                table: "TB_TUTOR",
                newName: "DOCUMENT");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TB_TUTOR",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "BirthDate",
                table: "TB_TUTOR",
                newName: "BIRTH_DATE");

            migrationBuilder.AlterColumn<string>(
                name: "PASSWORD",
                table: "TB_TUTOR",
                type: "character varying(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "NAME",
                table: "TB_TUTOR",
                type: "character varying(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "EMAIL",
                table: "TB_TUTOR",
                type: "character varying(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "DOCUMENT",
                table: "TB_TUTOR",
                type: "character varying(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_TUTOR",
                table: "TB_TUTOR",
                column: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_TUTOR",
                table: "TB_TUTOR");

            migrationBuilder.RenameTable(
                name: "TB_TUTOR",
                newName: "Tutor");

            migrationBuilder.RenameColumn(
                name: "PASSWORD",
                table: "Tutor",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "NAME",
                table: "Tutor",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "EMAIL",
                table: "Tutor",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "DOCUMENT",
                table: "Tutor",
                newName: "Document");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Tutor",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "BIRTH_DATE",
                table: "Tutor",
                newName: "BirthDate");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Tutor",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tutor",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Tutor",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Document",
                table: "Tutor",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tutor",
                table: "Tutor",
                column: "Id");
        }
    }
}
