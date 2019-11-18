using System;
using System.Collections.Generic;

namespace Planner
{
    public class City
    {
        public string CityName { get; }
        public string MayorOfTheCity { get; }
        public int YearBuilt { get; }

        public List<Building> Buildings { get; set; }

        public City(string cityName, string mayorOfTheCity, int yearBuilt)
        {
            CityName = cityName;
            MayorOfTheCity = mayorOfTheCity;
            YearBuilt = yearBuilt;

            Buildings = new List<Building>();

        }

    }
}