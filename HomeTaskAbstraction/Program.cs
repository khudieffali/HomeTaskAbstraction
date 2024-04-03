using HomeTaskAbstraction;

internal class Program
{
    private static void Main(string[] args)
    {

        User user = new("Ali Xudiyev", "ali.xudiyev98@gmail.com", "ali12345");
        Console.WriteLine(user.PasswordChecker(user.Password));
        user.ShowInfo();
    }
}