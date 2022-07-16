using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SwapiAPI.Models;
using SwapiAPI.Services;

namespace SwapiAPI
{
    public class UserInterface
    {
        private readonly SwapiService _service = new SwapiService();
        private readonly MyConsole _console = new MyConsole();
        private bool isRunning = true;
        private int id = 1;
        private string swipe;

        public async void Run()
        {
            Person luke = await GetPerson(id);
            _console.Print(luke);
            _console.LeftRight();
            swipe = Console.ReadLine();
            Swipe(swipe);

            while (isRunning)
            {
                Console.Clear();
                Person person = await GetPerson(id);
                _console.Print(person);
                _console.LeftRight();
                swipe = Console.ReadLine();
                Swipe(swipe);
            }
        }

        public void Swipe(string swipe)
        {
            switch(swipe)
            {
                case "1":
                    id -= 1;
                    break;
                case "2":
                default:
                    id += 1;
                    break;
            }
        }

        private async Task<Person> GetPerson(int id)
        {
            Person person = await _service.GetPersonAsync(id);
            List<Vehicle> vehicles = new List<Vehicle>();
            List<Starship> starships = new List<Starship>();

            foreach (string url in person.VehicleRequestURLs)
            {
                var vehicle = _service.GetAsync<Vehicle>(url).Result;

                if(vehicle != null)
                {
                    vehicles.Add(vehicle);
                }
            }

            foreach (string url in person.StarshipRequestURLs)
            {
                var starship = _service.GetAsync<Starship>(url).Result;

                if(starship != null)
                {
                    starships.Add(starship);
                }
            }

            person.Vehicles = vehicles;
            person.Starships = starships;

            return person;
        }

    }
}