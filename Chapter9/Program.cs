using System;

// Напишете метод, който при подадено име отпечатва на конзолата "Hello, <name>!" (например "Hello, Peter!"). 
// Напишете програма, която тества дали този метод работи правилно. 

class Program
{
    static void Main()
    {
        string name = "Galin";
        Console.WriteLine("Hello {0}", name);

        Greeting("Stoyan");
        Greeting("Galin");
    }

    static void Greeting(string name)
    {
        Console.WriteLine("Greeting {0}", name);
    }
}

