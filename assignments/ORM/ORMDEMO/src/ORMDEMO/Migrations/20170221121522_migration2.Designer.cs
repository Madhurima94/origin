using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ORMDEMO;

namespace ORMDEMO.Migrations
{
    [DbContext(typeof(Model))]
    [Migration("20170221121522_migration2")]
    partial class migration2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ORMDEMO.ProductTable", b =>
                {
                    b.Property<int>("PID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("HomePageUrl");

                    b.Property<string>("ProductDescription");

                    b.Property<string>("ProductName");

                    b.HasKey("PID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ORMDEMO.UpdateTable", b =>
                {
                    b.Property<int>("UpdateID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ProductTablePID");

                    b.Property<string>("UpdateDescription");

                    b.Property<string>("UpdateName");

                    b.HasKey("UpdateID");

                    b.HasIndex("ProductTablePID");

                    b.ToTable("Updates");
                });

            modelBuilder.Entity("ORMDEMO.UpdateTable", b =>
                {
                    b.HasOne("ORMDEMO.ProductTable")
                        .WithMany("UpdateTable")
                        .HasForeignKey("ProductTablePID");
                });
        }
    }
}
