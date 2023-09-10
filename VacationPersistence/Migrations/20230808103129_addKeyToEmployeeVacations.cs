﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VacationPersistence.Migrations
{
    /// <inheritdoc />
    public partial class addKeyToEmployeeVacations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RequestID",
                table: "EmployeeVacations",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RequestID",
                table: "EmployeeVacations");
        }
    }
}
