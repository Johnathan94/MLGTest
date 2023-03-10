// <auto-generated />
using System;
using MLGTest.DataHelpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MLGTest.Migrations
{
    [DbContext(typeof(MLGDataContext))]
    partial class MLGDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MLGTest.Entities.Department", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Engineering"
                        },
                        new
                        {
                            ID = 2,
                            Name = "Accounting"
                        },
                        new
                        {
                            ID = 3,
                            Name = "Managment"
                        },
                        new
                        {
                            ID = 4,
                            Name = "Team Leads"
                        },
                        new
                        {
                            ID = 5,
                            Name = "Businuess Team"
                        });
                });

            modelBuilder.Entity("MLGTest.Entities.Employee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("Department_ID")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.HasIndex("Department_ID");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            DepartmentID = 1,
                            Email = "Example@example.com",
                            HireDate = new DateTime(2022, 7, 22, 21, 9, 8, 620, DateTimeKind.Local).AddTicks(644),
                            Name = "Jonathan"
                        },
                        new
                        {
                            ID = 2,
                            DepartmentID = 2,
                            Email = "Example@example.com",
                            HireDate = new DateTime(2022, 8, 22, 21, 9, 8, 620, DateTimeKind.Local).AddTicks(667),
                            Name = "Adam"
                        },
                        new
                        {
                            ID = 3,
                            DepartmentID = 1,
                            Email = "Example@example.com",
                            HireDate = new DateTime(2022, 9, 22, 21, 9, 8, 620, DateTimeKind.Local).AddTicks(676),
                            Name = "Ahmed"
                        },
                        new
                        {
                            ID = 4,
                            DepartmentID = 1,
                            Email = "Example@example.com",
                            HireDate = new DateTime(2022, 11, 22, 21, 9, 8, 620, DateTimeKind.Local).AddTicks(684),
                            Name = "Jon"
                        },
                        new
                        {
                            ID = 5,
                            DepartmentID = 5,
                            Email = "Example@example.com",
                            HireDate = new DateTime(2022, 5, 22, 21, 9, 8, 620, DateTimeKind.Local).AddTicks(692),
                            Name = "Nawal"
                        });
                });

            modelBuilder.Entity("MLGTest.Entities.Employee", b =>
                {
                    b.HasOne("MLGTest.Entities.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("Department_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("MLGTest.Entities.Department", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
