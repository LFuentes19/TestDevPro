using System;
using System.Collections.Generic;
using System.Linq;

//Task 2: Inventory Manager

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
}

public class InventoryManager
{
    public static List<Product> SortProducts(List<Product> products, string sortKey, bool ascending)
    {
        switch (sortKey.ToLower())
        {
            case "name":
                if (ascending)
                    return products.OrderBy(p => p.Name).ToList();
                else
                    return products.OrderByDescending(p => p.Name).ToList();
            case "price":
                if (ascending)
                    return products.OrderBy(p => p.Price).ToList();
                else
                    return products.OrderByDescending(p => p.Price).ToList();
            case "stock":
                if (ascending)
                    return products.OrderBy(p => p.Stock).ToList();
                else
                    return products.OrderByDescending(p => p.Stock).ToList();
            default:
                throw new ArgumentException("Invalid sort key");
        }
    }
}

