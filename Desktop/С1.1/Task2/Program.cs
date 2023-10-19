Console.WriteLine("Введите первое число");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberTwo = Convert.ToInt32(Console.ReadLine());
if (numberOne == numberTwo * numberTwo)
 {Console.WriteLine( $"первое число {numberOne} является квадратом второго {numberTwo}");}
else
 {Console.WriteLine( $"первое число {numberOne} не является квадратом второго {numberTwo}, квадрат второго числа равен {numberTwo * numberTwo}");}