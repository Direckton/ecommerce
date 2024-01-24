namespace Ecommerce.Model;

public class Inventory
{
    private List<Product> _inventory;

    public Inventory()
    {
        _inventory = new List<Product>();
        _inventory.Add(new Product(1,"Asus", "Motherboard z790 prime", 999.0f));
        _inventory.Add(new Product(2,"Msi", "Motherboard b550 pro", 779.0f));
        _inventory.Add(new Product(3,"AsRock", "Motherboard b760 gaming", 699.0f));
        _inventory.Add(new Product(4,"Gigabyte", "Motherboard z790 prime", 1239.0f));
        _inventory.Add(new Product(5,"EVGA", "Motherboard z790 Kingpin", 2499.0f));
        _inventory.Add(new Product(6,"BioStar", "Motherboard b760", 529.0f));
    }

    public Product? GetProdyctById(int id)
    {
        foreach (var p in _inventory)
        {
            if (p.id == id)
            {
                return p;
            }
        }

        return null;
    }
    
}