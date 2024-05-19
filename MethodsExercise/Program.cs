
using System.Drawing;

namespace MethodsExercise
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var  name = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            string animal = Console.ReadLine();

            Console.WriteLine("What is your favorite band?");
            string band = Console.ReadLine();

            Console.WriteLine($"Hey, {name}! I saw a {color} {animal} wearing a {band} concert shirt.");

        }

        
    }
}
