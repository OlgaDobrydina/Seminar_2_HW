//  Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число ");
string input = Console.ReadLine();
int Number = int.Parse(input);
int Digit1 = Number/10;
int Digit2 = Digit1%10;
Console.WriteLine(Digit2);