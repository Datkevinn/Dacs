using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class PhongKham
{
    public Guid PhongkhamId { get; set; }

    public string Tenphong { get; set; } = null!;

    public string Diachi { get; set; } = null!;

    public string Sdt { get; set; } = null!;

    public virtual ICollection<BacSi> BacSis { get; set; } = new List<BacSi>();

    public virtual ICollection<ChiTietBacSi> ChiTietBacSis { get; set; } = new List<ChiTietBacSi>();
}
