public class Solitaire : ICardGame
{
    public int Quantity => 52;
    public string Name => "Solitaire";

    public event ICardGame.WinHandler? WinEvent;

    public void StartGame()
    {
        Console.WriteLine("Rules:\n" +
            " After shuffling, a tableau of seven fanned piles of cards is laid from left to right. " +
            "From left to right, each pile contains one more card than the last. " +
            "The first and left-most pile contains a single upturned card, the second pile contains two cards, " +
            "the third pile contains three cards, the fourth pile contains four cards, the fifth pile contains five cards, " +
            "the sixth pile contains six cards, and the seventh pile contains seven cards. " +
            "The topmost card of each pile is turned face up. " +
            "The remaining cards form the stock and are placed facedown at the upper left of the layout. " +
            "The four foundations(light rectangles in the upper right of the figure) are built up by suit from Ace " +
            "(low in this game) to King, and the tableau piles can be built down by alternate colors. " +
            "Every face-up card in a partial pile, or a complete pile, can be moved, as a unit, " +
            "to another tableau pile on the basis of its highest card.Any empty piles can be filled with a King, " +
            "or a pile of cards with a King. " +
            "The aim of the game is to build up four stacks of cards starting with Ace and ending with King, " +
            "all of the same suit, on one of the four foundations, at which time the player would have won.\n");

        Console.WriteLine("Press any key to win.");
        Console.ReadKey();
        WinEvent?.Invoke(new Random().Next(1, int.MaxValue));
    }
}
