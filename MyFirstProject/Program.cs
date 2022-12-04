using System;

namespace TryingNewThings{

    class HelloWorld
    {
        static void Main(string[] args)
        {
            int lengthOfText = 0;
            string wholeText = "";
            do
            {
                Console.WriteLine("Please enter the length of the text");
                string text = Console.ReadLine();
                lengthOfText += text.Length;
                wholeText+= text + "\t";

            }while(lengthOfText  < 20);

            Console.WriteLine($"\n{wholeText}");
        }

    }
}