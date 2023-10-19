//Задача 4: Напишите программу, которая принимает на вход 
//три числа и выдает максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22


int max = 0;

Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int thridNumber = Convert.ToInt32(Console.ReadLine());

if(firstNumber > max)
{
    max = firstNumber;
}

if(secondNumber > max)
{
    max = secondNumber;
}

if(thridNumber > max)
{
    max = thridNumber;
}

Console.WriteLine("max= " + max);