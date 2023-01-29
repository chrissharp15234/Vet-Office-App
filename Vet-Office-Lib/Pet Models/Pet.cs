using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vet_Office_Lib.Pet_Models
{
    abstract public class Pet
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }

        private string _rn;

        public string RegistrationNumber
        {
            get
            {
                return $"***-**-{_rn.Substring(_rn.Length - 4)}";
            }
            set
            {
                _rn = value;
            }
        }

        public abstract void Speak();
        public abstract string GetPetDetails();
    }
}
