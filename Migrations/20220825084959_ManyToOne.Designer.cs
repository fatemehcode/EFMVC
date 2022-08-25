﻿// <auto-generated />
using EFMVC.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFMVC.Migrations
{
    [DbContext(typeof(MVCContext))]
    [Migration("20220825084959_ManyToOne")]
    partial class ManyToOne
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EFMVC.Models.Subject", b =>
                {
                    b.Property<int>("SubjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubjectID"), 1L, 1);

                    b.Property<int>("SubjectCredits")
                        .HasColumnType("int");

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubjectTerm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubjectID");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("EFMVC.Models.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeacherId"), 1L, 1);

                    b.Property<int>("SubjectsSubjectID")
                        .HasColumnType("int");

                    b.Property<string>("TeacherAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeacherAge")
                        .HasColumnType("int");

                    b.Property<string>("TeacherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeacherId");

                    b.HasIndex("SubjectsSubjectID");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("EFMVC.Models.Teacher", b =>
                {
                    b.HasOne("EFMVC.Models.Subject", "Subjects")
                        .WithMany("SubjectTeachers")
                        .HasForeignKey("SubjectsSubjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subjects");
                });

            modelBuilder.Entity("EFMVC.Models.Subject", b =>
                {
                    b.Navigation("SubjectTeachers");
                });
#pragma warning restore 612, 618
        }
    }
}
