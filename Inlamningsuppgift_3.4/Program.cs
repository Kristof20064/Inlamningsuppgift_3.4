using System;
using System.ComponentModel.Design;

namespace Inlamning_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många minuter är din musik?");
            int min = int.Parse(Console.ReadLine());

            Console.WriteLine("Hur många sekunder är din musik?");
            int sek = int.Parse(Console.ReadLine());

            if ((min == 2 && sek >= 45) || min > 2 && min < 4 || (min == 4 && sek <= 45))
            {
                Console.WriteLine("Din låt får spelas");
            }
            else

            {
                Console.WriteLine("Din låt får inte spelas");
            }
        }
    }
}
            