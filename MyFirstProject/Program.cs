
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        String a = Console.ReadLine();
        int number, numTemp;
        bool tryStrToInt = int.TryParse(a, out number);

        if (tryStrToInt)
        {
            numTemp= number;
            Console.WriteLine(numTemp);
        }
        else
        {
            numTemp= 0;
        }
        

    }

}