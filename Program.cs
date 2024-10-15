// See https://aka.ms/new-console-template for more information

using System.IO.Pipes;
using System.Reflection.Metadata;

Stack<Employee> Employees = new Stack<Employee>();

AddEmployees();



foreach(Employee person in Employees)
{
    person.PersonName();
    Console.WriteLine($"Antal personer i stacken: {Employees.Count}");

}

for(int i = Employees.Count; i > 0; i--)
{
    var test = Employees.Pop();
    Console.WriteLine(test.Name);
    Console.WriteLine($"Antal personer i stacken: {Employees.Count}");
}





void AddEmployees()
{
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


