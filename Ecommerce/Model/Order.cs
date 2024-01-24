namespace Ecommerce.Model;

public class Order
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public float Total { get; set; }
}