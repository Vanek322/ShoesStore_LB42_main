using System;
using System.Collections.Generic;

namespace ShoesStore_LB42_main.Models;

public partial class Supplier
{
    public int Id { get; set; }

    public string SupplierName { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
