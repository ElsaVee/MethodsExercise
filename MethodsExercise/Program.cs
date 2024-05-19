
using System.ComponentModel;
using System.Drawing;

namespace MethodsExercise
{
    public class Program
    {

        static void Main(string[] args)
        {
           //Exercise 1
            
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine("What is your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"Hey, {name}! I saw a {color} {animal} wearing a {band} concert shirt.");

            //Exercise 2

            var addition = Add(2, 7);
            var subtration = Subtract(19, 9);
            var multiplication = Multiply(3, 7);
            var division = Divide(18,9);
            var mod = Modulus(3, 2);

            Console.WriteLine();
            Console.WriteLine($"Addition {addition}, Subtration {subtration}, Multiplication {multiplication}, Divide {division}, Modulus {mod}");
            
        }

      // Methods
        public static int Add(int x, int y)
        {
            
            return x + y;
        }

        public static int Subtract(int x, int y)
        {

            return x - y;
        }

        public static int Multiply(int x, int y)
        {

            return x * y;
        }

        public static int Divide(int x, int y)
        {

            return x / y;
        }

        public static int Modulus(int x, int y)
        {

            return x % y;
        }


    }
}
