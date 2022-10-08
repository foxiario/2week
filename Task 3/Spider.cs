public class Spider : ICardGame
{
    public int Quantity => 104;
    public string Name => "Spider";

    public event ICardGame.WinHandler? WinEvent;

    public void StartGame()
    {
        Console.WriteLine("Rules:\nThe main purpose of the game is to remove all cards from the table, " +
            "assembling them in the tableau before removing them. " +
            "Initially, 54 cards are dealt to the tableau in ten piles, " +
            "face down except for the top cards. The tableau piles build down by rank, " +
            "and in-suit sequences can be moved together. " +
            "The 50 remaining cards can be dealt to the tableau ten at a " +
            "time when none of the piles are empty.\n");

        Console.WriteLine("Press any key to win.");
        Console.ReadKey();
        WinEvent?.Invoke(new Random().Next(1, int.MaxValue));
    }
}
