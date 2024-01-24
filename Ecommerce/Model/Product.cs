namespace Ecommerce.Model;

public class Product
{
    public int id { get; private set; }
    public string productName { get; set; }
    public float productPrice { get; set; }
    public string manufacturer { get; set; }
    public int categoryId { get; private set; }

    public Product(int id, string manufacturer ,string productName, float productPrice)
    {
        this.id = id;
        this.manufacturer = manufacturer;
        this.productName = productName;
        this.productPrice = productPrice;
    }

    // public string getProduct()
    // {
    //     
    // }

    public override string ToString()
    {
        return "ID:" + id + " Manufacturer:" + manufacturer + " Model:" + productName +
               " Price:" + productPrice.ToString("0.00");
    }
}