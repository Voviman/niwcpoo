using System;
using System.Collections.Generic;
using System.Text;

namespace CarSell
{
    class IndustrialCar:Car
    {
        public Industry Industry { get; set; }
    }

    public enum Industry
    {
        business,
        construction,
        medical,
        mail,
        bank,
        delivery
    }
}
