using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class NguoiDung
{
    public Guid NguoidungId { get; set; }

    public string Tennguoidung { get; set; } = null!;

    public string Matkhau { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int RoleId { get; set; }

    public virtual BacSi? BacSi { get; set; }

    public virtual BenhNhan? BenhNhan { get; set; }

    public virtual Role Role { get; set; } = null!;
}
