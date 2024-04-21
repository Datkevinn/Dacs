using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class TinhTangLichHen
{
    public int StatusId { get; set; }

    public string? StatusName { get; set; }

    public virtual ICollection<LichHen> LichHens { get; set; } = new List<LichHen>();
}
