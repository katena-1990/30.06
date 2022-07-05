// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число");
string number = Console.ReadLine();
bool A = true;
int i = 0;
for (i = 0; i < (number.Length -1) / 2; i++)
{
    if (number[i] != number[number.Length - 1 - i])
    {
        A = false;
    }
}
if (A)
{
    Console.WriteLine("Число является полиндромом");
}
else
    {
        Console.WriteLine("Число не является полиндромом");
    }
