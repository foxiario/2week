public interface ICardGame
{
    public int Quantity { get; }
    public string Name { get; }
    public void StartGame();

    public delegate void WinHandler(int movesCount);
    public event WinHandler WinEvent;
}
