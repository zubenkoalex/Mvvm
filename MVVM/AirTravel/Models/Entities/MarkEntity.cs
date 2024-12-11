using System;
using System.Collections.Generic;

namespace Mvvm.Models.Entities;

public partial class MarkEntity
{
    public int Id { get; set; }

    public string NameModelCar { get; set; } = null!;

    public virtual ICollection<CarEntity> CarEntities { get; set; } = new List<CarEntity>();
}
