using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class LichHen
{
    public Guid LichId { get; set; }

    public Guid? BenhnhanId { get; set; }

    public Guid? BacsiId { get; set; }

    public DateTime? Ngayhen { get; set; }

    public int? StatusId { get; set; }

    public virtual BacSi? Bacsi { get; set; }

    public virtual BenhNhan? Benhnhan { get; set; }

    public virtual ICollection<LichSuKham> LichSuKhams { get; set; } = new List<LichSuKham>();

    public virtual TinhTangLichHen? Status { get; set; }

    public virtual ICollection<Thuoc> Medicines { get; set; } = new List<Thuoc>();
}
