using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Task
{
    class task6
    {
        public void Run()
        {
            double num1 = 10;
            double num2 = 5;

            Console.WriteLine("Додати: {0} + {1} = {2}", num1, num2, Calculator.Add(num1, num2));
            Console.WriteLine("Відняти: {0} - {1} = {2}", num1, num2, Calculator.Subtract(num1, num2));
            Console.WriteLine("Множити: {0} * {1} = {2}", num1, num2, Calculator.Multiply(num1, num2));
            Console.WriteLine("Ділити: {0} / {1} = {2}", num1, num2, Calculator.Divide(num1, num2));

        }
        static class Calculator
        {
           
            public static double Add(double a, double b)
            {
                return a + b;
            }

            
            public static double Subtract(double a, double b)
            {
                return a - b;
            }

            
            public static double Multiply(double a, double b)
            {
                return a * b;
            }

           
            public static double Divide(double a, double b)
            {
                return a / b;
            }
        }
    }
}
