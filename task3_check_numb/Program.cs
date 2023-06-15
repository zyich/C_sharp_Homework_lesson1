/* Задача 6: Напишите программу, которая 
на вход принимает число и выдаёт, является
 ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

Console.Write("Input numberA =>");
int numberA  = Convert.ToInt32(Console.ReadLine());
float remainder = numberA % 2;
if (remainder ==  0)
{
    Console.WriteLine("число четное");
 }
 else
 {
    Console.WriteLine("число нечетное");
 }











