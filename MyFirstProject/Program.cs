using MyFirstProject;
using System;
using System.ComponentModel;

namespace TryingNewThings{

    class HelloWorld
    {
        static void Main(string[] args)
        {
            Ball ball = new Ball();

            ball.height = 4;
            ball.roll = 10;
            ball.jump = 10;

            Console.WriteLine(ball.Width);
            Console.Read();
        }

    }
}