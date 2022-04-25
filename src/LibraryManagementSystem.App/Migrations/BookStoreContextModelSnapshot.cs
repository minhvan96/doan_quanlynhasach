﻿// <auto-generated />
using System;
using BookStoreManagementSystem.App.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookStoreManagementSystem.App.Migrations
{
    [DbContext(typeof(BookStoreContext))]
    partial class BookStoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.3");

            modelBuilder.Entity("BookStoreManagementSystem.App.Domain.Author", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("UpdatedDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Authors", (string)null);
                });

            modelBuilder.Entity("BookStoreManagementSystem.App.Domain.Book", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("AuthorId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("TypeId")
                        .HasColumnType("TEXT");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("UpdatedDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("TypeId");

                    b.ToTable("Books", (string)null);
                });

            modelBuilder.Entity("BookStoreManagementSystem.App.Domain.BookStore", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("UpdatedDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("BookStores", (string)null);
                });

            modelBuilder.Entity("BookStoreManagementSystem.App.Domain.BookStoreStorage", b =>
                {
                    b.Property<Guid>("BookId")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("BookStoreId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Availability")
                        .HasColumnType("INTEGER");

                    b.Property<Guid?>("BookId1")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("BookStoreId1")
                        .HasColumnType("TEXT");

                    b.HasKey("BookId", "BookStoreId");

                    b.HasIndex("BookId1");

                    b.HasIndex("BookStoreId");

                    b.HasIndex("BookStoreId1");

                    b.ToTable("BookStoreStorages", (string)null);
                });

            modelBuilder.Entity("BookStoreManagementSystem.App.Domain.BookType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("UpdatedDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("BookTypes", (string)null);
                });

            modelBuilder.Entity("BookStoreManagementSystem.App.Domain.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("UpdatedDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Customers", (string)null);
                });

            modelBuilder.Entity("BookStoreManagementSystem.App.Domain.Identity.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("UpdatedDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Roles", (string)null);
                });

            modelBuilder.Entity("BookStoreManagementSystem.App.Domain.Identity.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("UpdatedDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("BookStoreManagementSystem.App.Domain.Identity.UserRole", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles", (string)null);
                });

            modelBuilder.Entity("BookStoreManagementSystem.App.Domain.Receipt", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset>("SoldDate")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("TEXT");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("UpdatedDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Receipts", (string)null);
                });

            modelBuilder.Entity("BookStoreManagementSystem.App.Domain.ReceiptDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("BookId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Count")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("ReceiptId")
                        .HasColumnType("TEXT");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("UpdatedDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ReceiptId");

                    b.ToTable("ReceiptDetails", (string)null);
                });

            modelBuilder.Entity("BookStoreManagementSystem.App.Domain.Book", b =>
                {
                    b.HasOne("BookStoreManagementSystem.App.Domain.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookStoreManagementSystem.App.Domain.BookType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("BookStoreManagementSystem.App.Domain.BookStoreStorage", b =>
                {
                    b.HasOne("BookStoreManagementSystem.App.Domain.Book", null)
                        .WithMany("BookStoreStorages")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookStoreManagementSystem.App.Domain.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId1");

                    b.HasOne("BookStoreManagementSystem.App.Domain.BookStore", null)
                        .WithMany()
                        .HasForeignKey("BookStoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookStoreManagementSystem.App.Domain.BookStore", null)
                        .WithMany("BookStoreStorages")
                        .HasForeignKey("BookStoreId1");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("BookStoreManagementSystem.App.Domain.Identity.UserRole", b =>
                {
                    b.HasOne("BookStoreManagementSystem.App.Domain.Identity.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookStoreManagementSystem.App.Domain.Identity.User", "User")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BookStoreManagementSystem.App.Domain.Receipt", b =>
                {
                    b.HasOne("BookStoreManagementSystem.App.Domain.Customer", null)
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookStoreManagementSystem.App.Domain.ReceiptDetail", b =>
                {
                    b.HasOne("BookStoreManagementSystem.App.Domain.Receipt", null)
                        .WithMany("ReceiptDetail")
                        .HasForeignKey("ReceiptId");
                });

            modelBuilder.Entity("BookStoreManagementSystem.App.Domain.Book", b =>
                {
                    b.Navigation("BookStoreStorages");
                });

            modelBuilder.Entity("BookStoreManagementSystem.App.Domain.BookStore", b =>
                {
                    b.Navigation("BookStoreStorages");
                });

            modelBuilder.Entity("BookStoreManagementSystem.App.Domain.Identity.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("BookStoreManagementSystem.App.Domain.Identity.User", b =>
                {
                    b.Navigation("Roles");
                });

            modelBuilder.Entity("BookStoreManagementSystem.App.Domain.Receipt", b =>
                {
                    b.Navigation("ReceiptDetail");
                });
#pragma warning restore 612, 618
        }
    }
}
