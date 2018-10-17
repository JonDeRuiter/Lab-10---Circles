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
                Console.Write("Welcome to the Circle finder! \nPlease enter a radius: ");
                //string input = IsDoubleNum(Console.ReadLine());
                string input = Console.ReadLine();
                double radius = double.Parse(input);
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
        public static string NotEmpty(string input)
        {
            input = input.Trim();
            try
            {
                if (input == null || input == "")
                {
                    throw new Exception("Input is empty, Please enter a number");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.Write("Please enter a number 1-10: ");
                input = NotEmpty(Console.ReadLine());
            }
            return input;
        }
        public static string IsDoubleNum(string input)
        {

            string inputX = input.Trim('.');
            char[] charArray = inputX.ToCharArray();
            
            try
            {
                if (!IsDigit(inputX))
                {
                    throw new Exception("");
                }
            }
            catch (Exception)
            {

                throw;
            }
            return input;
        }
        public static bool IsDigit(string input)
        {
            input = NotEmpty(input);
            char[] charArray = input.ToCharArray();
            foreach (char c in charArray)
            {
                if (!(char.IsDigit(charArray[c])))
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
            return true;
        }
    }
}
