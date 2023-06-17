using System;
/* Операторы is и as
 Эти операторы можно использовать, чтобы проверить, будет ли 
приведение успешным, не вызывая исключение. 
 В общем оператор as более эффективен, поскольку он фактически
возвращает значение приведения, если приведение может быть
выполнено успешно.*/

// as
Employee employee1 = new Employee("Tom", "Company OOO");
Person? person1 = employee1 as Person; // производный класс к базовому
if (employee1 == null)
{
    Console.WriteLine("1.as Преобразование прошло неудачно");
}
else
{
    Console.WriteLine(employee1.Company);
}

Person person2 = new Person("Jerry");
Employee? employee2 = person2 as Employee; // базовый класс к производному
// знак ? означает, что переменная может хранить null или знач Employee
if (employee2 == null) // нельзя перевести Person к Employee, поэтому null
{
    Console.WriteLine("2.as Преобразование прошло неудачно");
}
else
{
    Console.WriteLine(employee2.Company);
}

// is
Person person3 = new Person("John"); // перем. базового класса
if (person3 is Employee employee3) // Попытаемся представить её как перем. производного класса
{
    Console.WriteLine(employee3.Company);
}
else
{
    Console.WriteLine("3.is Преобразование не допустимо"); // такое преобразование нельзя делать
}

// Классы
class Person
{
    public string Name { get; set; }
    public Person(string name)
    {
        Name = name;
    }
    public void Print()
    {
        Console.WriteLine($"Person {Name}");
    }
}

class Employee : Person
{
    public string Company { get; set; }
    public Employee(string name, string company) : base(name)
    {
        Company = company;
    }
}

class Client : Person
{
    public string Bank { get; set; }
    public Client(string name, string bank) : base(name)
    {
        Bank = bank;
    }
}
