// See https://aka.ms/new-console-template for more information

using System.IO.Pipes;
using System.Reflection.Metadata;

Stack<Employee> Employees = new Stack<Employee>();

Employee Olle = new Employee("001", "Olle", "Male", 10000);
Employee Kalle = new Employee("002", "Kalle", "Male", 11000);
Employee Anton = new Employee("003", "Anton", "Male", 12000);
Employee Sebbe = new Employee("004", "Sebbe", "Male", 13000);
Employee Robin = new Employee("005", "Robin", "Male", 14000);
Employees.Push(Olle);
Employees.Push(Kalle);
Employees.Push(Anton);
Employees.Push(Sebbe);
Employees.Push(Robin);




Console.WriteLine("Personer i stacken");
foreach(Employee person in Employees)
{
    person.PersonName();
    Console.WriteLine($"Antal personer i stacken: {Employees.Count}");

}
Console.WriteLine("\n Pop:");

for(int i = Employees.Count; i > 0; i--)
{
    var test = Employees.Pop();
    Console.WriteLine(test.Name);
    Console.WriteLine($"Antal personer i stacken: {Employees.Count}");
}


Employees.Push(Olle);
Employees.Push(Kalle);
Employees.Push(Anton);
Employees.Push(Sebbe);
Employees.Push(Robin);
Console.WriteLine("\n Peek:");
for (int i = 0; i < 2; i++)
{
    Console.WriteLine(Employees.Peek().Name);

    Console.WriteLine($"Antal personer i stacken: {Employees.Count}");
}    








public class Employee
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public int Salary { get; set; }

    public Employee(string id, string name, string gender, int salary)
    {
        Id = id;
        Name = name;
        Gender = gender;
        Salary = salary;
    }
    public void PersonName()
    {
        Console.WriteLine($"Namn: + {Name}, Id: {Id}");
    }
}


