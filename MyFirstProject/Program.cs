using MyFirstProject;
using System;
using System.ComponentModel;

namespace TryingNewThings{

    class HelloWorld
    {
        static void Main(string[] args)
        {
            Human student = new Human();

            /*            denis.firstName = "Denise";
                        denis.Firstname();


                        Human michael = new Human();
                        michael.firstName = "Michael";
                        michael.Firstname();*/

            string[] firstName = { "Andrew", "Beelzes", "Kaemi", "Mamita"};
            string[] lastName = { "Ee", "Bob", "Kay", "Durant"};

            for(int x =0; x < firstName.Length; x++)
            {
                string student1 = student.Fullname(firstName[x], lastName[x]);
                Console.WriteLine($"{student1}\n");
            }

            Console.ReadKey();
        }

    }
}