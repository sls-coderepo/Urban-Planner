using System;

namespace Planner
{
    public class Building
    {
        private string _designer = "Shirish";
        private DateTime _dateConstructed;
        private string _address;
        private string _owner;
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume
        {
            get
            {
                double totalVolume;
                totalVolume = Width * Depth * (3 * Stories);
                return totalVolume;
            }

        }

        public Building(string address)
        {
            _address = address;
            _dateConstructed = DateTime.Now;
        }

        public Building()
        {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string owner)
        {
            _owner = owner;
        }

        public string Print()
        {
            return $"Designed by {_designer} \n Constructed on {_dateConstructed} \n Owned by {_owner} \n {Volume} cubic meters of space";

        }

    }
}