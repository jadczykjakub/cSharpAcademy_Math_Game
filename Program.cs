// See https://aka.ms/new-console-template for more information
using cSharpAcademy_Math_Game;
using System.Linq;

internal class Program
{
    private static void Main()
    {
        var math = new MathOperation();


        bool repeat = true;

        while (repeat)
        {
            string[] MathOperationArray = math.MathOperationArray;

            Console.WriteLine("Please pick operation you would like to do");
            Console.WriteLine(string.Join(", ", MathOperationArray));


            string userChoice = Console.ReadLine();

            if (MathOperationArray.Contains(userChoice))
            {
                Console.WriteLine("Please write first and then second int");

                int number1 = int.Parse(Console.ReadLine());
                int number2 = int.Parse(Console.ReadLine());


                switch (userChoice)
                {
                    case "Addition":
                        Console.WriteLine(math.Addition(number1, number2));
                        break;
                    case "Substraction":
                        Console.WriteLine(math.Substraction(number1, number2));
                        break;
                    case "Division":
                        Console.WriteLine(math.Division(number1, number2));
                        break;
                    case "Mulitplication":
                        Console.WriteLine(math.Mulitplication(number1, number2));
                        break;
                    default:
                        break;
                }

                Console.WriteLine("Would you like to have other game? yes or no");
                string oneMore = Console.ReadLine();

                if (oneMore == "no")
                    repeat = false;

            }
            else
            {
                Console.WriteLine("Please give correct string");
            }
        }

  
            

    }
}