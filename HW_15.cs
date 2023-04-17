// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
Console.WriteLine("Ведите цифру ");
string input = Console.ReadLine();
int Number = int.Parse(input);

if (Number == 7) Console.WriteLine("Выходной");
if (Number == 6) Console.WriteLine("Выходной");
else
{
    if (Number > 7) Console.WriteLine("Нет такого дня недели");
    else
     {
        if (Number == 1) Console.WriteLine("Это рабочий день");
        if (Number == 2) Console.WriteLine("Это рабочий день");
        if (Number == 3) Console.WriteLine("Это рабочий день");
        if (Number == 4) Console.WriteLine("Это рабочий день");
        if (Number == 5) Console.WriteLine("Это рабочий день");
     }       
}