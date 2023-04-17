//  Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число ");
string input = Console.ReadLine();
int Number = int.Parse(input);
int[] array = new int[input.Length];

if (array.Length > 2)
    {
     int z = 0;
        for (int i = array.Length - 1; i >= 0; i--)
     {
        z = Number % 10;
        array[i] = z;
        Number -= z;
        Number = Number / 10;
     }
     for (int i = 0; i < array.Length; i++)
     {
     Console.WriteLine("Третья цифра " + array[2]);
     break;
     }   
    }
else
{
    Console.WriteLine("Нет третьей цифры ");
}    
