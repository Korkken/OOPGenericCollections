// See https://aka.ms/new-console-template for more information

using System.IO.Pipes;
using System.Reflection.Metadata;

Stack<Employee> Employees = new Stack<Employee>();

Employee Cassandra = new Employee("001", "Cassandra", "Female", 10000);
Employee Kalle = new Employee("002", "Kalle", "Male", 11000);
Employee Anton = new Employee("003", "Anton", "Male", 12000);
Employee Sebbe = new Employee("004", "Sebbe", "Male", 13000);
Employee Sara = new Employee("005", "Sara", "Female", 14000);
Employees.Push(Cassandra);
Employees.Push(Kalle);
Employees.Push(Anton);
Employees.Push(Sebbe);
Employees.Push(Sara);




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


Employees.Push(Cassandra);
Employees.Push(Kalle);
Employees.Push(Anton);
Employees.Push(Sebbe);
Employees.Push(Sara);
Console.WriteLine("\n Peek:");
for (int i = 0; i < 2; i++)
{
    Console.WriteLine(Employees.Peek().Name);

    Console.WriteLine($"Antal personer i stacken: {Employees.Count}");
}

if(Employees.Contains(Anton))
{
    Console.WriteLine("Anton existerar i stacken");
}
else
{
    Console.WriteLine("Anton existerar inte i stacken");
}


List<Employee> EmployeeList = new List<Employee>(
    new Employee[]
    {
        Cassandra,
        Kalle,
        Anton,
        Sebbe,
        Sara
    });

if(EmployeeList.Contains(Cassandra))
{
    Console.WriteLine("\nCassandra objektet existerar i listan");
}
else
{
    Console.WriteLine("Cassandra objektet existerar inte i listan");
}
Console.WriteLine("\nFörsta mannen i objektet");
var FirstMale = EmployeeList.Find(x => x.Gender == "Male");

Console.WriteLine($"Namn: {FirstMale.Name} ID: {FirstMale.Id}");
Console.WriteLine("\nAlla männen i objektet");
List<Employee> AllMales = EmployeeList.FindAll(x => x.Gender == "Male");

foreach(Employee males in AllMales)
{
    Console.WriteLine($"Name: {males.Name} ID: {males.Id}");
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


