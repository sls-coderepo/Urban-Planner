using System;
using System.Collections.Generic;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Building> buildings = new List<Building>();

            Building FiveOneTwoEigth = new Building("512 8th Avenue");
            FiveOneTwoEigth.Width = 30;
            FiveOneTwoEigth.Stories = 3;
            FiveOneTwoEigth.Depth = 10;
            FiveOneTwoEigth.Construct();
            FiveOneTwoEigth.Purchase("Shirish");

            Building FourTwoTwo = new Building("422 8th Avenue");
            FourTwoTwo.Width = 30;
            FourTwoTwo.Stories = 3;
            FourTwoTwo.Depth = 11;
            FourTwoTwo.Construct();
            FourTwoTwo.Purchase("Mangal");

            //buildings.Add(FiveOneTwoEigth);
            //buildings.Add(FourTwoTwo);

            City city = new City("Nashville", "Shirish", 1920);
            city.Buildings.Add(FiveOneTwoEigth);
            city.Buildings.Add(FourTwoTwo);

            Console.WriteLine($"City: {city.CityName} Mayor: {city.MayorOfTheCity} Year Built: {city.YearBuilt} ");
            foreach (Building building in city.Buildings)
            {
                Console.WriteLine(building.Print());
            }

        }
    }
}