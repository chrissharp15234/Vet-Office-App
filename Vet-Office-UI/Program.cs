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
            Console.WriteLine("\nAdd Pet? (press 0)");
            Console.WriteLine("Get Pet? (press 1)\n");

            string answer = Console.ReadLine();

            if (answer.ToLower() == "0")
            {
                AddPet.addPet();
            }
            else if(answer.ToLower() == "1")
            {
                GetPet.getPet();
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
