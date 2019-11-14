using System;

// Напишете метод, който намира колко пъти дадено число се среща в даден масив. Напишете програма, която проверява дали този метод работи правилно. 

class Program
{
    static void Main()
    {
        int[] galinsArray = { 5, 6, 8, 8, 8, 8, 1, 2, 4, 5 };
        int number = 5;
        Console.WriteLine(NumOfTimes(galinsArray, number));
    }

    static int NumOfTimes(int[] array, int number)
    {
        int counter = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number)
            {
                counter++;
            }
        }
        return counter;
    }
}

