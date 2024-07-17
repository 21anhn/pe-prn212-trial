using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class AirConditioner
{
    public int AirConditionerId { get; set; }

    public string AirConditionerName { get; set; } = null!;

    public string? Warranty { get; set; }

    public string? SoundPressureLevel { get; set; }

    public string? FeatureFunction { get; set; }

    public int? Quantity { get; set; }

    public double? DollarPrice { get; set; }

    public string? SupplierId { get; set; }

    public virtual SupplierCompany? Supplier { get; set; }
}
