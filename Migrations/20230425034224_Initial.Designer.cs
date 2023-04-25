﻿// <auto-generated />
using System;
using Final.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Final.Migrations
{
    [DbContext(typeof(EntertainmentAgencyExampleContext))]
    [Migration("20230425034224_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("Final.Models.Agent", b =>
                {
                    b.Property<long>("AgentId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("AgentID");

                    b.Property<string>("AgtCity")
                        .HasColumnType("TEXT");

                    b.Property<string>("AgtFirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("AgtLastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("AgtPhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("AgtState")
                        .HasColumnType("TEXT");

                    b.Property<string>("AgtStreetAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("AgtZipCode")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("CommissionRate")
                        .HasColumnType("NUMERIC");

                    b.Property<string>("DateHired")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Salary")
                        .HasColumnType("NUMERIC");

                    b.HasKey("AgentId");

                    b.ToTable("Agents");
                });

            modelBuilder.Entity("Final.Models.Customer", b =>
                {
                    b.Property<long>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("CustomerID");

                    b.Property<string>("CustCity")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustFirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustLastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustPhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustState")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustStreetAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustZipCode")
                        .HasColumnType("TEXT");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Final.Models.Engagement", b =>
                {
                    b.Property<long>("EngagementNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long?>("AgentId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("AgentID");

                    b.Property<byte[]>("ContractPrice")
                        .HasColumnType("NUMERIC");

                    b.Property<long?>("CustomerId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("CustomerID");

                    b.Property<string>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<long?>("EntertainerId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("EntertainerID");

                    b.Property<string>("StartDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("StartTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("StopTime")
                        .HasColumnType("TEXT");

                    b.HasKey("EngagementNumber");

                    b.ToTable("Engagements");
                });

            modelBuilder.Entity("Final.Models.Entertainer", b =>
                {
                    b.Property<long>("EntertainerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("EntertainerID");

                    b.Property<string>("DateEntered")
                        .HasColumnType("TEXT");

                    b.Property<string>("EntCity")
                        .HasColumnType("TEXT");

                    b.Property<string>("EntEmailAddress")
                        .HasColumnType("TEXT")
                        .HasColumnName("EntEMailAddress");

                    b.Property<string>("EntPhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("EntSsn")
                        .HasColumnType("TEXT")
                        .HasColumnName("EntSSN");

                    b.Property<string>("EntStageName")
                        .HasColumnType("TEXT");

                    b.Property<string>("EntState")
                        .HasColumnType("TEXT");

                    b.Property<string>("EntStreetAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("EntWebPage")
                        .HasColumnType("TEXT");

                    b.Property<string>("EntZipCode")
                        .HasColumnType("TEXT");

                    b.HasKey("EntertainerId");

                    b.ToTable("Entertainers");
                });

            modelBuilder.Entity("Final.Models.EntertainerMember", b =>
                {
                    b.Property<long?>("EntertainerId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("EntertainerID");

                    b.Property<long?>("MemberId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("MemberID");

                    b.Property<long?>("Status")
                        .HasColumnType("INTEGER");

                    b.ToTable("Entertainer_Members");
                });

            modelBuilder.Entity("Final.Models.EntertainerStyle", b =>
                {
                    b.Property<long?>("EntertainerId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("EntertainerID");

                    b.Property<long?>("StyleId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("StyleID");

                    b.Property<long?>("StyleStrength")
                        .HasColumnType("INTEGER");

                    b.ToTable("Entertainer_Styles");
                });

            modelBuilder.Entity("Final.Models.Member", b =>
                {
                    b.Property<long>("MemberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("MemberID");

                    b.Property<string>("Gender")
                        .HasColumnType("TEXT");

                    b.Property<string>("MbrFirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("MbrLastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("MbrPhoneNumber")
                        .HasColumnType("TEXT");

                    b.HasKey("MemberId");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("Final.Models.MusicalPreference", b =>
                {
                    b.Property<long?>("CustomerId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("CustomerID");

                    b.Property<long?>("PreferenceSeq")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("StyleId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("StyleID");

                    b.ToTable("Musical_Preferences");
                });

            modelBuilder.Entity("Final.Models.MusicalStyle", b =>
                {
                    b.Property<long?>("StyleId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("StyleID");

                    b.Property<string>("StyleName")
                        .HasColumnType("TEXT");

                    b.ToTable("Musical_Styles");
                });

            modelBuilder.Entity("Final.Models.ZtblDay", b =>
                {
                    b.Property<string>("DateField")
                        .HasColumnType("TEXT");

                    b.ToTable("ztblDays");
                });

            modelBuilder.Entity("Final.Models.ZtblMonth", b =>
                {
                    b.Property<long?>("April")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("August")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("December")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("February")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("January")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("July")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("June")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("March")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("May")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MonthEnd")
                        .HasColumnType("TEXT");

                    b.Property<long?>("MonthNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MonthStart")
                        .HasColumnType("TEXT");

                    b.Property<string>("MonthYear")
                        .HasColumnType("TEXT");

                    b.Property<long?>("November")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("October")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("September")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("YearNumber")
                        .HasColumnType("INTEGER");

                    b.ToTable("ztblMonths");
                });

            modelBuilder.Entity("Final.Models.ZtblSkipLabel", b =>
                {
                    b.Property<long?>("LabelCount")
                        .HasColumnType("INTEGER");

                    b.ToTable("ztblSkipLabels");
                });

            modelBuilder.Entity("Final.Models.ZtblWeek", b =>
                {
                    b.Property<string>("WeekEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("WeekStart")
                        .HasColumnType("TEXT");

                    b.ToTable("ztblWeeks");
                });
#pragma warning restore 612, 618
        }
    }
}
