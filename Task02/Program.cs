using System;

// Създайте метод GetMax() с два целочислени (int) параметъра, който връща по-голямото от двете числа. 
// Напишете програма, която прочита три цели числа от конзолата и отпечатва най-голямото от тях, използвайки метода GetMax().

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        if (GetMax(a, b) > c)
        {
            Console.WriteLine(GetMax(a, b));
        }
        else
        {
            Console.WriteLine(c);
        }
    }

    static int GetMax(int n, int a)
    {
        if (n > a)
        {
            return n;
        }
        else
        {
            return a;
        }
    }    
}

