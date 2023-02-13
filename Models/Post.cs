using System;
using System.Collections.Generic;

namespace Coffee.Models;

public partial class Post
{
    public int Id { get; set; }

    public string? Drink { get; set; }

    public int? Price { get; set; }
}
