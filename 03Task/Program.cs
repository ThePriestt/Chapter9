using System;

// Напишете метод, който връща английското наименование на последната цифра от дадено число. Примери: за числото 512 отпечатва "two", за числото 1024 → "four". 

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter a number");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine(LastDigit(a));       
    }

    static string LastDigit(int number)
    {
        int lastDigit = number % 10;
        string result = "";

        switch (lastDigit)
        {
            case 0:
                result = "zero";
                break;

            case 1:
                result = "one";
                break;

            case 2:
                result = "two";
                break;

            case 3:
                result = "three";
                break;

            case 4:
                result = "four";
                break;

            case 5:
                result = "five";
                break;

            case 6:
                result = "six";
                break;

            case 7:
                result = "seven";
                break;

            case 8:
                result = "eight";
                break;

            case 9:
                result = "nine";
                break;
        }
        return result;
    }
}

