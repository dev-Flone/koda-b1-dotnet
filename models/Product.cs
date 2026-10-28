namespace Banking.Console.Models;

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public string? Description { get; set; }

    public Product(string name, decimal price, int stock, string? description)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Name is required");
        }
        if (price < 0)
        {
            throw new ArgumentException("Price must be positive");
        }
        if (stock < 0)
        {
            throw new ArgumentException("Stock must be over 0");
        }
        Name = name;
        Price = price;
        Stock = stock;
        Description = description;
    }

    public string GetInformation()
    {
        return $"{Name}\n{Price}\n{Stock}\n{Description ?? "No Description."}";
    }
};


