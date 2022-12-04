
public class MyFirstProject
{

    public static void Main()
    {


        Console.WriteLine("Input first number");
        String? a = Console.ReadLine();
        Console.WriteLine("Input first number");
        String? b = Console.ReadLine();


        int firstDigit = int.Parse(a);
        int secondDigit = int.Parse(b);


        Console.WriteLine("Choose method of calculation?\n add\n multiply\n divide\n subtract");
        String? selection = Console.ReadLine();


        switch (selection)
        {
            case "add":
                Console.WriteLine(Add(firstDigit, secondDigit));
                break;
            case "subtract":
                Console.WriteLine(Subtract(firstDigit, secondDigit));
                break;
            case "divide":
                Console.WriteLine(Divide(firstDigit, secondDigit));
                break;
            case "multiply":
                Console.WriteLine(Multiply(firstDigit, secondDigit));
                break;
            default:
                Console.WriteLine("Please Select from the list");
                break;
        }


        Console.Read();

    }

    public static int Add(int a, int b)
    {
        return a + b;
    }
    public static int Subtract(int a, int b)
    {
        return a + b;
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }

    public static int Divide(int a, int b)
    {
        return a / b;
    }
}


