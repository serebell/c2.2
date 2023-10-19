using System.Runtime.CompilerServices;

Console.WriteLine("Введите число");
string? strNumber = Console.ReadLine();
int numberA = Convert.ToInt32(strNumber);
int numberResult = numberA * numberA;

Console.WriteLine("Квадрат от введенного Вами числа " + numberA + " будет " + numberResult);
