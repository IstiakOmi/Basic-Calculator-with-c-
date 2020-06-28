using System;
using System.Dynamic;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            double numb1 =Convert.ToDouble(Console.ReadLine());
            //Because Console.ReadLine() took data only in string format.

            Console.WriteLine("Enter another number:");
            double numb2 = Convert.ToDouble(Console.ReadLine());


            Console.Write("The Addition is: " );
            Console.WriteLine(numb1 + numb2);

            Console.Write("The Substraction is: ");
            Console.WriteLine(numb1 - numb2);

            Console.Write("The multiplication is: ");
            Console.WriteLine(numb1 * numb2);

            Console.Write("The division is: ");
            Console.WriteLine(numb1 / numb2);


            Console.ReadLine();
        }
    }
}
