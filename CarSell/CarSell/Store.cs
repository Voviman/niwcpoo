using System;
using System.Collections.Generic;
using System.Text;

namespace CarSell
{
    class Store
    {
        public List<Car> Cars { get; set; }
        public List<IndustrialCar> GetIndustrialCars()
        {
            List<IndustrialCar> industrialCars = new List<IndustrialCar>();
            foreach (Car car in ourStore.Cars)
            {
                if (car.Type == Type.Industrial)
                {
                    industrialCars.Add((IndustrialCar)car);
                }
            }
            return industrialCars;
        }

        private Store()
        {
            Cars = new List<Car>();
        }

        private static Store ourStore;

        public static Store GetStore()
        {
            if (ourStore == null)
            {
                ourStore = new Store();
            }
            return ourStore;
        }

        public List<Car> SearchCarByModel(string modelName)
        {
            List<Car> searchResults = new List<Car>();
            foreach (Car car in ourStore.Cars)
            {
                if (car.Model.ToLower().Contains(modelName.ToLower()))
                {
                    searchResults.Add(car);
                }
            }
            return searchResults;
        }

        public List<Car> SearchCarByIndustry(Industry industry)
        {
            List<Car> searchResults = new List<Car>();
            foreach (IndustrialCar car in ourStore.GetIndustrialCars())
            {
                if (car.Industry == industry)
                {
                    searchResults.Add(car);
                }
            }
            return searchResults;
        }

        public void PopulateCarsForTest()
        {
            Store st = GetStore();
            Car car1 = new IndustrialCar()
            {
                Model = "Sprinter",
                Brand = "Mercedes",
                Type = Type.Industrial,
                Price = 85000,
                Condition = Condition.Good,
                ProductionYear = 2019,
                Industry = Industry.medical
            };

            Car car2 = new IndustrialCar()
            {
                Model = "X7",
                Brand = "BMW",
                Type = Type.Industrial,
                Price = 75000,
                Condition = Condition.Normal,
                ProductionYear = 2017,
                Industry = Industry.business
            };

            Car car3 = new IndustrialCar()
            {
                Model = "Maverick",
                Brand = "Ford",
                Type = Type.Industrial,
                Price = 65000,
                Condition = Condition.Bad,
                ProductionYear = 2015,
                Industry = Industry.construction
            };

            Car car4 = new PassengerCar()
            {
                Model = "Malibu",
                Brand = "Chevrolet",
                Type = Type.Passanger,
                Price = 30000,
                Condition = Condition.New,
                ProductionYear = 2021,
            };

            Car car5 = new PassengerCar()
            {
                Model = "Vito",
                Brand = "Mercedes",
                Type = Type.Passanger,
                Price = 30000,
                Condition = Condition.Bad,
                ProductionYear = 2018,
            };

            st.Cars.Add(car1);
            st.Cars.Add(car2);
            st.Cars.Add(car3);
            st.Cars.Add(car4);
            st.Cars.Add(car5);
        }
    }
}
