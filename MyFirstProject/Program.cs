using MyFirstProject;
using System;
using System.ComponentModel;

namespace TryingNewThings{

    class HelloWorld
    {
        static void Main(string[] args)
        {
            Human student = new Human("Jhon", "wick", "red", 625);
            Human student2 = new Human("Jhon", "Cena", "yellow", 25);
            Ball myball = new Ball(10);
            myball.ballAction(10);
            myball.ballAction(20);
            myball.ballAction(30);
            Console.WriteLine(myball.ballAction(10));


            /*student.fullName();
            student2.fullName();*/
            Console.ReadKey();
        }

    }
}