using System;
using System.Collections.Generic;

namespace Mvvm.Models.Entities;

public partial class ModelEntity
{
    public int Id { get; set; }

    public string НазваниеМодели { get; set; } = null!;

    public virtual ICollection<CarEntity> CarEntities { get; set; } = new List<CarEntity>();
}
