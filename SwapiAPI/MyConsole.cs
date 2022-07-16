using SwapiAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapiAPI
{
    public class MyConsole
    {
        public void Print(Person person)
        {
            PrintBanner();
            PrintPerson(person);
            PrintVehicles(person.Vehicles);
            PrintStarships(person.Starships);
        }
        public void LeftRight()
        {
            Console.WriteLine("\n1. LEFT\n" +
                "2. RIGHT");
        }

        public void PrintPerson(Person person)
        {
            Console.WriteLine($"\n{person.Name}\n" +
                $"\nHeight: {person.Height}\n" +
                $"Birth Year: {person.BirthYear}");
        }

        private void PrintVehicles(List<Vehicle> vehicles)
        {
            if(vehicles.Count == 0)
            {
                Console.WriteLine("\nI don't have a vehicle. So I'll need a ride.");
            }
            else
            {
                Console.WriteLine("\nI've got my own ride.");

                foreach (Vehicle vehicle in vehicles)
                {
                    Console.WriteLine($"{vehicle.Manufacturer} {vehicle.Model}");
                }
            }
        }

        private void PrintStarships(List<Starship> starships)
        {
            if (starships.Count == 0)
            {
                Console.WriteLine("\nWe'll have to live in your starship.");
            }
            else
            {
                Console.WriteLine("\nAnd yes, I am a starship owner.");

                foreach (Starship starship in starships)
                {
                    Console.WriteLine($"{starship.Manufacturer} {starship.Model}");
                }
            }
        }

        private void PrintBanner()
        {
            Console.WriteLine(
                @"     _______.___________.    ___      .______         ____    __    ____  ___      .______          _______.   .___________. __  .__   __.  _______   _______ .______      " +
                "\n" +
                @"    /       |           |   /   \     |   _  \        \   \  /  \  /   / /   \     |   _  \        /       |   |           ||  | |  \ |  | |       \ |   ____||   _  \     " +
                "\n" +
                @"   |   (----`---|  |----`  /  ^  \    |  |_)  |        \   \/    \/   / /  ^  \    |  |_)  |      |   (----`   `---|  |----`|  | |   \|  | |  .--.  ||  |__   |  |_)  |    " +
                "\n" +
                @"    \   \       |  |      /  /_\  \   |      /          \            / /  /_\  \   |      /        \   \           |  |     |  | |  . `  | |  |  |  ||   __|  |      /     " +
                "\n" +
                @".----)   |      |  |     /  _____  \  |  |\  \----.      \    /\    / /  _____  \  |  |\  \----.----)   |          |  |     |  | |  |\   | |  '--'  ||  |____ |  |\  \----." +
                "\n" +
                @"|_______/       |__|    /__/     \__\ | _| `._____|       \__/  \__/ /__/     \__\ | _| `._____|_______/           |__|     |__| |__| \__| |_______/ |_______|| _| `._____|");
        }

    }
}
