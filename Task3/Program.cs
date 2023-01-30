/*Задача 29: Напишите программу, которая задаёт массив
из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

void ShowArray(int[] arr)
{
    Console.Write("[");
    int len = arr.Length - 1;
    for (int i = 0; i < len; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[len] + "]");
}

int[] GetArray(int number)
{
    int[] array = new int[number];
    for (int i = 0; i < number; i++)
    {
        array[i] = new Random().Next(0, 100);
    }    
    return array;
}

int GetNum(string textGet)
{
    Console.WriteLine(textGet);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int number = GetNum("Введите длину массива");

ShowArray(GetArray(number));
