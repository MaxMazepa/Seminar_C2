// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Numb = new Random().Next(1, 100000);
Console.WriteLine($"Начальное число --> {Numb}");
int LastDig = 0;

while (Numb > 1000)
    Numb = Numb / 10;

if (Numb < 100)
    Console.WriteLine($"У числа {Numb} нет третьй цифры");
else
    Console.WriteLine($"Последняя цифра --> {LastDig = Numb % 10}");


