using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class ThoiGianTrong
{
    public Guid ThoigianId { get; set; }

    public Guid? BacsiId { get; set; }

    public DateOnly? Ngaygio { get; set; }

    public string? Calam { get; set; }

    public virtual BacSi? Bacsi { get; set; }
}
