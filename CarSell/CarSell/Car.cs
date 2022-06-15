using System;
using System.Collections.Generic;
using System.Text;

namespace CarSell
{
    class Car
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string  Model { get; set; }
        public string Brand { get; set; }
        public Type Type { get; set; }
        public int Price { get; set; }
        public Condition Condition { get; set; }
        public int ProductionYear { get; set; }

        public int YearsUsed()
        {
            return DateTime.Now.Year - ProductionYear;
        }
    }

    public enum Condition
    {
        New,
        Good,
        Normal,
        Bad
    }

    public enum Type
    {
        Industrial,
        Passanger
    }
}
