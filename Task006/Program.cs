/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

//Метод, который запрашивает число (но возвращает его как string):

string PutNumber(string msg)
{
    Console.Write(msg);
    string result = Console.ReadLine();
    return result;
}


//Метод определяющий сумму цифр в числе:

int NumberSum(string someNum)
{
    int size = someNum.Length;
    int sum = 0;
    for (int i=0; i < size; i++)
    {
        sum += (int)Char.GetNumericValue(someNum[i]);
    }
    return sum;
}

//Сама программа:

string number = PutNumber("Введите число: ");
Console.WriteLine($"Сумма его цифр равна {NumberSum(number)}");