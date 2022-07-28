using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrbanPlanner
{
    internal class Building
    {
        public Building(string address)
        {
            _address = address;
        }

        private string _designer = "Sarah";
        private DateTime _dateConstructed;
        private string _address;
        private string _owner;

        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume => Width * Depth * (3 * Stories); //instructions say read-only but it doesn't work with "read-only"; why?

        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string purchaser)
        {
            _owner = purchaser;
        }

        public void DisplayInformation()
        {
            Console.WriteLine($@"{_address}---------------
Designed by {_designer}
Constructed on {_dateConstructed}
Owned by {_owner}
{Volume} cubic meters of space
");
        }

    }
}
