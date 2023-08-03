/*
Задача 3: Напишите программу, которая выводит массив из 8 элементов, 
заполненный нулями и единицами в случайном порядке.

[1,0,1,1,0,1,0,0]
*/

//Метод рандом

int[] GiveMas(int size)
{
    int[] arr = new int[size];

    for (int i=0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(2);
    }
    return arr;
}

Console.Write("Введите размер массива: ");
int len = int.Parse(Console.ReadLine()!);

int[] array = GiveMas(len);

Console.WriteLine($"{String.Join("  ", array)}");









/*
// Задача 3: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

// [1,0,1,1,0,1,0,0]

int[] array = GetRange(8);
Console.WriteLine($"[{String.Join(",", array)}]");

//method
int[] GetRange(int size){
    int[] massive = new int[size];
    for(int i = 0; i < massive.Length; i++){
        massive[i] = new Random().Next(2);
    }
    return massive;
}
*/