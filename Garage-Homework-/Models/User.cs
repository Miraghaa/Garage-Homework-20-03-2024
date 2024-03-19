namespace Garage_Homework_.Models;

public class User
{
    public string Username;
    public string Password;

    public User(string username, string password)
    {
        Username = username;
        Password = password;
    }
    public void Check()
    {
        while (Username.Length < 8)
        {
            Console.WriteLine("Username length min 8");
            Username = Console.ReadLine();
        }
        while (Password.Length < 8)
        {
            Console.WriteLine("Password length min 8");
            Password = Console.ReadLine();
        }
        while (Password.ToLower() == Password)
        {
            Console.WriteLine("Min 1 upper letter");
            Password = Console.ReadLine();
        }
        while (Password.ToUpper() == Password)
        {
            Console.WriteLine("Min 1 lower letter");
            Password = Console.ReadLine();
        }
        while (!HasDigit(Password))
        {
            Console.WriteLine("Min 1 digit");
            Password = Console.ReadLine();
        }
        Console.WriteLine("User Successfully");
    }
    public bool HasDigit(string password)
    {
        foreach (char c in password)
        {
            if (char.IsDigit(c))
            {
                return true;
            }
        }
        return false;
    }
}
