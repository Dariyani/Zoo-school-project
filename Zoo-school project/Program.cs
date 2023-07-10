using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Zoo_school_project
{
    class Program
    {
        static void Main(string[] args)
        {
            string info = "Animal_Info.txt";
            try
            {

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File was not found please try again. ");
            }
        }
        static void PrintMenu()
        {
            Console.WriteLine("1. Add new animal in the zoo");
            Console.WriteLine("2. Change animal status");
            Console.WriteLine("3. Check availability and animal info");
            Console.WriteLine("4. Check all animals in the zoo");
        }
        static void chooseMenu()
        {
            Console.WriteLine("Choose a number(1-4).");
            string n = Console.ReadLine();
            switch (n)
            {
                case "1":
                    Addanimal();
                    break;
                case "2":
                    ChangeStatusOfAnimal();
                    break;
                case "3":
                   CheckNumberAndInfoAboutAnimal();
                    break;
                case "4":
                    ListOfAnimals();
                    break;
                default:
                    break;
            }
        }
        static void Addanimal()
        {

        }
        static void ChangeStatusOfAnimal()
        {

        }
        static void CheckNumberAndInfoAboutAnimal()
        {

        }
        static void ListOfAnimals()
        {

        }
    }
}
