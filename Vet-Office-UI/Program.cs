using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vet_Office_UI.UI;

namespace Vet_Office_UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! What would you like to do?");
            Console.Write("\nAdd Pet? (y/n) ");

            string answer = Console.ReadLine();

            if (answer.ToLower() == "y")
            {
                AddPet.addPet();
            }
            else
            {
                Console.WriteLine("\nThere's nothing else we can do for you!");
                Console.WriteLine("\nGoodbye!");
            }

            Console.ReadLine();
        }
    }
}
