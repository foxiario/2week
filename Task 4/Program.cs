public class Program
{
    public static void Main()
    {
        Person first = new Person("Nikolai");
        Person second = new Person("Nikolai II","Palace");
        first.FindWork("Plumber");
        first.FindWork(100);
        second.FindWork("Car Mechanic");
        second.FindWork(300);
        Console.ReadKey();
    }
}

