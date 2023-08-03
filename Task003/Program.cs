/*
Задача 2: Определить, является ли заданное шестизначное число счастливым. 
(Счастливым называют такое шестизначное число, что сумма его первых трех цифр равна сумме его 
последних трех цифр, порядок чисел в сумме не важен). Решить самым оптимальным способом.
*/

//Метод, который запрашивает шестизначное число
string PutNumber()
{
    Console.Write("Введите шестизначное число: ");
    string result = Console.ReadLine();
    return result;
}

//Проверка числа
bool Check(string num)
{
    if (num.Length == 6) return true;
    else return false;
}


//Happy method

void FindHappy(string num)
{

    if (num[0]+num[1]+num[2] == num[3]+num[4]+num[5])
    {
        Console.WriteLine("Число счастливое!");
    }
    else 
    {
        Console.WriteLine("Число не счастливое!");
    }
}

//Программа

string number = PutNumber();

if (Check(number)) FindHappy(number);
else Console.WriteLine("Число не шестизначное!");
