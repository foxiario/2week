public class Program
{
    private static ICardGame game = new Spider();

    public static void Main()
    {
        ChooseGame();

        Console.WriteLine("Starting game " + game.Name + " with a total of " + game.Quantity + " cards\n");

        game.WinEvent += OnGameWin;
        game.StartGame();
        game.WinEvent -= OnGameWin;

        Console.ReadKey();
    }

    private static void ChooseGame()
    {
        Console.WriteLine("Choose game: ");

        Console.WriteLine("1. Solitaire");
        Console.WriteLine("2. Spider");

        string? input = Console.ReadLine();

        if (!int.TryParse(input, out int x))
        {
            Console.WriteLine("Incorrect input.");
            ChooseGame();
        }

        switch (x)
        {
            case 1:
                {
                    game = new Solitaire();
                    break;
                }
            case 2:
                {
                    game = new Spider();
                    break;
                }
            default:
                {
                    Console.WriteLine("Incorrect input.");
                    ChooseGame();
                    break;
                }
        }
    }

    private static void OnGameWin(int movesCount)
    {
        Console.WriteLine("You win after " + movesCount + " moves");
    }
}
