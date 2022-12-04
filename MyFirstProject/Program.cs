
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {

        int num3;
        int num1 = 5;
        int num2 = 5;

        num3 = -num1;

        Console.WriteLine($"num3 is {num3}");
        

        bool isSunny = true;
        Console.WriteLine($"is it Sunny? {!isSunny}");

       

        bool isLower;

        isLower = num1 != num2;
        

        if (isLower)
        {
            Console.WriteLine($"{num1} is not equal to {num2}");
        }
        else
        {
            Console.WriteLine($"{num1} is equal to {num2}");
        }




        Console.ReadKey();

    }

    public static int Add(int a, int b) { 
        
        return a / b;
    
    }
}