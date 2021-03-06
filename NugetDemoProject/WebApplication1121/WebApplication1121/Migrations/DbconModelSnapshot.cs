﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1121;

namespace WebApplication1121.Migrations
{
    [DbContext(typeof(Dbcon))]
    partial class DbconModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AuthorizationModule.Domain.Entities.Permission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<int?>("CreatorUserId");

                    b.Property<int?>("DeleterUserId");

                    b.Property<DateTime?>("DeletionTime");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<int?>("LastModificationUserId");

                    b.Property<string>("Name");

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Permission");
                });

            modelBuilder.Entity("AuthorizationModule.Domain.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<int?>("CreatorUserId");

                    b.Property<int?>("DeleterUserId");

                    b.Property<DateTime?>("DeletionTime");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<int?>("LastModificationUserId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("AuthorizationModule.Domain.Entities.User<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<int?>("CreatorUserId");

                    b.Property<int?>("DeleterUserId");

                    b.Property<DateTime?>("DeletionTime");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<int?>("LastModificationUserId");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("User<int>");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User<int>");
                });

            modelBuilder.Entity("AuthorizationModule.Domain.Entities.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<int?>("CreatorUserId");

                    b.Property<int?>("DeleterUserId");

                    b.Property<DateTime?>("DeletionTime");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<int?>("LastModificationUserId");

                    b.Property<int>("RoleId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRole");
                });

            modelBuilder.Entity("WebApplication1121.Ur", b =>
                {
                    b.HasBaseType("AuthorizationModule.Domain.Entities.User<int>");

                    b.Property<string>("Name");

                    b.Property<string>("UserJa");

                    b.ToTable("Users");

                    b.HasDiscriminator().HasValue("Ur");
                });

            modelBuilder.Entity("AuthorizationModule.Domain.Entities.Permission", b =>
                {
                    b.HasOne("AuthorizationModule.Domain.Entities.Role", "Role")
                        .WithMany("Permissions")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AuthorizationModule.Domain.Entities.UserRole", b =>
                {
                    b.HasOne("AuthorizationModule.Domain.Entities.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AuthorizationModule.Domain.Entities.User<int>", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
