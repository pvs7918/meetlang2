/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Введите число: ");
int numb = int.Parse(Console.ReadLine()!);

int remainder;

if (numb < 100)
{
    Console.WriteLine($"Число двузначное, третьей цифры нет!");
}
else
{
    //сначала получаем трехзначное число, путем деления на 10
    while (numb > 999)
    {
        numb = numb / 10;
    }
    remainder = numb % 10;
    Console.WriteLine($"Третья цифра числа равна: {remainder}");
}