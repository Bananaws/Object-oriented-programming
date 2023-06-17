using System;
// Преобразование типов Implicit - неявное, Explicit - явное
Counter counter1 = new Counter { Seconds = 50 };

int x = (int)counter1; // явно указываем тип int
Console.WriteLine($"Явное: {x}");   // явно 50

Counter counter2 = x;
Console.WriteLine($"Неявное: {counter2.Seconds}");  // неявно 50

class Counter
{
    public int Seconds { get; set; }

    // преобразует число - объект типа int к типу Counter.
    // Логика: создается новый объект Counter,
    // у которого устанавливается свойство Seconds.
    public static implicit operator Counter(int x) // Неявное преобразование
    {
        return new Counter { Seconds = x };
    }

    // преобразует объект Counter к типу int, то есть получает из Counter число.
    public static explicit operator int(Counter counter) // Явное преобразование
    {
        return counter.Seconds;
    }
}