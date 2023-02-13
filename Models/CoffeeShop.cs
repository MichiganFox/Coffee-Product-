using System;
using System.Collections.Generic;

namespace Coffee.Models;

public partial class CoffeeShop
{
    public int Id { get; set; }

    public string? Drink { get; set; }

    public int? Price { get; set; }
}
