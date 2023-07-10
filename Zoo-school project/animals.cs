using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_school_project
{
    class Animals
    {
        string animalID;
        string species;
        string name;
        int age;
        string habitat;
        bool availability;

        public Animals(string animalID, string species, string name, int age, string habitat, bool availability)
        {
            this.AnimalID = animalID;
            this.Species = species;
            this.Name = name;
            this.Age = age;
            this.Habitat = habitat;
            this.Availability = availability;
        }

        public string AnimalID { get => animalID; set => animalID = value; }
        public string Species { get => species; set => species = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Habitat { get => habitat; set => habitat = value; }
        public bool Availability { get => availability; set => availability = value; }
    }
}
