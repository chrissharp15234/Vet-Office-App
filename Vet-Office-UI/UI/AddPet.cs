using System;
using System.Collections.Generic;
using Vet_Office_Lib.Data_Access;
using Vet_Office_Lib.Pet_Models;
using static Vet_Office_Lib.Enums.Cat;
using static Vet_Office_Lib.Enums.Dog;

namespace Vet_Office_UI.UI
{
    class AddPet
    {
        public static void addPet()
        {

            bool petBool;

            do
            {
                Console.Write("\nWhat kind of pet do you have? (dog, cat) ");
                string petType = Console.ReadLine();

                if (petType.ToLower() == "dog")
                {
                    Dog dog = new Dog();

                    string dogType, fn, ln, rn = "";
                    do
                    {
                        Console.Write("\nWhat type of dog do you have? (hound=0, boxer=1, pit=2) ");
                        dogType = Console.ReadLine();
                        if (dogType == "0" || dogType == "1" || dogType == "2")
                        {
                            dog.Type = (int)Enum.Parse(typeof(DogType), dogType);
                        }
                        else
                        {
                            Console.WriteLine("\nPlease choose either numbers 0, 1, or 2.");
                        }
                    } while (dogType != "0" && dogType != "1" && dogType != "2");

                    do
                    {
                        Console.Write("\nWhat is your dog's first name? ");
                        fn = Console.ReadLine();
                        if (fn != "")
                        {
                            dog.FirstName = fn;
                        }
                        else
                        {
                            Console.WriteLine("\nPlease enter a first name for your dog.");
                        }
                    } while (fn == "");

                    do
                    {
                        Console.Write("\nWhat is your dog's last name? ");
                        ln = Console.ReadLine();
                        if (ln != "")
                        {
                            dog.LastName = ln;
                        }
                        else
                        {
                            Console.WriteLine("\nPlease enter a last name for your dog.");
                        }
                    } while (ln == "");

                    do
                    {
                        Console.Write("\nWhat is your dog's registration number? ");
                        rn = Console.ReadLine();
                        if ((rn != "") && (rn.Length == 8))
                        {
                            dog.RegistrationNumber = rn;
                        }
                        else
                        {
                            Console.WriteLine("\nPlease enter an 8 digit registration number.");
                        }

                    } while ((rn == "") || (rn.Length != 8));

                    //Add dog to Data Access and CSV file
                    List<Dog> dogs = new List<Dog>();
                    dogs.Add(dog);
                    DataAccess<Dog> dataAccess = new DataAccess<Dog>();                    
                    dataAccess.SaveToCSV(dogs, @"C:\Users\chris\source\repos\Vet-Office-App\Vet-Office-Lib\Data Access\Database\Dogs.csv");
                    //----------------------------------

                    Console.WriteLine("\nOK, here are your pet's details: \n");
                    Console.WriteLine(dog.GetPetDetails());

                    petBool = false;
                }
                else if (petType.ToLower() == "cat")
                {
                    Cat cat = new Cat();
                    string catType, fn, ln, rn = "";
                    do
                    {
                        Console.Write("\nWhat type of cat do you have? (perisan=0, calico=1, tabby=2) ");
                        catType = Console.ReadLine();
                        if (catType == "0" || catType == "1" || catType == "2")
                        {
                            cat.Type = (int)Enum.Parse(typeof(CatType), catType);
                        }
                        else
                        {
                            Console.WriteLine("\nPlease choose either numbers 0, 1, or 2.");
                        }
                    } while (catType != "0" && catType != "1" && catType != "2");

                    do
                    {
                        Console.Write("\nWhat is your cat's first name? ");
                        fn = Console.ReadLine();
                        if (fn != "")
                        {
                            cat.FirstName = fn;
                        }
                        else
                        {
                            Console.WriteLine("\nPlease enter a first name for your cat.");
                        }
                    } while (fn == "");

                    do
                    {
                        Console.Write("\nWhat is your cat's last name? ");
                        ln = Console.ReadLine();
                        if (ln != "")
                        {
                            cat.LastName = ln;
                        }
                        else
                        {
                            Console.WriteLine("\nPlease enter a last name for your cat.");
                        }
                    } while (ln == "");

                    do
                    {
                        Console.Write("\nWhat is your cat's registration number? ");
                        rn = Console.ReadLine();
                        if ((rn != "") && (rn.Length == 8))
                        {
                            cat.RegistrationNumber = rn;
                        }
                        else
                        {
                            Console.WriteLine("\nPlease enter an 8 digit registration number.");
                        }

                    } while ((rn == "") || (rn.Length != 8));

                    Console.WriteLine("\nOK, here are your pet's details: \n");
                    Console.WriteLine(cat.GetPetDetails());

                    petBool = false;
                }
                else
                {
                    Console.WriteLine("\nPlease choose cat or dog.");
                    petBool = true;
                }
            } while (petBool);

        }
    }
    
}
