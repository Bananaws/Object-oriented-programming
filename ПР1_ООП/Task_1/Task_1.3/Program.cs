using System;
/* В некоторых преобразованиях ссылочного типа компилятор не может 
определить, допустимо ли приведение. Для операции приведения 
возможна корректная ошибка компилятора во время выполнения. Как 
показано в следующем примере, приведение типов, которое 
заканчивается с ошибкой во время выполнения, вызывает 
InvalidCastException.*/
bool flag = true;
try
{
    Char ch = Convert.ToChar(flag);
    Console.WriteLine("Conversion succeeded.");
}
catch (InvalidCastException ex) // Получил ошибку, обработал.
{
    Console.WriteLine(ex.Message);
    Console.WriteLine("Cannot convert a Boolean to a Char.");
}
