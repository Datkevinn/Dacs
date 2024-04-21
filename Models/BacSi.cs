using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class BacSi
{
    public Guid BacsiId { get; set; }

    public Guid? NguoidungId { get; set; }

    public string Tenbacsi { get; set; } = null!;

    public Guid? KhoaId { get; set; }

    public Guid? PhongkhamId { get; set; }

    public virtual ChiTietBacSi? ChiTietBacSi { get; set; }

    public virtual ChuyenKhoa? Khoa { get; set; }

    public virtual ICollection<LichHen> LichHens { get; set; } = new List<LichHen>();

    public virtual NguoiDung? Nguoidung { get; set; }

    public virtual PhongKham? Phongkham { get; set; }

    public virtual ICollection<ThoiGianTrong> ThoiGianTrongs { get; set; } = new List<ThoiGianTrong>();

    public virtual ICollection<Thuoc> Medicines { get; set; } = new List<Thuoc>();
}
