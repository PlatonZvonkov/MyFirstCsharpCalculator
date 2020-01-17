using System;
using System.Linq;

namespace ConsoleApp4 
{
    class Program
    {
        static void Main()
        {
            double num1;
            double num2;
            Console.WriteLine("WELCOME TO BASIC CALCULATOR!");
            Console.WriteLine(" X+Y(summ) ; X-Y(substract) ; X*Y(multiply) ; X/Y(divide) ; X^Y(exponent)");
            Console.WriteLine("----------------------------");

        Start:
            Console.WriteLine(" ");
            Console.WriteLine("-----set first Number:");
            string input1 = Console.ReadLine();
            while (!double.TryParse(input1, out num1))
            {
                Console.WriteLine("invalid number! try again");
                goto Start;
            }
            {
                Console.WriteLine("-----set an operation to do with {0}", input1);
            }
                                                         
            var op = Console.ReadLine();
            if (op.Contains("+") || op.Contains("-") || op.Contains("*") || op.Contains("/")|| op.Contains("^"))
            {
                Console.WriteLine("-----set second Number:");
            }
            else
            {
                Console.WriteLine("invalid Operator! try again");
                goto Start;
            }
            
        Start2:
            string input2 = Console.ReadLine();
            while (!double.TryParse(input2, out num2))
            {
                Console.WriteLine("------invalid number! try again");
                goto Start2;
            }
            {
                Console.WriteLine("-----Result:");
            }
           

                switch (op)
                {
                    case "+":
                        Console.WriteLine("{0} + {1} = " + (num1 + num2), num1, num2);
                        break;
                    case "-":
                        Console.WriteLine("{0} - {1} = " + (num1 - num2), num1, num2);
                        break;
                    case "*":
                        Console.WriteLine("{0} * {1} = " + (num1 * num2), num1, num2);
                        break;
                    case "/":
                        Console.WriteLine("{0} / {1} = " + (num1 / num2), num1, num2);
                        break;
                    case "^":
                        Console.WriteLine("{0} ^ {1} = " + Math.Pow(num1, num2));
                        break;
                    default:
                        Console.WriteLine("invalid Operator! try again");
                        break;
                }
           
            goto Start;
        }
    }
}
