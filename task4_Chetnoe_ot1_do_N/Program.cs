/* Задача 8: Напишите программу, которая 
на вход принимает число (N), а на выходе
 показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

/*Console.Write("Input numberA =>");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i <= N ; i += 2 )
{
    Console.WriteLine(i);
}
*/




Console.Write("Введите число N => ");
int N = Convert.ToInt32(Console.ReadLine());

if (N >= 0)
{
    for (int i = 0; i <= N; i += 2)
    {
        Console.WriteLine(i);
    }
}
else
{
    for (int i = 0; i >= N; i -= 2)
    {
        Console.WriteLine(i);
    }
}