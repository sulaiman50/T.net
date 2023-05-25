using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public class Calculator
    {
        public int FirstNumber { get; set; } 
        public int SecondNumber { get; set; }

        public string Operation { get; set; }

        public int Calculate()
        {
            int returnValue = 0;

            switch (Operation)
            {
                case "+":
                     returnValue = FirstNumber + SecondNumber; break;
                case "-":
                    returnValue = FirstNumber - SecondNumber; break;
                case "*":
                    returnValue = FirstNumber * SecondNumber; break;
                case "/":
                    returnValue = FirstNumber / SecondNumber; break;
                case "%":
                    returnValue = FirstNumber % SecondNumber; break;
                default:
                    {
                        returnValue = 0;                         
                        break;
                    }
                    
            }
            return returnValue;
        }
    }

        

    class Program
    {
        public static void Main(string[] args)
        {

            int firstnumber = 0;
            int secondnumber = 0;
            string operation = string.Empty;
            int result = 0;

            try
            {
               
                Process(out firstnumber,out secondnumber,out operation,out result);
                Console.WriteLine($"{firstnumber} {operation} {secondnumber} = {result}");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("try again Enter the number" );
                Process(out firstnumber, out secondnumber, out operation, out result);
                Console.ReadKey();
            }


            
        }

        public static void Process(out int firstnumber,out int secondnumber,out string operation,out int returnresult)
        {
            Calculator calculator = new Calculator();
            int _firstNum = 0;
            int _secondNum = 0;
            string _operation = string.Empty;

            int result = -1;
            do
            {
                // Get the first number
                Console.WriteLine("Enter the first number: ");
                calculator.FirstNumber = Convert.ToInt32(Console.ReadLine());

                // Get the second number
                Console.WriteLine("Enter the second number: ");
                calculator.SecondNumber = Convert.ToInt32(Console.ReadLine());

                // Get the operation
                Console.WriteLine("Enter the operation: ");
                calculator.Operation = Console.ReadLine();

                //Console.ReadKey();
                _firstNum = Convert.ToInt32(calculator.FirstNumber);
                _secondNum = Convert.ToInt32(calculator.SecondNumber);
                _operation = calculator.Operation;

                result = calculator.Calculate();
                returnresult = result;

            } while (result == 0);

            firstnumber = _firstNum;
            secondnumber = _secondNum;
            operation = _operation;
        }
    }
}