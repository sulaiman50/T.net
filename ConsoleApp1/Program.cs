using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public string Operation { get; set; }

        public int Calculate()
        {
            switch (Operation)
            {
                case "+":
                    return FirstNumber + SecondNumber;
                case "-":
                    return FirstNumber - SecondNumber;
                case "*":
                    return FirstNumber * SecondNumber;
                case "/":
                    return FirstNumber / SecondNumber;
                default:
                    return 0;
            }
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            try
            {

            
            
            Calculator calculator = new Calculator();

            // Get the first number
            Console.WriteLine("Enter the first number: ");
            calculator.FirstNumber = Convert.ToInt32(Console.ReadLine());

            // Get the second number
            Console.WriteLine("Enter the second number: ");
            calculator.SecondNumber = Convert.ToInt32(Console.ReadLine());

            // Get the operation
            Console.WriteLine("Enter the operation: ");
            calculator.Operation = Console.ReadLine();

            // Calculate the result
            int result = calculator.Calculate();

            
            Console.WriteLine($"{calculator.FirstNumber} {calculator.Operation} {calculator.SecondNumber} = {result}");
            }
            catch (Exception ex)
            {

                Console.WriteLine("Please enter number");

            }
        }
    }
}