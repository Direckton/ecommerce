namespace Ecommerce.Model;

public class ProductCategory
{
    public int categoryId { get; private set; }
    public string category { get; set; }

    public ProductCategory(int categoryId, string category)
    {
        this.categoryId = categoryId;
        this.category = category;
    }
}