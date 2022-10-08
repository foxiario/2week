using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<Employee> employeers = new List<Employee>();

        Department office = new Department("Office", 1);
        Department warehouse = new Department("Warehouse",2);
        Department accounting = new Department("Аccounting", 3);

        employeers.Add(new Employee("Michael", "Gary", "Scott", 43, office));
        employeers.Add(new Employee("Darryl", "Darryl", "Philbin", 33, warehouse));
        employeers.Add(new Employee("Dwight", "Kurt", "Schrute III", 39, office));
        employeers.Add(new Employee("Oscar", "Oscar", "Martinez", 46, accounting));
        employeers.Add(new Employee("Roy", "Roy", "Anderson", 32, warehouse));
        employeers.Add(new Employee("James", "Jim", "Halpert", 25, office));
        employeers.Add(new Employee("Kevin", "Kevin", "Malone", 32, accounting));
        employeers.Add(new Employee("Angela", "Noelle", "Martin", 34, accounting));

        office.AssignHead(employeers[0]);
        warehouse.AssignHead(employeers[1]);
        accounting.AssignHead(employeers[3]);


        Dictionary<string, List<Employee>> employeersByDepartment = employeers.GroupBy(r => r.Department.Name).ToDictionary(g => g.Key, g => g.ToList());

        foreach (var item in employeersByDepartment)
        {
            Console.WriteLine("Department: " + item.Key);

            foreach (var employee in item.Value)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName + " " + employee.Patronomic);
            }

            Console.WriteLine();
        }

        Console.ReadKey();
    }
}
