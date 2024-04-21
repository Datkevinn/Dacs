using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class LichSuKham
{
    public Guid HistoryId { get; set; }

    public Guid? BenhnhanId { get; set; }

    public Guid? LichId { get; set; }

    public string? Donthuoc { get; set; }

    public Guid? MedicineId { get; set; }

    public virtual BenhNhan? Benhnhan { get; set; }

    public virtual LichHen? Lich { get; set; }

    public virtual Thuoc? Medicine { get; set; }
}
