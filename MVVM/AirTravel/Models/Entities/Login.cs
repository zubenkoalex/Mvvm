using System;
using System.Collections.Generic;

namespace Mvvm.Models.Entities;

public partial class Login
{
    public int Id { get; set; }

    public string Logins { get; set; } = null!;

    public string Pass { get; set; } = null!;

    public string Roles { get; set; } = null!;
}
