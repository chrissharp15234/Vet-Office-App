using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Vet_Office_Lib.Enums.Cat;

namespace Vet_Office_Lib.Pet_Models
{
    public partial class Cat : Pet
    {
        public override void Speak()
        {
            Console.WriteLine("Meow meow!");
        }

        private int _type;

        public int Type
        {
            get
            {
                return _type;
            }
            set
            {
                if (value == 0 || value == 1 || value == 2)
                {
                    _type = value;
                }
                else
                {
                    Console.WriteLine("Please choose a value of 0, 1, or 2.");
                    return;
                }
            }
        }

        public override string GetPetDetails()
        {
            string st = this.Type.ToString();
            Enum.TryParse(st, out CatType value);

            return $"First Name: {FirstName} " +
                $"\nLast Name: {LastName} " +
                $"\nRegistration Number: {RegistrationNumber}" +
                $"\nPet Type: {value}";
        }
    }
}
