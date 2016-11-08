using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using QuickUp.HomeTaks.Day2.Models;

namespace QuickUp.HomeTaks.Migrations
{
    [DbContext(typeof(UniverContext))]
    [Migration("20161108063155_migra")]
    partial class migra
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("QuickUp.HomeTaks.Day2.Models.Group", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Faculty");

                    b.Property<int>("Number");

                    b.HasKey("ID");

                    b.ToTable("Group");
                });

            modelBuilder.Entity("QuickUp.HomeTaks.Day2.Models.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("EnrollmentDate");

                    b.Property<string>("FirstMidName");

                    b.Property<int>("GroupId");

                    b.Property<string>("LastName");

                    b.HasKey("ID");

                    b.HasIndex("GroupId");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("QuickUp.HomeTaks.Day2.Models.Student", b =>
                {
                    b.HasOne("QuickUp.HomeTaks.Day2.Models.Group", "Group")
                        .WithMany("Students")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
