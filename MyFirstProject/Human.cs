using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    //this class is a blueprint for a datatype
    internal class Human
    {
        private string firstName;
        private string lastName;
        private string color;
        private int age;
        //constructor
        public Human(string firstName, string lastName, string color,int age) { 
            this.firstName = firstName;
            this.lastName = lastName;
            this.color = color;
            this.age = age;
        }

        public void fullName() {

            Console.WriteLine($"My name is {firstName} {lastName} \n I am {age} years old \n,and people love my beautiful {color} eye\n");
        }

        /*public string Fullname(string firstName, string lastName)
        {
            return $"{firstName}\t{lastName}";
        }*/

    }
}
