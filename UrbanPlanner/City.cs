using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrbanPlanner
{
    internal class City
    {
        public City(string name, int yearEstablished)
        {
            Name = name;
            YearEstablished = yearEstablished;
        }
        public string Mayor { get; set; }
        public string Name { get; set; }
        public int YearEstablished { get; set; }

        public List<Building> Buildings { get; set; } = new List<Building>(); //always have to instantiate a list!!!

        public void AddBuilding(Building buildingToAdd)
        {
            Buildings.Add(buildingToAdd);
        }

        public void AccessBuildingsList()
        {
            foreach(Building building in Buildings)
            {
                building.DisplayInformation();
            }
        }
    }
}
