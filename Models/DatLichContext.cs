using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace WebApplication1.Models;

public partial class DatLichContext : IdentityDbContext<IdentityUser, IdentityRole, string>
{

    public DatLichContext(DbContextOptions<DatLichContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BacSi> BacSis { get; set; }

    public virtual DbSet<BenhNhan> BenhNhans { get; set; }

    public virtual DbSet<ChiTietBacSi> ChiTietBacSis { get; set; }

    public virtual DbSet<ChuyenKhoa> ChuyenKhoas { get; set; }

    public virtual DbSet<LichHen> LichHens { get; set; }

    public virtual DbSet<LichSuKham> LichSuKhams { get; set; }

    public virtual DbSet<NguoiDung> NguoiDungs { get; set; }

    public virtual DbSet<PhongKham> PhongKhams { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<ThoiGianTrong> ThoiGianTrongs { get; set; }

    public virtual DbSet<Thuoc> Thuocs { get; set; }

    public virtual DbSet<TinhTangLichHen> TinhTangLichHens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=LAPTOP-9TL21T2B;Initial Catalog=DatLich1;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<IdentityUserLogin<string>>()
            .HasKey(l => new { l.LoginProvider, l.ProviderKey });
        modelBuilder.Entity<BacSi>(entity =>
        {
            entity.HasKey(e => e.BacsiId).HasName("PK__BacSi__290305EF5BE6F25B");

            entity.ToTable("BacSi");

            entity.HasIndex(e => e.NguoidungId, "UQ__BacSi__813FDB76BD7BB273").IsUnique();

            entity.Property(e => e.BacsiId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("bacsi_id");
            entity.Property(e => e.KhoaId).HasColumnName("khoa_id");
            entity.Property(e => e.NguoidungId).HasColumnName("nguoidung_id");
            entity.Property(e => e.PhongkhamId).HasColumnName("phongkham_id");
            entity.Property(e => e.Tenbacsi)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("tenbacsi");

            entity.HasOne(d => d.Khoa).WithMany(p => p.BacSis)
                .HasForeignKey(d => d.KhoaId)
                .HasConstraintName("FK__BacSi__khoa_id__5AEE82B9");

            entity.HasOne(d => d.Nguoidung).WithOne(p => p.BacSi)
                .HasForeignKey<BacSi>(d => d.NguoidungId)
                .HasConstraintName("FK__BacSi__nguoidung__59FA5E80");

            entity.HasOne(d => d.Phongkham).WithMany(p => p.BacSis)
                .HasForeignKey(d => d.PhongkhamId)
                .HasConstraintName("FK__BacSi__phongkham__5BE2A6F2");

            entity.HasMany(d => d.Medicines).WithMany(p => p.Bacsis)
                .UsingEntity<Dictionary<string, object>>(
                    "ChiTietBacSiThuoc",
                    r => r.HasOne<Thuoc>().WithMany()
                        .HasForeignKey("MedicineId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__ChiTietBa__medic__0C85DE4D"),
                    l => l.HasOne<BacSi>().WithMany()
                        .HasForeignKey("BacsiId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__ChiTietBa__bacsi__0B91BA14"),
                    j =>
                    {
                        j.HasKey("BacsiId", "MedicineId").HasName("PK__ChiTietB__87724D04B0BBAD17");
                        j.ToTable("ChiTietBacSi_Thuoc");
                        j.IndexerProperty<Guid>("BacsiId").HasColumnName("bacsi_id");
                        j.IndexerProperty<Guid>("MedicineId").HasColumnName("medicine_id");
                    });
        });

        modelBuilder.Entity<BenhNhan>(entity =>
        {
            entity.HasKey(e => e.BenhnhanId).HasName("PK__BenhNhan__9A4F702351A07CAE");

            entity.ToTable("BenhNhan");

            entity.HasIndex(e => e.NguoidungId, "UQ__BenhNhan__813FDB76AE736D61").IsUnique();

            entity.Property(e => e.BenhnhanId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("benhnhan_id");
            entity.Property(e => e.Diachi)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("diachi");
            entity.Property(e => e.Ngaysinh).HasColumnName("ngaysinh");
            entity.Property(e => e.NguoidungId).HasColumnName("nguoidung_id");
            entity.Property(e => e.Sdt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sdt");
            entity.Property(e => e.Tenbenhnhan)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("tenbenhnhan");

            entity.HasOne(d => d.Nguoidung).WithOne(p => p.BenhNhan)
                .HasForeignKey<BenhNhan>(d => d.NguoidungId)
                .HasConstraintName("FK__BenhNhan__nguoid__60A75C0F");
        });

        modelBuilder.Entity<ChiTietBacSi>(entity =>
        {
            entity.HasKey(e => e.BacsiId).HasName("PK__ChiTietB__290305EF2E8D6195");

            entity.ToTable("ChiTietBacSi");

            entity.Property(e => e.BacsiId)
                .ValueGeneratedNever()
                .HasColumnName("bacsi_id");
            entity.Property(e => e.KhoaId).HasColumnName("khoa_id");
            entity.Property(e => e.PhongkhamId).HasColumnName("phongkham_id");
            entity.Property(e => e.SoNamKinhNghiem).HasColumnName("so_nam_kinh_nghiem");
            entity.Property(e => e.TrinhDo)
                .HasMaxLength(255)
                .HasColumnName("trinh_do");

            entity.HasOne(d => d.Bacsi).WithOne(p => p.ChiTietBacSi)
                .HasForeignKey<ChiTietBacSi>(d => d.BacsiId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ChiTietBa__bacsi__0D7A0286");

            entity.HasOne(d => d.Khoa).WithMany(p => p.ChiTietBacSis)
                .HasForeignKey(d => d.KhoaId)
                .HasConstraintName("FK__ChiTietBa__khoa___787EE5A0");

            entity.HasOne(d => d.Phongkham).WithMany(p => p.ChiTietBacSis)
                .HasForeignKey(d => d.PhongkhamId)
                .HasConstraintName("FK__ChiTietBa__phong__797309D9");
        });

        modelBuilder.Entity<ChuyenKhoa>(entity =>
        {
            entity.HasKey(e => e.KhoaId).HasName("PK__ChuyenKh__87386DE5F59291DA");

            entity.ToTable("ChuyenKhoa");

            entity.Property(e => e.KhoaId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("khoa_id");
            entity.Property(e => e.Tenkhoa)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("tenkhoa");
        });

        modelBuilder.Entity<LichHen>(entity =>
        {
            entity.HasKey(e => e.LichId).HasName("PK__LichHen__246C9F3D2A52D96C");

            entity.ToTable("LichHen");

            entity.Property(e => e.LichId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("lich_id");
            entity.Property(e => e.BacsiId).HasColumnName("bacsi_id");
            entity.Property(e => e.BenhnhanId).HasColumnName("benhnhan_id");
            entity.Property(e => e.Ngayhen)
                .HasColumnType("datetime")
                .HasColumnName("ngayhen");
            entity.Property(e => e.StatusId)
                .HasDefaultValue(1)
                .HasColumnName("status_id");

            entity.HasOne(d => d.Bacsi).WithMany(p => p.LichHens)
                .HasForeignKey(d => d.BacsiId)
                .HasConstraintName("FK__LichHen__bacsi_i__693CA210");

            entity.HasOne(d => d.Benhnhan).WithMany(p => p.LichHens)
                .HasForeignKey(d => d.BenhnhanId)
                .HasConstraintName("FK__LichHen__benhnha__68487DD7");

            entity.HasOne(d => d.Status).WithMany(p => p.LichHens)
                .HasForeignKey(d => d.StatusId)
                .HasConstraintName("FK__LichHen__status___6A30C649");

            entity.HasMany(d => d.Medicines).WithMany(p => p.Liches)
                .UsingEntity<Dictionary<string, object>>(
                    "LichHenThuoc",
                    r => r.HasOne<Thuoc>().WithMany()
                        .HasForeignKey("MedicineId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__LichHen_T__medic__08B54D69"),
                    l => l.HasOne<LichHen>().WithMany()
                        .HasForeignKey("LichId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__LichHen_T__lich___07C12930"),
                    j =>
                    {
                        j.HasKey("LichId", "MedicineId").HasName("PK__LichHen___8A1DD7D67911FB92");
                        j.ToTable("LichHen_Thuoc");
                        j.IndexerProperty<Guid>("LichId").HasColumnName("lich_id");
                        j.IndexerProperty<Guid>("MedicineId").HasColumnName("medicine_id");
                    });
        });

        modelBuilder.Entity<LichSuKham>(entity =>
        {
            entity.HasKey(e => e.HistoryId).HasName("PK__LichSuKh__096AA2E996E4EC9D");

            entity.ToTable("LichSuKham");

            entity.Property(e => e.HistoryId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("history_id");
            entity.Property(e => e.BenhnhanId).HasColumnName("benhnhan_id");
            entity.Property(e => e.Donthuoc)
                .HasColumnType("text")
                .HasColumnName("donthuoc");
            entity.Property(e => e.LichId).HasColumnName("lich_id");
            entity.Property(e => e.MedicineId).HasColumnName("medicine_id");

            entity.HasOne(d => d.Benhnhan).WithMany(p => p.LichSuKhams)
                .HasForeignKey(d => d.BenhnhanId)
                .HasConstraintName("FK__LichSuKha__benhn__6E01572D");

            entity.HasOne(d => d.Lich).WithMany(p => p.LichSuKhams)
                .HasForeignKey(d => d.LichId)
                .HasConstraintName("FK__LichSuKha__lich___6EF57B66");

            entity.HasOne(d => d.Medicine).WithMany(p => p.LichSuKhams)
                .HasForeignKey(d => d.MedicineId)
                .HasConstraintName("FK_LichSuKham_Thuoc");
        });

        modelBuilder.Entity<NguoiDung>(entity =>
        {
            entity.HasKey(e => e.NguoidungId).HasName("PK__NguoiDun__813FDB77FF5447D5");

            entity.ToTable("NguoiDung");

            entity.HasIndex(e => e.Email, "UQ__NguoiDun__AB6E61643681693C").IsUnique();

            entity.HasIndex(e => e.Tennguoidung, "UQ__NguoiDun__CED324380D411465").IsUnique();

            entity.Property(e => e.NguoidungId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("nguoidung_id");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Matkhau)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("matkhau");
            entity.Property(e => e.RoleId).HasColumnName("role_id");
            entity.Property(e => e.Tennguoidung)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tennguoidung");

            entity.HasOne(d => d.Role).WithMany(p => p.NguoiDungs)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__NguoiDung__role___4F7CD00D");
        });

        modelBuilder.Entity<PhongKham>(entity =>
        {
            entity.HasKey(e => e.PhongkhamId).HasName("PK__PhongKha__D8EC7B684BAB40A4");

            entity.ToTable("PhongKham");

            entity.Property(e => e.PhongkhamId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("phongkham_id");
            entity.Property(e => e.Diachi)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("diachi");
            entity.Property(e => e.Sdt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sdt");
            entity.Property(e => e.Tenphong)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("tenphong");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK__Roles__760965CCBC42B4C7");

            entity.HasIndex(e => e.RoleName, "UQ__Roles__783254B147FAC60A").IsUnique();

            entity.Property(e => e.RoleId)
                .ValueGeneratedNever()
                .HasColumnName("role_id");
            entity.Property(e => e.RoleName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("role_name");
        });

        modelBuilder.Entity<ThoiGianTrong>(entity =>
        {
            entity.HasKey(e => e.ThoigianId).HasName("PK__ThoiGian__D9668A932B24FC5D");

            entity.ToTable("ThoiGianTrong");

            entity.Property(e => e.ThoigianId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("thoigian_id");
            entity.Property(e => e.BacsiId).HasColumnName("bacsi_id");
            entity.Property(e => e.Calam)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("calam");
            entity.Property(e => e.Ngaygio).HasColumnName("ngaygio");

            entity.HasOne(d => d.Bacsi).WithMany(p => p.ThoiGianTrongs)
                .HasForeignKey(d => d.BacsiId)
                .HasConstraintName("FK__ThoiGianT__bacsi__75A278F5");
        });

        modelBuilder.Entity<Thuoc>(entity =>
        {
            entity.HasKey(e => e.MedicineId).HasName("PK__Thuoc__E7148EBBC52436B4");

            entity.ToTable("Thuoc");

            entity.Property(e => e.MedicineId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("medicine_id");
            entity.Property(e => e.Giathuoc)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("giathuoc");
            entity.Property(e => e.Mota)
                .HasColumnType("text")
                .HasColumnName("mota");
            entity.Property(e => e.Tenthuoc)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("tenthuoc");
        });

        modelBuilder.Entity<TinhTangLichHen>(entity =>
        {
            entity.HasKey(e => e.StatusId).HasName("PK__TinhTang__3683B5310FE9D7E8");

            entity.ToTable("TinhTangLichHen");

            entity.HasIndex(e => e.StatusName, "UQ__TinhTang__501B37534BB6DB56").IsUnique();

            entity.Property(e => e.StatusId)
                .ValueGeneratedNever()
                .HasColumnName("status_id");
            entity.Property(e => e.StatusName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("status_name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
