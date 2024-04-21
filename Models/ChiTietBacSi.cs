using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class ChiTietBacSi
{
    public Guid BacsiId { get; set; }

    public string? TrinhDo { get; set; }

    public int? SoNamKinhNghiem { get; set; }

    public Guid? KhoaId { get; set; }

    public Guid? PhongkhamId { get; set; }

    public virtual BacSi Bacsi { get; set; } = null!;

    public virtual ChuyenKhoa? Khoa { get; set; }

    public virtual PhongKham? Phongkham { get; set; }
}
