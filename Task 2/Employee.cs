public class Employee
{
    public string LastName => _lastName;
    public string FirstName => _firsyName;
    public string Patronomic => _patronomic;
    public int Age => _age;
    public Department Department => _department;

    private string _lastName;
    private string _firsyName;
    private string _patronomic;
    private int _age;
    private Department _department;

    public Employee(string firstName, string patronymic, string lastName, int age, Department department)
    {
        _lastName = lastName;
        _firsyName = firstName;
        _patronomic = patronymic;
        _age = age;
        _department = department;
    }
}
