public class Person
{
    private string _name;
    private string? _workplace;

    public Person(string name)
    {
        _name = name;
    }

    public Person(string name, string workplace) : this(name)
    {
        _workplace = workplace;
    }

    public void FindWork(string speciality)
    {
        string temp = " looking for a job with a specialty ";

        if (_workplace != null)
        {
            temp = " looking for a new job with a specialty ";
        }

        Console.WriteLine(_name + temp + speciality);
    }

    public void FindWork(int salary)
    {
        string temp = " looking for a job with a minimal salary of ";

        if (_workplace != null)
        {
            temp = " looking for a new job with a minimal salary of ";
        }

        Console.WriteLine(_name + temp + salary + "$");
    }
}
