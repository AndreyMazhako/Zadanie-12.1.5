namespace Program;

public class Program
{
    public static void Main(string[] args)
    {
        List<User> users = new List<User>()
        {
            new User { Login = "user1", Name = "Иван", IsPremium = true },
            new User { Login = "user2", Name = "Мария", IsPremium = false },
            new User { Login = "user3", Name = "Петр", IsPremium = false },
            new User { Login = "user4", Name = "Ольга", IsPremium = true }
        };

        GreetUsers(users);
    }

    static void ShowAds()
    {
        Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
        // Остановка на 1 с
        Thread.Sleep(1000);

        Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
        // Остановка на 2 с
        Thread.Sleep(2000);

        Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
        // Остановка на 3 с
        Thread.Sleep(3000);
    }

    static void GreetUsers(List<User> users)
    {
        foreach (var user in users)
        {
            Console.WriteLine($"Привет, {user.Name}!");
            if (!user.IsPremium)
            {
                Console.WriteLine("Сейчас покажем немного рекламы:");
                ShowAds();
            }
            Console.WriteLine();
        }
    }

}

