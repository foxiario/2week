public class Department
{
    public string Name => _name;
    public int Number => _number;
    public Employee Head => _head;

    private string _name;
    private int _number;
    private Employee _head;

    public Department(string name, int number)
    {
        _name = name;
        _number = number;
    }

    public void AssignHead(Employee head)
    {
        if (head.Department != this) return;
        _head = head;
    }
}
