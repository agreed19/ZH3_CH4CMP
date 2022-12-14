using System;
using System.Collections.Generic;

namespace ZH3_CH4CMP.Models;

public partial class CarData
{
    public string CarId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? CarMake { get; set; }

    public DateTime CarDate { get; set; }
}
