using System;
// Неявное преобразование.
/* Не требуется никакого специального синтаксиса, поскольку преобразование 
безопасно для типов. Примерами могут служить преобразования от меньшего к 
большему целому типу, и преобразования из производных классов в базовые 
классы. */
int num = 2147483647;
long bigNum = num; // long может содержать любое значение, которое может содержать int
Console.WriteLine(bigNum);
Console.WriteLine();

/*Для ссылочных типов всегда существует неявное преобразование из класса в 
любой из его прямых или косвенных базовых классов или интерфейсов. Никакого 
специального синтаксиса не требуется, поскольку производный класс всегда 
содержит все члены базового класса. */
Derived der = new Derived("Derived", "der");
Base bas = der; // Преобразование от Derived в Base
Console.Write(bas.Name);
class Base // Класс Base (базовый)
{
    public string Name { get; set; }
    public Base(string name)
    {
        Name = name;
    }
}

class Derived : Base // Класс Derived (производный от Base)
{
    public string Type { get; set; }
    public Derived(string name, string derived) : base(name)
    {
        Type = derived;
    }
}

/* Таблица неявных преобразований
sbyte -> short , int, long, float, double или decimal
byte -> short, ushort, int, uint, long, float, double или decimal
short -> int , long, float, double или decimal
ushort -> int , uint, long, ulong, float, double или decimal
Int -> long , float, double или decimal
uint -> long , ulong, float, double или decimal
long -> float , double или decimal
char -> ushort , int, uint, long, ulong, float, double или decimal
float -> double
ulong -> float , double или decimal
*/