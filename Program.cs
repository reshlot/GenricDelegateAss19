using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAssignment
{
    public delegate T Operation<T>(T a, T b);

    public class Program
    {
        public static T Add<T>(T a, T b)
        {
            dynamic dynamicA = a;
            dynamic dynamicB = b;
            return dynamicA + dynamicB;
        }

        public static T Subtract<T>(T a, T b)
        {
            dynamic dynamicA = a;
            dynamic dynamicB = b;
            return dynamicA - dynamicB;
        }

        public static T Multiply<T>(T a, T b)
        {
            dynamic dynamicA = a;
            dynamic dynamicB = b;
            return dynamicA * dynamicB;
        }

        public static T Divide<T>(T a, T b)
        {
            dynamic dynamicA = a;
            dynamic dynamicB = b;
            return dynamicA / dynamicB;
        }

        public static void Main(string[] args)
        {

            Console.WriteLine("***Generic Delegate Using T*** \n");

            Console.WriteLine("***Enter two values***");


                Console.WriteLine("Enter value1:");
                int value1 = int.Parse(Console.ReadLine());


                Console.WriteLine("Enter value2:");
                int value2 = int.Parse(Console.ReadLine());

            bool exit = false;

            do
            {

                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Operation<int> addOperation = Add;
                        int sum = addOperation(value1, value2);
                        Console.WriteLine($"Result of addition: {sum}");
                        break;
                    case 2:
                        Operation<int> subtractOperation = Subtract;
                        int difference = subtractOperation(value1, value2);
                        Console.WriteLine($"Result of subtraction: {difference}");
                        break;
                    case 3:
                        Operation<int> multiplyOperation = Multiply;
                        int product = multiplyOperation(value1, value2);
                        Console.WriteLine($"Result of multiplication: {product}");
                        break;
                    case 4:
                        Operation<int> divideOperation = Divide;
                        int quotient = divideOperation(value1, value2);
                        Console.WriteLine($"Result of division: {quotient}");
                        break;
                    case 5:
                        Console.WriteLine("THANK YOU!!!");
                        exit = true;
                       
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

                Console.WriteLine();
            }
            while (!exit);
        }
    }
}