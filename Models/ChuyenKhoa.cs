using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class ChuyenKhoa
{
    public Guid KhoaId { get; set; }

    public string Tenkhoa { get; set; } = null!;

    public virtual ICollection<BacSi> BacSis { get; set; } = new List<BacSi>();

    public virtual ICollection<ChiTietBacSi> ChiTietBacSis { get; set; } = new List<ChiTietBacSi>();
}
