/*
Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

//Метод, который запрашивает число:

int PutNumber(string msg)
{
    Console.Write(msg);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}


//Метод возведения в степень:

int Exponentiation(int A, int B)
{
    int result = A;
    for (int i = 1; i < B; i++)
    {
        result = result * A;
    }
    return result;
}

//Сама программа:

int x = PutNumber("Введите число X: ");
int y = PutNumber("Введите степень Y, в которую надо возвести число: ");

Console.WriteLine($"X в степени Y равно {Exponentiation(x, y)}");
