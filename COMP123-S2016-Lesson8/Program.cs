using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;

            try
            {
                Console.Write("Enter an Integer: ");
                firstNumber = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another Integer: ");
                secondNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Result: {0:f2}", Divide(firstNumber, secondNumber));
            }
            catch(FormatException)
            {
                Console.WriteLine("Error: Please enter an integer");
            }
            catch(OverflowException)
            {
                Console.WriteLine("Error: Number too long");
                Console.WriteLine("Please enter an integer smaller than 2,147,483,647");
            }
        }

        private static float Divide(int numerator, int denominator)
        {

            try
            {
                float result = Convert.ToSingle(numerator) / Convert.ToSingle(denominator);
                return result;
            }
            catch (Exception exception)
            {
                Console.WriteLine("Error: " + exception.Message);
                return 0f;
            }
        }
    }
}
