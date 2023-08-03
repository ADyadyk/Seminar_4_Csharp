/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
(можно указать любой промежуток)
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/


//Метод, который создаёт массив учитывающий желание программиста (размер,  min и max значения)

int[] GiveMas()
{
    Console.Write("Введите размер массива: ");
    int size = int.Parse(Console.ReadLine()!);
    Console.Write("Введите минимальное число из промежутка чисел, которыми наполняется массив min = ");
    int min = int.Parse(Console.ReadLine()!);
    Console.Write("Введите максимально число из промежутка чисел, которыми наполняется массив: max = ");
    int max = int.Parse(Console.ReadLine()!);

    int[] arr = new int[size];

    for (int i=0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}

//Сама программа:

Console.WriteLine($"{String.Join("  ", GiveMas())}");