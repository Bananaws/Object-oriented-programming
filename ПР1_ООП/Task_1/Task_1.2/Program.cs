using System;
/* Если преобразование не может быть выполнено без риска потери 
данных, для компилятора требуется, чтобы пользователь выполнил 
явное преобразование, которое называется приведением. 
Приведение является способом явно указать компилятору, что нужно 
сделать преобразование, и что известно, что может быть потеря данных. */

double x = 12340000000.7;
int a;
a = (int)x; // приведение
Console.WriteLine(a); // Вывод: 1234

/* Таблица явных преобразований
sbyte -> byte , ushort, uint, ulong или char 
byte -> Sbyte или char 
short -> sbyte , byte, ushort, uint, ulong или char 
ushort -> sbyte , byte, short или char 
int -> sbyte , byte, short, ushort, uint, ulong или char 
uint -> sbyte , byte, short, ushort, int или char 
long -> sbyte , byte, short, ushort, int, uint, ulong или char 
ulong -> sbyte , byte, short, ushort, int, uint, long или char 
char -> sbyte , byte или short 
float -> sbyte , byte, short, ushort, int, uint, long, ulong, char или decimal 
double -> sbyte , byte, short, ushort, int, uint, long, ulong, char, float или
decimal
decimal -> sbyte , byte, short, ushort, int, uint, long, ulong, char, float или
double */

/* Для ссылочных типов явное приведение необходимо, если нужно 
выполнить преобразование из базового типа в производный тип. */
// Создадим новый производный тип. 

Derived der = new Derived("Derived", "der");
Base bas = der;
Derived der2 = (Derived)bas; // Явное приведение из базового в производный

Console.Write(der2.Name);
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

