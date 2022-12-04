using System;

namespace TryingNewThings{

    class HelloWorld
    {
        static void Main(string[] args)
        {

            int temperature = 150;

            string stateOfMatter;

            stateOfMatter = temperature < 0 ? "solid" : temperature > 100 ? "gas" : "liquid";

            Console.WriteLine($"State of matter is {stateOfMatter}");
            Console.ReadKey();
        }

    }
}