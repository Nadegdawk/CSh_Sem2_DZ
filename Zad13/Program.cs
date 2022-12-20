// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
//            или сообщает, что третьей цифры нет.
//              645 -> 5
//              78 -> третьей цифры нет
//              32679 -> 6

Console.WriteLine("Вывод третьей цифры заданного числа");
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

if (Math.Abs(num) > 99)
{
    int x = Math.Abs((num / 100) % 10);
    System.Console.WriteLine($"Третья цифра: {x}");
}
else System.Console.WriteLine("Третьей цифры нет");