using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal static class Calculator
    {
        public static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }
        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        public static double Substract(double num1, double num2)
        {
            return num1 * num2;
        }
        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
        public static void CallCalculator()
        {
            Console.Write("Enter number: ");
            var num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter number: ");
            var num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Choose operation: \n1.Multiply\n2.Substract\n3.Divide\n4.Add");
            var choise = int.Parse(Console.ReadLine());
            double res = 0;
            switch (choise)
            {
                case 1:
                    res = Calculator.Multiply(num1, num2);
                    Console.WriteLine($"Result: {num1} * {num2} = {res}");
                    break;
                case 2:
                    res = Calculator.Substract(num1, num2);
                    Console.WriteLine($"Result: {num1} - {num2} = {res}");
                    break;
                case 3:
                    res = Calculator.Divide(num1, num2);
                    Console.WriteLine($"Result: {num1} / {num2} = {res}");
                    break;
                case 4:
                    res = Calculator.Add(num1, num2);
                    Console.WriteLine($"Result: {num1} + {num2} = {res}");
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
        }
    }
}
