﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tutor.Infra.Migrations
{
    /// <inheritdoc />
    public partial class NovaDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "BIRTH_DATE",
                table: "TB_TUTOR",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateOnly>(
                name: "BIRTH_DATE",
                table: "TB_TUTOR",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");
        }
    }
}
