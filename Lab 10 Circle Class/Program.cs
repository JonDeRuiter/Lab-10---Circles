using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10_Circle_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Circle> circle = new List<Circle>();
            bool again = true;

            do
            {
                double radius;
                Console.Write("Welcome to the Circle finder! \nPlease enter a radius: ");
                
                //This was faster to write than methods that verified only digit input while allowing a single decimal point, could have used udouble.TryParse but I only realized that later
                while (!(double.TryParse(Console.ReadLine(), out radius)) || !(NonNegative(radius)))
                {
                    Console.Write("Radius must be a positive number with or without a decimal. \nTry again: ");
                }
                
                Circle x = new Circle(radius);
                circle.Add(x);
                Console.WriteLine($"Circumference: {x.CalculateFormattedCircumference()}");
                Console.WriteLine($"Area:          {x.CalculateFormattedArea()}");
                
                again = Continue();
            } while (again);
            Console.Clear();
            Console.WriteLine($"You made {circle.Count} circles. \nGoodbye...");
            Console.ReadLine();

        }

        public static bool Continue()
        {
            bool run;
            Console.WriteLine("Continue? y/n");
            string answer = Console.ReadLine();
            answer = answer.ToLower();

            if (answer == "y")
            {
                run = true;
            }
            else if (answer == "n")
            {
                run = false;
            }
            else
            {
                Console.WriteLine("Sorry, I didn't understand that. Try again.");
                run = Continue();
            }
            return run;
        }
        public static bool NonNegative(double input)
        {
            if (input > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
