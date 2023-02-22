// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да
using static Homework_8.Library;

int NumberDigits(int value)
{
    int i = 0;
    while (value >= 1)
    {
        value /= 10;
        i++;
    }
    return i;
}

int palindrome = ReadNumber();
int n = NumberDigits(palindrome);
bool isPalindrome = true;

for (int i = 0; i < n / 2; i++)
{
    int left = (palindrome / (int)Math.Pow(10, n - i - 1)) % 10; 
    int right = (palindrome / (int)Math.Pow(10, i)) % 10; 
    if (left != right)
        isPalindrome = false;
}

if (isPalindrome)
    System.Console.WriteLine(palindrome + " -> да, это палиндром");
else
    System.Console.WriteLine(palindrome + " -> нет, это не палиндром");