// Задача 15: Напишите программу, которая принимает на вход цифру,
//            обозначающую день недели, и проверяет, является ли
//            этот день выходным.
//             6 -> да
//             7 -> да
//             1 -> нет

Console.WriteLine("Является ли день выходным");
Console.Write("Введите номер дня недели (1-7): ");
int num = int.Parse(Console.ReadLine());

if (num >= 1 & num <=7)
{
    if (num >=1 & num <=5)
    {
        System.Console.WriteLine("День не выходной");
    }
    else {
        System.Console.WriteLine("День выходной");
    }
}
else {
    System.Console.WriteLine("Не является днем недели");
}