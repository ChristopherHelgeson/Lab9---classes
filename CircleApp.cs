using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9___classes
{
    class CircleApp
    {
        static void Main(string[] args)
        {
            string playAgain = "y";
            int iterations = 0;
            while (playAgain == "y" || playAgain == "Y")
            {
                double userInputRadius = 0;
                while (userInputRadius <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("CIRCLE AREA AND CIRCUMFERENCE CALCULATOR");
                    Console.Write("\nPlease enter a positive value for the radius for your circle: ");
                    userInputRadius = double.Parse(Console.ReadLine());
                }
                Circle userCircle = new Circle(userInputRadius);
                Console.WriteLine(userCircle.GetFormattedCircumference());
                Console.WriteLine(userCircle.GetFormattedArea());

                Console.Write("\nAnother circle? (Y/N): ");
                playAgain = Console.ReadLine();
                iterations++;
            }
            Console.WriteLine("\nGoodbye! Thanks for playing. You created " + iterations + " circles this round.\n");
        }
    }
}
