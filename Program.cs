using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace assignment
{
    // A class is defined as Calculator
    class Calculator
    {
        // In this line, a void method is created (Calculate) that identifies the two parameters to be used.
        // The void method needs to be accessible so it is public.

        public void Calculate(int num1, int num2)
        {
            // An integer is declared that performs the equation.
            int result = num1 * 5;

            // The result of the equation is displayed in this line. ($ to interpret the value inside {}) 
            // The second integer will also be displayed.
            Console.WriteLine("Result of num1 * 5 is "+ result);
            Console.WriteLine("The second integer is {"+ num2);
        }
    }
    // Another class is created for the program that identifies the parameters that will be used.
    class Program
    {
        // In order to access other methods the void is static.
        static void Main(string[] args)
        {
            // Instantiate the class created which is Calculator
            Calculator Calcu = new Calculator();

            // In this line we use the method Calculate 
            // Which is under the class Calculator which in this instance is Calcu
            // This will identify the num1 and num2 integers.
            Calcu.Calculate(10, 20);
        }
    }
}