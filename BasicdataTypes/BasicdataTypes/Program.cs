using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicdataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringDataTypes();
            Console.ReadKey();
        }

        static void StringDataTypes()
        {
            string firstName;
            string lastName;
            string eSport;

            Console.Write("Howdy, Whats your first name? ");
            firstName = Console.ReadLine();
            Console.Write("Thanks, Whats Your last name? ");
            lastName = Console.ReadLine();
            Console.Write("What Esport are you registering for? ");
            eSport = Console.ReadLine();
            Console.Clear();
            Console.Write($"Welcome {firstName} {lastName}. I have you registered for {eSport}.");
        }

        static void OperatorsAndNumbers()
        {
            double num1;
            double num2;
            double num3;
            double num4;

            Console.Write("Enter a value for your first number: ");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter a value for your second number: ");
            num2 = double.Parse(Console.ReadLine());

            double addition = num1 + num2;
            double subtraction = num1 - num2;
            double multiplication = num1 * num2;
            double division = num1 / num2;
        }

    }
}
