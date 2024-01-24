using Ecommerce.Model;
using Ecommerce.View;

public class Controler
    {
        private Inventory inv;
        private View view;
        private User user;
        public Controler()
        {
            inv = new Inventory();
            view = new View();
            user = new User(1, "Michael", "Buczak", "direcktos@gmail.com", null,"Radio321");
            
            if(LogInSuccessful())
            {
                Menu();
            }
            
        }
        private bool LogInSuccessful()
        {
            view.PrintMessage("Please Log in");
            view.PrintMessage("Email:");
            string Email = Console.ReadLine();
            view.PrintMessage("Password:");
            var pass = string.Empty;
            ConsoleKey key;
            do
            {
                var keyInfo = Console.ReadKey(intercept: true);
                key = keyInfo.Key;

                if (key == ConsoleKey.Backspace && pass.Length > 0)
                {
                    Console.Write("\b \b");
                    pass = pass[0..^1];
                }
                else if (!char.IsControl(keyInfo.KeyChar))
                {
                    Console.Write("*");
                    pass += keyInfo.KeyChar;
                }
            } while (key != ConsoleKey.Enter);
            
            Console.WriteLine("");

            if (Email == user.Email && pass == user.Password)
            {
                return true;
            }

            return false;
        }

        private void Menu()
        {
            while (true)
            {
                string? input = Console.ReadLine();
                int choice = 0;
                try
                {
                    choice = int.Parse(input);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e);
                }

                switch (choice)
                {
                    case 1:
                    {
                        
                        break;
                    }
                    default:
                    {
                        break;
                    }
                }
            }
        }
    }

