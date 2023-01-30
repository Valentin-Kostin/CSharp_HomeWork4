/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

void SummCifr(int num)
{
    int sum = 0;
    for (int counter = num; counter > 0;)
    {
        sum = counter % 10 + sum;
        counter = counter / 10;
    }
    Console.Write(sum);
}

int GetNum(string textGet)
{
    Console.WriteLine(textGet);
    int num = int.Parse(Console.ReadLine());
    return num;
}

//Ввод числа

int number = GetNum("Введите число");

//Вывод результата

Console.Write($"{number} -> ");
SummCifr(number);