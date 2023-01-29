using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Vet_Office_Lib.Enums.Dog;

namespace Vet_Office_Lib.Pet_Models
{
    public partial class Dog : Pet
    {
        public override void Speak()
        {
            Console.WriteLine("Ruff ruff!");
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
                _type = value;
            }
        }

        public override string GetPetDetails()
        {
            string st = this.Type.ToString();
            Enum.TryParse(st, out DogType value);

            return $"First Name: {FirstName} " +
                $"\nLast Name: {LastName} " +
                $"\nRegistration Number: {RegistrationNumber}" +
                $"\nPet Type: {value}";
        }

        /*public string GetPetDetailsWithRN(string rn)
        {

            return "";
        }*/
    }
}
