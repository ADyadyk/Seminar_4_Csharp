/*
Задача 1: Напишите программу, которая принимает на вход число N и 
выдаёт произведение чисел от 1 до N.

4  -> 24
5  -> 120
*/

Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Произведение чисел от 1 до {A} = {GetP(A)}");


// Методы
int GetP(int A){
    int p = 1;
    for(int i = 1; i <= A; i++){
        p *= i;
    }
    return p;
}