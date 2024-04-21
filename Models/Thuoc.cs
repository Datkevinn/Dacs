using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Thuoc
{
    public Guid MedicineId { get; set; }

    public string Tenthuoc { get; set; } = null!;

    public string? Mota { get; set; }

    public decimal? Giathuoc { get; set; }

    public virtual ICollection<LichSuKham> LichSuKhams { get; set; } = new List<LichSuKham>();

    public virtual ICollection<BacSi> Bacsis { get; set; } = new List<BacSi>();

    public virtual ICollection<LichHen> Liches { get; set; } = new List<LichHen>();
}
