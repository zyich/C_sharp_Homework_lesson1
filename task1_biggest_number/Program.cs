/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.Write("Input numberA =>");

int numberA  = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numberB =>");
int numberB  = Convert.ToInt32(Console.ReadLine());

int max = numberA;
int min = numberB;

if (numberB > numberA)
{
    max = numberB;
    min = numberA;
}

Console.WriteLine($"Max number: {max}");
Console.WriteLine($"Min number: {min}");





