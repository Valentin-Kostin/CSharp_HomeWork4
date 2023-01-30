/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

void Total (int numA, int numB)
{
    int total = 1;
    for (int i = 1; i <= numB; i++)
    {
        total = total * numA;
    }
    Console.Write(total);
}

int GetNum(string textGet)
{
    Console.WriteLine(textGet);
    int num = int.Parse(Console.ReadLine());
    return num;
}

//Ввод чисел

int numberA = GetNum("Введите первое число");
int numberB = GetNum("Введите второе число");

//Вывод результата

Console.Write($"{numberA}, {numberB} -> " );
Total(numberA, numberB);