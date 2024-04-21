﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Models;

#nullable disable

namespace WebApplication1.Migrations
{
    [DbContext(typeof(DatLichContext))]
    [Migration("20240421075344_ExtendIdentityUser")]
    partial class ExtendIdentityUser
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ChiTietBacSiThuoc", b =>
                {
                    b.Property<Guid>("BacsiId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("bacsi_id");

                    b.Property<Guid>("MedicineId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("medicine_id");

                    b.HasKey("BacsiId", "MedicineId")
                        .HasName("PK__ChiTietB__87724D04B0BBAD17");

                    b.HasIndex("MedicineId");

                    b.ToTable("ChiTietBacSi_Thuoc", (string)null);
                });

            modelBuilder.Entity("LichHenThuoc", b =>
                {
                    b.Property<Guid>("LichId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("lich_id");

                    b.Property<Guid>("MedicineId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("medicine_id");

                    b.HasKey("LichId", "MedicineId")
                        .HasName("PK__LichHen___8A1DD7D67911FB92");

                    b.HasIndex("MedicineId");

                    b.ToTable("LichHen_Thuoc", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("WebApplication1.Models.BacSi", b =>
                {
                    b.Property<Guid>("BacsiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("bacsi_id")
                        .HasDefaultValueSql("(newid())");

                    b.Property<Guid?>("KhoaId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("khoa_id");

                    b.Property<Guid?>("NguoidungId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("nguoidung_id");

                    b.Property<Guid?>("PhongkhamId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("phongkham_id");

                    b.Property<string>("Tenbacsi")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("tenbacsi");

                    b.HasKey("BacsiId")
                        .HasName("PK__BacSi__290305EF5BE6F25B");

                    b.HasIndex("KhoaId");

                    b.HasIndex("PhongkhamId");

                    b.HasIndex(new[] { "NguoidungId" }, "UQ__BacSi__813FDB76BD7BB273")
                        .IsUnique()
                        .HasFilter("[nguoidung_id] IS NOT NULL");

                    b.ToTable("BacSi", (string)null);
                });

            modelBuilder.Entity("WebApplication1.Models.BenhNhan", b =>
                {
                    b.Property<Guid>("BenhnhanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("benhnhan_id")
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("Diachi")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("diachi");

                    b.Property<DateOnly?>("Ngaysinh")
                        .HasColumnType("date")
                        .HasColumnName("ngaysinh");

                    b.Property<Guid?>("NguoidungId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("nguoidung_id");

                    b.Property<string>("Sdt")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("sdt");

                    b.Property<string>("Tenbenhnhan")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("tenbenhnhan");

                    b.HasKey("BenhnhanId")
                        .HasName("PK__BenhNhan__9A4F702351A07CAE");

                    b.HasIndex(new[] { "NguoidungId" }, "UQ__BenhNhan__813FDB76AE736D61")
                        .IsUnique()
                        .HasFilter("[nguoidung_id] IS NOT NULL");

                    b.ToTable("BenhNhan", (string)null);
                });

            modelBuilder.Entity("WebApplication1.Models.ChiTietBacSi", b =>
                {
                    b.Property<Guid>("BacsiId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("bacsi_id");

                    b.Property<Guid?>("KhoaId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("khoa_id");

                    b.Property<Guid?>("PhongkhamId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("phongkham_id");

                    b.Property<int?>("SoNamKinhNghiem")
                        .HasColumnType("int")
                        .HasColumnName("so_nam_kinh_nghiem");

                    b.Property<string>("TrinhDo")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("trinh_do");

                    b.HasKey("BacsiId")
                        .HasName("PK__ChiTietB__290305EF2E8D6195");

                    b.HasIndex("KhoaId");

                    b.HasIndex("PhongkhamId");

                    b.ToTable("ChiTietBacSi", (string)null);
                });

            modelBuilder.Entity("WebApplication1.Models.ChuyenKhoa", b =>
                {
                    b.Property<Guid>("KhoaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("khoa_id")
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("Tenkhoa")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("tenkhoa");

                    b.HasKey("KhoaId")
                        .HasName("PK__ChuyenKh__87386DE5F59291DA");

                    b.ToTable("ChuyenKhoa", (string)null);
                });

            modelBuilder.Entity("WebApplication1.Models.LichHen", b =>
                {
                    b.Property<Guid>("LichId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("lich_id")
                        .HasDefaultValueSql("(newid())");

                    b.Property<Guid?>("BacsiId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("bacsi_id");

                    b.Property<Guid?>("BenhnhanId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("benhnhan_id");

                    b.Property<DateTime?>("Ngayhen")
                        .HasColumnType("datetime")
                        .HasColumnName("ngayhen");

                    b.Property<int?>("StatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1)
                        .HasColumnName("status_id");

                    b.HasKey("LichId")
                        .HasName("PK__LichHen__246C9F3D2A52D96C");

                    b.HasIndex("BacsiId");

                    b.HasIndex("BenhnhanId");

                    b.HasIndex("StatusId");

                    b.ToTable("LichHen", (string)null);
                });

            modelBuilder.Entity("WebApplication1.Models.LichSuKham", b =>
                {
                    b.Property<Guid>("HistoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("history_id")
                        .HasDefaultValueSql("(newid())");

                    b.Property<Guid?>("BenhnhanId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("benhnhan_id");

                    b.Property<string>("Donthuoc")
                        .HasColumnType("text")
                        .HasColumnName("donthuoc");

                    b.Property<Guid?>("LichId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("lich_id");

                    b.Property<Guid?>("MedicineId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("medicine_id");

                    b.HasKey("HistoryId")
                        .HasName("PK__LichSuKh__096AA2E996E4EC9D");

                    b.HasIndex("BenhnhanId");

                    b.HasIndex("LichId");

                    b.HasIndex("MedicineId");

                    b.ToTable("LichSuKham", (string)null);
                });

            modelBuilder.Entity("WebApplication1.Models.NguoiDung", b =>
                {
                    b.Property<Guid>("NguoidungId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("nguoidung_id")
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("email");

                    b.Property<string>("Matkhau")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("matkhau");

                    b.Property<int>("RoleId")
                        .HasColumnType("int")
                        .HasColumnName("role_id");

                    b.Property<string>("Tennguoidung")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("tennguoidung");

                    b.HasKey("NguoidungId")
                        .HasName("PK__NguoiDun__813FDB77FF5447D5");

                    b.HasIndex("RoleId");

                    b.HasIndex(new[] { "Email" }, "UQ__NguoiDun__AB6E61643681693C")
                        .IsUnique();

                    b.HasIndex(new[] { "Tennguoidung" }, "UQ__NguoiDun__CED324380D411465")
                        .IsUnique();

                    b.ToTable("NguoiDung", (string)null);
                });

            modelBuilder.Entity("WebApplication1.Models.PhongKham", b =>
                {
                    b.Property<Guid>("PhongkhamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("phongkham_id")
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("Diachi")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("diachi");

                    b.Property<string>("Sdt")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("sdt");

                    b.Property<string>("Tenphong")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("tenphong");

                    b.HasKey("PhongkhamId")
                        .HasName("PK__PhongKha__D8EC7B684BAB40A4");

                    b.ToTable("PhongKham", (string)null);
                });

            modelBuilder.Entity("WebApplication1.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .HasColumnType("int")
                        .HasColumnName("role_id");

                    b.Property<string>("RoleName")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("role_name");

                    b.HasKey("RoleId")
                        .HasName("PK__Roles__760965CCBC42B4C7");

                    b.HasIndex(new[] { "RoleName" }, "UQ__Roles__783254B147FAC60A")
                        .IsUnique()
                        .HasFilter("[role_name] IS NOT NULL");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("WebApplication1.Models.ThoiGianTrong", b =>
                {
                    b.Property<Guid>("ThoigianId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("thoigian_id")
                        .HasDefaultValueSql("(newid())");

                    b.Property<Guid?>("BacsiId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("bacsi_id");

                    b.Property<string>("Calam")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("calam");

                    b.Property<DateOnly?>("Ngaygio")
                        .HasColumnType("date")
                        .HasColumnName("ngaygio");

                    b.HasKey("ThoigianId")
                        .HasName("PK__ThoiGian__D9668A932B24FC5D");

                    b.HasIndex("BacsiId");

                    b.ToTable("ThoiGianTrong", (string)null);
                });

            modelBuilder.Entity("WebApplication1.Models.Thuoc", b =>
                {
                    b.Property<Guid>("MedicineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("medicine_id")
                        .HasDefaultValueSql("(newid())");

                    b.Property<decimal?>("Giathuoc")
                        .HasColumnType("decimal(10, 2)")
                        .HasColumnName("giathuoc");

                    b.Property<string>("Mota")
                        .HasColumnType("text")
                        .HasColumnName("mota");

                    b.Property<string>("Tenthuoc")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("tenthuoc");

                    b.HasKey("MedicineId")
                        .HasName("PK__Thuoc__E7148EBBC52436B4");

                    b.ToTable("Thuoc", (string)null);
                });

            modelBuilder.Entity("WebApplication1.Models.TinhTangLichHen", b =>
                {
                    b.Property<int>("StatusId")
                        .HasColumnType("int")
                        .HasColumnName("status_id");

                    b.Property<string>("StatusName")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("status_name");

                    b.HasKey("StatusId")
                        .HasName("PK__TinhTang__3683B5310FE9D7E8");

                    b.HasIndex(new[] { "StatusName" }, "UQ__TinhTang__501B37534BB6DB56")
                        .IsUnique()
                        .HasFilter("[status_name] IS NOT NULL");

                    b.ToTable("TinhTangLichHen", (string)null);
                });

            modelBuilder.Entity("ChiTietBacSiThuoc", b =>
                {
                    b.HasOne("WebApplication1.Models.BacSi", null)
                        .WithMany()
                        .HasForeignKey("BacsiId")
                        .IsRequired()
                        .HasConstraintName("FK__ChiTietBa__bacsi__0B91BA14");

                    b.HasOne("WebApplication1.Models.Thuoc", null)
                        .WithMany()
                        .HasForeignKey("MedicineId")
                        .IsRequired()
                        .HasConstraintName("FK__ChiTietBa__medic__0C85DE4D");
                });

            modelBuilder.Entity("LichHenThuoc", b =>
                {
                    b.HasOne("WebApplication1.Models.LichHen", null)
                        .WithMany()
                        .HasForeignKey("LichId")
                        .IsRequired()
                        .HasConstraintName("FK__LichHen_T__lich___07C12930");

                    b.HasOne("WebApplication1.Models.Thuoc", null)
                        .WithMany()
                        .HasForeignKey("MedicineId")
                        .IsRequired()
                        .HasConstraintName("FK__LichHen_T__medic__08B54D69");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplication1.Models.BacSi", b =>
                {
                    b.HasOne("WebApplication1.Models.ChuyenKhoa", "Khoa")
                        .WithMany("BacSis")
                        .HasForeignKey("KhoaId")
                        .HasConstraintName("FK__BacSi__khoa_id__5AEE82B9");

                    b.HasOne("WebApplication1.Models.NguoiDung", "Nguoidung")
                        .WithOne("BacSi")
                        .HasForeignKey("WebApplication1.Models.BacSi", "NguoidungId")
                        .HasConstraintName("FK__BacSi__nguoidung__59FA5E80");

                    b.HasOne("WebApplication1.Models.PhongKham", "Phongkham")
                        .WithMany("BacSis")
                        .HasForeignKey("PhongkhamId")
                        .HasConstraintName("FK__BacSi__phongkham__5BE2A6F2");

                    b.Navigation("Khoa");

                    b.Navigation("Nguoidung");

                    b.Navigation("Phongkham");
                });

            modelBuilder.Entity("WebApplication1.Models.BenhNhan", b =>
                {
                    b.HasOne("WebApplication1.Models.NguoiDung", "Nguoidung")
                        .WithOne("BenhNhan")
                        .HasForeignKey("WebApplication1.Models.BenhNhan", "NguoidungId")
                        .HasConstraintName("FK__BenhNhan__nguoid__60A75C0F");

                    b.Navigation("Nguoidung");
                });

            modelBuilder.Entity("WebApplication1.Models.ChiTietBacSi", b =>
                {
                    b.HasOne("WebApplication1.Models.BacSi", "Bacsi")
                        .WithOne("ChiTietBacSi")
                        .HasForeignKey("WebApplication1.Models.ChiTietBacSi", "BacsiId")
                        .IsRequired()
                        .HasConstraintName("FK__ChiTietBa__bacsi__0D7A0286");

                    b.HasOne("WebApplication1.Models.ChuyenKhoa", "Khoa")
                        .WithMany("ChiTietBacSis")
                        .HasForeignKey("KhoaId")
                        .HasConstraintName("FK__ChiTietBa__khoa___787EE5A0");

                    b.HasOne("WebApplication1.Models.PhongKham", "Phongkham")
                        .WithMany("ChiTietBacSis")
                        .HasForeignKey("PhongkhamId")
                        .HasConstraintName("FK__ChiTietBa__phong__797309D9");

                    b.Navigation("Bacsi");

                    b.Navigation("Khoa");

                    b.Navigation("Phongkham");
                });

            modelBuilder.Entity("WebApplication1.Models.LichHen", b =>
                {
                    b.HasOne("WebApplication1.Models.BacSi", "Bacsi")
                        .WithMany("LichHens")
                        .HasForeignKey("BacsiId")
                        .HasConstraintName("FK__LichHen__bacsi_i__693CA210");

                    b.HasOne("WebApplication1.Models.BenhNhan", "Benhnhan")
                        .WithMany("LichHens")
                        .HasForeignKey("BenhnhanId")
                        .HasConstraintName("FK__LichHen__benhnha__68487DD7");

                    b.HasOne("WebApplication1.Models.TinhTangLichHen", "Status")
                        .WithMany("LichHens")
                        .HasForeignKey("StatusId")
                        .HasConstraintName("FK__LichHen__status___6A30C649");

                    b.Navigation("Bacsi");

                    b.Navigation("Benhnhan");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("WebApplication1.Models.LichSuKham", b =>
                {
                    b.HasOne("WebApplication1.Models.BenhNhan", "Benhnhan")
                        .WithMany("LichSuKhams")
                        .HasForeignKey("BenhnhanId")
                        .HasConstraintName("FK__LichSuKha__benhn__6E01572D");

                    b.HasOne("WebApplication1.Models.LichHen", "Lich")
                        .WithMany("LichSuKhams")
                        .HasForeignKey("LichId")
                        .HasConstraintName("FK__LichSuKha__lich___6EF57B66");

                    b.HasOne("WebApplication1.Models.Thuoc", "Medicine")
                        .WithMany("LichSuKhams")
                        .HasForeignKey("MedicineId")
                        .HasConstraintName("FK_LichSuKham_Thuoc");

                    b.Navigation("Benhnhan");

                    b.Navigation("Lich");

                    b.Navigation("Medicine");
                });

            modelBuilder.Entity("WebApplication1.Models.NguoiDung", b =>
                {
                    b.HasOne("WebApplication1.Models.Role", "Role")
                        .WithMany("NguoiDungs")
                        .HasForeignKey("RoleId")
                        .IsRequired()
                        .HasConstraintName("FK__NguoiDung__role___4F7CD00D");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("WebApplication1.Models.ThoiGianTrong", b =>
                {
                    b.HasOne("WebApplication1.Models.BacSi", "Bacsi")
                        .WithMany("ThoiGianTrongs")
                        .HasForeignKey("BacsiId")
                        .HasConstraintName("FK__ThoiGianT__bacsi__75A278F5");

                    b.Navigation("Bacsi");
                });

            modelBuilder.Entity("WebApplication1.Models.BacSi", b =>
                {
                    b.Navigation("ChiTietBacSi");

                    b.Navigation("LichHens");

                    b.Navigation("ThoiGianTrongs");
                });

            modelBuilder.Entity("WebApplication1.Models.BenhNhan", b =>
                {
                    b.Navigation("LichHens");

                    b.Navigation("LichSuKhams");
                });

            modelBuilder.Entity("WebApplication1.Models.ChuyenKhoa", b =>
                {
                    b.Navigation("BacSis");

                    b.Navigation("ChiTietBacSis");
                });

            modelBuilder.Entity("WebApplication1.Models.LichHen", b =>
                {
                    b.Navigation("LichSuKhams");
                });

            modelBuilder.Entity("WebApplication1.Models.NguoiDung", b =>
                {
                    b.Navigation("BacSi");

                    b.Navigation("BenhNhan");
                });

            modelBuilder.Entity("WebApplication1.Models.PhongKham", b =>
                {
                    b.Navigation("BacSis");

                    b.Navigation("ChiTietBacSis");
                });

            modelBuilder.Entity("WebApplication1.Models.Role", b =>
                {
                    b.Navigation("NguoiDungs");
                });

            modelBuilder.Entity("WebApplication1.Models.Thuoc", b =>
                {
                    b.Navigation("LichSuKhams");
                });

            modelBuilder.Entity("WebApplication1.Models.TinhTangLichHen", b =>
                {
                    b.Navigation("LichHens");
                });
#pragma warning restore 612, 618
        }
    }
}
