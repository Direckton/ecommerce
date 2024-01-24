namespace Ecommerce.Model;

public class User
{
    public int Id { get; private set; }
    public string Name { get; set; }
    public string Lastname { get; set; }
    public string Email { get; set; }
    public string? Phone { get; set; } = null;
    public string Password { get; set; }

    public User(int id, string name, string lastname, string email, string password)
    {
        this.Id = id;
        this.Name = name;
        this.Lastname = lastname;
        this.Email = email;
        this.Password = password;
    }
}