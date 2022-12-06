using MyFirstProject;
using System;
using System.ComponentModel;

namespace TryingNewThings{

    class HelloWorld
    {
        static void Main(string[] args)
        {
            Ball ball = new Ball();

            ball.setRoll(25);

            int roll = ball.getRoll();
            

            Console.WriteLine(roll);


            Console.Read();
        }

    }
}