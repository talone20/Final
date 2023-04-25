﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Final.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agents",
                columns: table => new
                {
                    AgentID = table.Column<long>(type: "INTEGER", nullable: false),
                    AgtFirstName = table.Column<string>(type: "TEXT", nullable: true),
                    AgtLastName = table.Column<string>(type: "TEXT", nullable: true),
                    AgtStreetAddress = table.Column<string>(type: "TEXT", nullable: true),
                    AgtCity = table.Column<string>(type: "TEXT", nullable: true),
                    AgtState = table.Column<string>(type: "TEXT", nullable: true),
                    AgtZipCode = table.Column<string>(type: "TEXT", nullable: true),
                    AgtPhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    DateHired = table.Column<string>(type: "TEXT", nullable: true),
                    Salary = table.Column<byte[]>(type: "NUMERIC", nullable: true),
                    CommissionRate = table.Column<byte[]>(type: "NUMERIC", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agents", x => x.AgentID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CustFirstName = table.Column<string>(type: "TEXT", nullable: true),
                    CustLastName = table.Column<string>(type: "TEXT", nullable: true),
                    CustStreetAddress = table.Column<string>(type: "TEXT", nullable: true),
                    CustCity = table.Column<string>(type: "TEXT", nullable: true),
                    CustState = table.Column<string>(type: "TEXT", nullable: true),
                    CustZipCode = table.Column<string>(type: "TEXT", nullable: true),
                    CustPhoneNumber = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Engagements",
                columns: table => new
                {
                    EngagementNumber = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StartDate = table.Column<string>(type: "TEXT", nullable: true),
                    EndDate = table.Column<string>(type: "TEXT", nullable: true),
                    StartTime = table.Column<string>(type: "TEXT", nullable: true),
                    StopTime = table.Column<string>(type: "TEXT", nullable: true),
                    ContractPrice = table.Column<byte[]>(type: "NUMERIC", nullable: true),
                    CustomerID = table.Column<long>(type: "INTEGER", nullable: true),
                    AgentID = table.Column<long>(type: "INTEGER", nullable: true),
                    EntertainerID = table.Column<long>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Engagements", x => x.EngagementNumber);
                });

            migrationBuilder.CreateTable(
                name: "Entertainer_Members",
                columns: table => new
                {
                    EntertainerID = table.Column<long>(type: "INTEGER", nullable: true),
                    MemberID = table.Column<long>(type: "INTEGER", nullable: true),
                    Status = table.Column<long>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Entertainer_Styles",
                columns: table => new
                {
                    EntertainerID = table.Column<long>(type: "INTEGER", nullable: true),
                    StyleID = table.Column<long>(type: "INTEGER", nullable: true),
                    StyleStrength = table.Column<long>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Entertainers",
                columns: table => new
                {
                    EntertainerID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EntStageName = table.Column<string>(type: "TEXT", nullable: true),
                    EntSSN = table.Column<string>(type: "TEXT", nullable: true),
                    EntStreetAddress = table.Column<string>(type: "TEXT", nullable: true),
                    EntCity = table.Column<string>(type: "TEXT", nullable: true),
                    EntState = table.Column<string>(type: "TEXT", nullable: true),
                    EntZipCode = table.Column<string>(type: "TEXT", nullable: true),
                    EntPhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    EntWebPage = table.Column<string>(type: "TEXT", nullable: true),
                    EntEMailAddress = table.Column<string>(type: "TEXT", nullable: true),
                    DateEntered = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entertainers", x => x.EntertainerID);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    MemberID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MbrFirstName = table.Column<string>(type: "TEXT", nullable: true),
                    MbrLastName = table.Column<string>(type: "TEXT", nullable: true),
                    MbrPhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    Gender = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.MemberID);
                });

            migrationBuilder.CreateTable(
                name: "Musical_Preferences",
                columns: table => new
                {
                    CustomerID = table.Column<long>(type: "INTEGER", nullable: true),
                    StyleID = table.Column<long>(type: "INTEGER", nullable: true),
                    PreferenceSeq = table.Column<long>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Musical_Styles",
                columns: table => new
                {
                    StyleID = table.Column<long>(type: "INTEGER", nullable: true),
                    StyleName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ztblDays",
                columns: table => new
                {
                    DateField = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ztblMonths",
                columns: table => new
                {
                    MonthYear = table.Column<string>(type: "TEXT", nullable: true),
                    YearNumber = table.Column<long>(type: "INTEGER", nullable: true),
                    MonthNumber = table.Column<long>(type: "INTEGER", nullable: true),
                    MonthStart = table.Column<string>(type: "TEXT", nullable: true),
                    MonthEnd = table.Column<string>(type: "TEXT", nullable: true),
                    January = table.Column<long>(type: "INTEGER", nullable: true),
                    February = table.Column<long>(type: "INTEGER", nullable: true),
                    March = table.Column<long>(type: "INTEGER", nullable: true),
                    April = table.Column<long>(type: "INTEGER", nullable: true),
                    May = table.Column<long>(type: "INTEGER", nullable: true),
                    June = table.Column<long>(type: "INTEGER", nullable: true),
                    July = table.Column<long>(type: "INTEGER", nullable: true),
                    August = table.Column<long>(type: "INTEGER", nullable: true),
                    September = table.Column<long>(type: "INTEGER", nullable: true),
                    October = table.Column<long>(type: "INTEGER", nullable: true),
                    November = table.Column<long>(type: "INTEGER", nullable: true),
                    December = table.Column<long>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ztblSkipLabels",
                columns: table => new
                {
                    LabelCount = table.Column<long>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ztblWeeks",
                columns: table => new
                {
                    WeekStart = table.Column<string>(type: "TEXT", nullable: true),
                    WeekEnd = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agents");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Engagements");

            migrationBuilder.DropTable(
                name: "Entertainer_Members");

            migrationBuilder.DropTable(
                name: "Entertainer_Styles");

            migrationBuilder.DropTable(
                name: "Entertainers");

            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropTable(
                name: "Musical_Preferences");

            migrationBuilder.DropTable(
                name: "Musical_Styles");

            migrationBuilder.DropTable(
                name: "ztblDays");

            migrationBuilder.DropTable(
                name: "ztblMonths");

            migrationBuilder.DropTable(
                name: "ztblSkipLabels");

            migrationBuilder.DropTable(
                name: "ztblWeeks");
        }
    }
}
