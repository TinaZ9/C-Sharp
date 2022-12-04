
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        bool isRegistred = true;
        String username = "", password = "";

        while(isRegistred) {


            Console.WriteLine("Please enter your username");
            username = Console.ReadLine();

            Console.WriteLine("Please enter your password");
            password = Console.ReadLine();

            if(username != "" && password != "")
            {
                Console.WriteLine("You are login");
                isRegistred= false;
            }
            else
            {
                Console.WriteLine("Invalid username and password");
            }
        }

        Console.WriteLine($"\n\nYour username is {username} and your password is {password}");

        Console.ReadKey();

    }

    public static String Weather(int temp) { 
        
        if(temp < 10 && temp != 0){

            return "Take the coat";
        
        }else if (temp == 10){

            return "It's 10 degrees C";

        }
        else if(temp > 10){

            return "It's 10 degrees C";
        }
        else
        {
            return "Not a number";
        }
    
    }
}