namespace Ecommerce.View;

public class View
{
    public View()
    {
        
    }

    public void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }

    public void PrintMenuOptions()
    {
        Console.WriteLine("Menu:\n" +
                          "1 Search product\n" +
                          "2 View inventory\n" +
                          "3 Create order");
    }

    public void PrintLoginForm()
    {
        Console.WriteLine("Please log in");
    }
}