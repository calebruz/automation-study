using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationStudy.SandboxApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var pet = new Pet("Fido", 2015, "dog", "1231231234");
            ScheduleVaccination(pet);
        }

        static void ScheduleVaccination(Pet pet)
        {
            Console.WriteLine(pet.Name + " was scheduled to be vaccinated!");
            Console.ReadKey();
        }
    }

    class Pet
    {
        public string Name { get; }
        public int BirthYear { get; }
        public string Breed { get; }

        public Pet(string name, int birthYear, string breed, string ownerSsn)
        {
            Name = name;
            BirthYear = birthYear;
            Breed = breed;
            _ownerSsn = ownerSsn;
        }

        private string _ownerSsn;
    }
}
