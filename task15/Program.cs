/*
Задача 15: Напишите программу, которая принимает на вход цифру,
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите цифру: ");
int dig = int.Parse(Console.ReadLine()!);
string weekday;
int remainder;

Console.Write("Указанный день недели является выходным: -> ");

if (dig > 5)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}