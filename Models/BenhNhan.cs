using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class BenhNhan
{
    public Guid BenhnhanId { get; set; }

    public Guid? NguoidungId { get; set; }

    public string Tenbenhnhan { get; set; } = null!;

    public DateOnly? Ngaysinh { get; set; }

    public string? Diachi { get; set; }

    public string? Sdt { get; set; }

    public virtual ICollection<LichHen> LichHens { get; set; } = new List<LichHen>();

    public virtual ICollection<LichSuKham> LichSuKhams { get; set; } = new List<LichSuKham>();

    public virtual NguoiDung? Nguoidung { get; set; }
}
