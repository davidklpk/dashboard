﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace student_monitoring_dashboard.Migrations
{
    [DbContext(typeof(DashContext))]
    [Migration("20221128195439_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Assignment", b =>
                {
                    b.Property<int>("assignmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("assignmentID"), 1L, 1);

                    b.Property<DateTime>("HandedInDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("assignmentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("assignmentID");

                    b.ToTable("Assignments");
                });

            modelBuilder.Entity("Course", b =>
                {
                    b.Property<int>("CourseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseID"), 1L, 1);

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CourseID");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("CourseClass", b =>
                {
                    b.Property<int>("ClassID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClassID"), 1L, 1);

                    b.Property<string>("ClassName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClassID");

                    b.ToTable("CourseClasses");
                });

            modelBuilder.Entity("Criteria", b =>
                {
                    b.Property<int>("CriteriaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CriteriaID"), 1L, 1);

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CriteriaName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Grade")
                        .HasColumnType("float");

                    b.Property<string>("KindOfFeedback")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CriteriaID");

                    b.ToTable("Criterias");
                });

            modelBuilder.Entity("Feedback", b =>
                {
                    b.Property<int>("FeedbackID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FeedbackID"), 1L, 1);

                    b.Property<bool>("FinishedFeedback")
                        .HasColumnType("bit");

                    b.Property<bool>("HandedIn")
                        .HasColumnType("bit");

                    b.Property<double>("OverallGrade")
                        .HasColumnType("float");

                    b.Property<bool>("ReadFeedback")
                        .HasColumnType("bit");

                    b.Property<bool>("ReadInstructions")
                        .HasColumnType("bit");

                    b.Property<int>("TimeSpent")
                        .HasColumnType("int");

                    b.Property<int>("TotalReviewComments")
                        .HasColumnType("int");

                    b.Property<bool>("TypeofFeedback")
                        .HasColumnType("bit");

                    b.HasKey("FeedbackID");

                    b.ToTable("Feedbacks");
                });

            modelBuilder.Entity("MediaSite", b =>
                {
                    b.Property<int>("MSID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MSID"), 1L, 1);

                    b.Property<DateTime>("FirstWatched")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastWatched")
                        .HasColumnType("datetime2");

                    b.Property<int>("LiveViews")
                        .HasColumnType("int");

                    b.Property<int>("OnDemandViews")
                        .HasColumnType("int");

                    b.Property<int>("PresentationsWatched")
                        .HasColumnType("int");

                    b.Property<int>("TotalTimeWatched")
                        .HasColumnType("int");

                    b.Property<int>("TotalViews")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MSID");

                    b.ToTable("MediaSites");
                });

            modelBuilder.Entity("Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentID"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Teacher", b =>
                {
                    b.Property<int>("TeacherID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeacherID"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeacherID");

                    b.ToTable("Teachers");
                });
#pragma warning restore 612, 618
        }
    }
}