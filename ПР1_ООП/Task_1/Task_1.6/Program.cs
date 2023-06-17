using System;
/*  класс System.Convert
Этот класс выполняет расширяющие преобразования, а также преобразования 
несвязанных типов данных.
Значение, которое требуется преобразовать, можно передать в один из 
соответствующих методов класса Convert и присвоить возвращаемое значение новой 
переменной. */
double myDouble = 42.72;
try
{
    int myInt = Convert.ToInt32(myDouble); // конвертируем double в int
    Console.WriteLine(myInt); // Output: 43
}
/* Класс Convert выполняет преобразования с проверкой и всегда создает исключение, 
если данное преобразование не поддерживается (часто OverflowException). 
Список поддерживаемых преобразований содержится в таблицах преобразований 
типов. */
catch (OverflowException) // Если появилась ошибка
{
    Console.WriteLine("Unable to convert {0} to an integer.", myDouble);
}


//  Преобразование строки в число Parse или TryParse структуры System.Int32
/* Если строка имеет недопустимый формат, метод Parse создает исключение, а 
метод TryParse не создает исключение, но возвращает значение false */

int numVal = Int32.Parse("-105"); // парсить можно, исключений нет.
int j;
bool result = Int32.TryParse("-105", out j); // true
// TryParse выдаёт true или false, в то время как Parse выдаёт исключения.
if (true == result) Console.WriteLine(j); // Output: -105
else Console.WriteLine("Нельзя перевести");