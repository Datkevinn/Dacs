using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class AddIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChuyenKhoa",
                columns: table => new
                {
                    khoa_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    tenkhoa = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ChuyenKh__87386DE5F59291DA", x => x.khoa_id);
                });

            migrationBuilder.CreateTable(
                name: "PhongKham",
                columns: table => new
                {
                    phongkham_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    tenphong = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    diachi = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    sdt = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PhongKha__D8EC7B684BAB40A4", x => x.phongkham_id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    role_id = table.Column<int>(type: "int", nullable: false),
                    role_name = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Roles__760965CCBC42B4C7", x => x.role_id);
                });

            migrationBuilder.CreateTable(
                name: "Thuoc",
                columns: table => new
                {
                    medicine_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    tenthuoc = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    mota = table.Column<string>(type: "text", nullable: true),
                    giathuoc = table.Column<decimal>(type: "decimal(10,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Thuoc__E7148EBBC52436B4", x => x.medicine_id);
                });

            migrationBuilder.CreateTable(
                name: "TinhTangLichHen",
                columns: table => new
                {
                    status_id = table.Column<int>(type: "int", nullable: false),
                    status_name = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TinhTang__3683B5310FE9D7E8", x => x.status_id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NguoiDung",
                columns: table => new
                {
                    nguoidung_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    tennguoidung = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    matkhau = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    role_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__NguoiDun__813FDB77FF5447D5", x => x.nguoidung_id);
                    table.ForeignKey(
                        name: "FK__NguoiDung__role___4F7CD00D",
                        column: x => x.role_id,
                        principalTable: "Roles",
                        principalColumn: "role_id");
                });

            migrationBuilder.CreateTable(
                name: "BacSi",
                columns: table => new
                {
                    bacsi_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    nguoidung_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    tenbacsi = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    khoa_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    phongkham_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BacSi__290305EF5BE6F25B", x => x.bacsi_id);
                    table.ForeignKey(
                        name: "FK__BacSi__khoa_id__5AEE82B9",
                        column: x => x.khoa_id,
                        principalTable: "ChuyenKhoa",
                        principalColumn: "khoa_id");
                    table.ForeignKey(
                        name: "FK__BacSi__nguoidung__59FA5E80",
                        column: x => x.nguoidung_id,
                        principalTable: "NguoiDung",
                        principalColumn: "nguoidung_id");
                    table.ForeignKey(
                        name: "FK__BacSi__phongkham__5BE2A6F2",
                        column: x => x.phongkham_id,
                        principalTable: "PhongKham",
                        principalColumn: "phongkham_id");
                });

            migrationBuilder.CreateTable(
                name: "BenhNhan",
                columns: table => new
                {
                    benhnhan_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    nguoidung_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    tenbenhnhan = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    ngaysinh = table.Column<DateOnly>(type: "date", nullable: true),
                    diachi = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    sdt = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BenhNhan__9A4F702351A07CAE", x => x.benhnhan_id);
                    table.ForeignKey(
                        name: "FK__BenhNhan__nguoid__60A75C0F",
                        column: x => x.nguoidung_id,
                        principalTable: "NguoiDung",
                        principalColumn: "nguoidung_id");
                });

            migrationBuilder.CreateTable(
                name: "ChiTietBacSi",
                columns: table => new
                {
                    bacsi_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    trinh_do = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    so_nam_kinh_nghiem = table.Column<int>(type: "int", nullable: true),
                    khoa_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    phongkham_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ChiTietB__290305EF2E8D6195", x => x.bacsi_id);
                    table.ForeignKey(
                        name: "FK__ChiTietBa__bacsi__0D7A0286",
                        column: x => x.bacsi_id,
                        principalTable: "BacSi",
                        principalColumn: "bacsi_id");
                    table.ForeignKey(
                        name: "FK__ChiTietBa__khoa___787EE5A0",
                        column: x => x.khoa_id,
                        principalTable: "ChuyenKhoa",
                        principalColumn: "khoa_id");
                    table.ForeignKey(
                        name: "FK__ChiTietBa__phong__797309D9",
                        column: x => x.phongkham_id,
                        principalTable: "PhongKham",
                        principalColumn: "phongkham_id");
                });

            migrationBuilder.CreateTable(
                name: "ChiTietBacSi_Thuoc",
                columns: table => new
                {
                    bacsi_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    medicine_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ChiTietB__87724D04B0BBAD17", x => new { x.bacsi_id, x.medicine_id });
                    table.ForeignKey(
                        name: "FK__ChiTietBa__bacsi__0B91BA14",
                        column: x => x.bacsi_id,
                        principalTable: "BacSi",
                        principalColumn: "bacsi_id");
                    table.ForeignKey(
                        name: "FK__ChiTietBa__medic__0C85DE4D",
                        column: x => x.medicine_id,
                        principalTable: "Thuoc",
                        principalColumn: "medicine_id");
                });

            migrationBuilder.CreateTable(
                name: "ThoiGianTrong",
                columns: table => new
                {
                    thoigian_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    bacsi_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ngaygio = table.Column<DateOnly>(type: "date", nullable: true),
                    calam = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ThoiGian__D9668A932B24FC5D", x => x.thoigian_id);
                    table.ForeignKey(
                        name: "FK__ThoiGianT__bacsi__75A278F5",
                        column: x => x.bacsi_id,
                        principalTable: "BacSi",
                        principalColumn: "bacsi_id");
                });

            migrationBuilder.CreateTable(
                name: "LichHen",
                columns: table => new
                {
                    lich_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    benhnhan_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    bacsi_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ngayhen = table.Column<DateTime>(type: "datetime", nullable: true),
                    status_id = table.Column<int>(type: "int", nullable: true, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__LichHen__246C9F3D2A52D96C", x => x.lich_id);
                    table.ForeignKey(
                        name: "FK__LichHen__bacsi_i__693CA210",
                        column: x => x.bacsi_id,
                        principalTable: "BacSi",
                        principalColumn: "bacsi_id");
                    table.ForeignKey(
                        name: "FK__LichHen__benhnha__68487DD7",
                        column: x => x.benhnhan_id,
                        principalTable: "BenhNhan",
                        principalColumn: "benhnhan_id");
                    table.ForeignKey(
                        name: "FK__LichHen__status___6A30C649",
                        column: x => x.status_id,
                        principalTable: "TinhTangLichHen",
                        principalColumn: "status_id");
                });

            migrationBuilder.CreateTable(
                name: "LichHen_Thuoc",
                columns: table => new
                {
                    lich_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    medicine_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__LichHen___8A1DD7D67911FB92", x => new { x.lich_id, x.medicine_id });
                    table.ForeignKey(
                        name: "FK__LichHen_T__lich___07C12930",
                        column: x => x.lich_id,
                        principalTable: "LichHen",
                        principalColumn: "lich_id");
                    table.ForeignKey(
                        name: "FK__LichHen_T__medic__08B54D69",
                        column: x => x.medicine_id,
                        principalTable: "Thuoc",
                        principalColumn: "medicine_id");
                });

            migrationBuilder.CreateTable(
                name: "LichSuKham",
                columns: table => new
                {
                    history_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    benhnhan_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    lich_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    donthuoc = table.Column<string>(type: "text", nullable: true),
                    medicine_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__LichSuKh__096AA2E996E4EC9D", x => x.history_id);
                    table.ForeignKey(
                        name: "FK_LichSuKham_Thuoc",
                        column: x => x.medicine_id,
                        principalTable: "Thuoc",
                        principalColumn: "medicine_id");
                    table.ForeignKey(
                        name: "FK__LichSuKha__benhn__6E01572D",
                        column: x => x.benhnhan_id,
                        principalTable: "BenhNhan",
                        principalColumn: "benhnhan_id");
                    table.ForeignKey(
                        name: "FK__LichSuKha__lich___6EF57B66",
                        column: x => x.lich_id,
                        principalTable: "LichHen",
                        principalColumn: "lich_id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BacSi_khoa_id",
                table: "BacSi",
                column: "khoa_id");

            migrationBuilder.CreateIndex(
                name: "IX_BacSi_phongkham_id",
                table: "BacSi",
                column: "phongkham_id");

            migrationBuilder.CreateIndex(
                name: "UQ__BacSi__813FDB76BD7BB273",
                table: "BacSi",
                column: "nguoidung_id",
                unique: true,
                filter: "[nguoidung_id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UQ__BenhNhan__813FDB76AE736D61",
                table: "BenhNhan",
                column: "nguoidung_id",
                unique: true,
                filter: "[nguoidung_id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietBacSi_khoa_id",
                table: "ChiTietBacSi",
                column: "khoa_id");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietBacSi_phongkham_id",
                table: "ChiTietBacSi",
                column: "phongkham_id");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietBacSi_Thuoc_medicine_id",
                table: "ChiTietBacSi_Thuoc",
                column: "medicine_id");

            migrationBuilder.CreateIndex(
                name: "IX_LichHen_bacsi_id",
                table: "LichHen",
                column: "bacsi_id");

            migrationBuilder.CreateIndex(
                name: "IX_LichHen_benhnhan_id",
                table: "LichHen",
                column: "benhnhan_id");

            migrationBuilder.CreateIndex(
                name: "IX_LichHen_status_id",
                table: "LichHen",
                column: "status_id");

            migrationBuilder.CreateIndex(
                name: "IX_LichHen_Thuoc_medicine_id",
                table: "LichHen_Thuoc",
                column: "medicine_id");

            migrationBuilder.CreateIndex(
                name: "IX_LichSuKham_benhnhan_id",
                table: "LichSuKham",
                column: "benhnhan_id");

            migrationBuilder.CreateIndex(
                name: "IX_LichSuKham_lich_id",
                table: "LichSuKham",
                column: "lich_id");

            migrationBuilder.CreateIndex(
                name: "IX_LichSuKham_medicine_id",
                table: "LichSuKham",
                column: "medicine_id");

            migrationBuilder.CreateIndex(
                name: "IX_NguoiDung_role_id",
                table: "NguoiDung",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "UQ__NguoiDun__AB6E61643681693C",
                table: "NguoiDung",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__NguoiDun__CED324380D411465",
                table: "NguoiDung",
                column: "tennguoidung",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__Roles__783254B147FAC60A",
                table: "Roles",
                column: "role_name",
                unique: true,
                filter: "[role_name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ThoiGianTrong_bacsi_id",
                table: "ThoiGianTrong",
                column: "bacsi_id");

            migrationBuilder.CreateIndex(
                name: "UQ__TinhTang__501B37534BB6DB56",
                table: "TinhTangLichHen",
                column: "status_name",
                unique: true,
                filter: "[status_name] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ChiTietBacSi");

            migrationBuilder.DropTable(
                name: "ChiTietBacSi_Thuoc");

            migrationBuilder.DropTable(
                name: "LichHen_Thuoc");

            migrationBuilder.DropTable(
                name: "LichSuKham");

            migrationBuilder.DropTable(
                name: "ThoiGianTrong");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Thuoc");

            migrationBuilder.DropTable(
                name: "LichHen");

            migrationBuilder.DropTable(
                name: "BacSi");

            migrationBuilder.DropTable(
                name: "BenhNhan");

            migrationBuilder.DropTable(
                name: "TinhTangLichHen");

            migrationBuilder.DropTable(
                name: "ChuyenKhoa");

            migrationBuilder.DropTable(
                name: "PhongKham");

            migrationBuilder.DropTable(
                name: "NguoiDung");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
